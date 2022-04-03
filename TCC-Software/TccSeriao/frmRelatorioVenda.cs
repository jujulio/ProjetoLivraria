using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccSeriao
{
    public partial class frmRelatorioVenda : Form
    {
        private string _configuracao = Application.StartupPath + "\\configuracao.cfg";
        string conexao = "Data Source=IZILAB108;Initial Catalog=bookBeans;Integrated Security=True";
        DataSet ds; // armazenar valor
        SqlDataAdapter adapter; //adaptador
        public frmRelatorioVenda()
        {
            InitializeComponent();
        }
        public void carregarDados() // metodos para carregar dados mas nao vai exibir.
        {
            String sql = "SELECT*FROM vendas";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "vendas"); // executa o programa preencher
            con.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDataVenda.Text == String.Empty)

            {
                MessageBox.Show("Informe a Data!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string sql = "SELECT * FROM Vendas WHERE dataVenda LIKE '%" + txtDataVenda.Text + "%'";
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                con.Open();
                try
                {
                    adapter.Fill(ds, "Vendas");


                }
                catch (Exception)
                {
                    MessageBox.Show("Erro, Relatório não Encontrado! ");
                }
                finally
                {
                    con.Close();
                }

                gridRelatorio.DataSource = ds.Tables[0];
                gridRelatorio.Refresh();
                {

                }
            }
        }

        private void frmRelatorioVenda_Load(object sender, EventArgs e)
        {
            var cfg = System.IO.File.ReadAllText(_configuracao);
            var chave = cfg.Split('|');
            String Servidor = chave[0];
            String Usuario = chave[1];
            String Senha = chave[2];
            String cbbBanco = chave[3];
            conexao = "Data Source =" + Servidor + "; Initial Catalog =" + cbbBanco + "; User Id=" + Usuario + "; Password=" + Senha + ";";
            carregarDados();
            gridRelatorio.DataSource = ds.Tables[0];
            gridRelatorio.Refresh();
        }
    }
}
