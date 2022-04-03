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
using Microsoft.VisualBasic;
namespace TccSeriao
{
    public partial class frmVendas : Form
    {
        private string _configuracao = Application.StartupPath + "\\configuracao.cfg";
        string conexao = "Data Source=IZILAB108;Initial Catalog=bookBeans;Integrated Security=True";
        DataSet ds; // armazenar valor
        SqlDataAdapter adapter; //adaptador
        DataTable tabela = new DataTable();
        int ultimaVenda;
        DataRow linha;
        double totValor;
        int quantidade;
        public frmVendas()
        {
            InitializeComponent();
        }
        public void carregarDados() // metodos para carregar dados mas nao vai exibir.
        {
            String sql = "SELECT*FROM produtos";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "produtos"); // executa o programa preencher
            con.Close();

        }
        public void limpardados() {
            txtNome.Text = "";
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            var cfg = System.IO.File.ReadAllText(_configuracao);
            var chave = cfg.Split('|');
            String Servidor = chave[0];
            String Usuario = chave[1];
            String Senha = chave[2];
            String cbbBanco = chave[3];
            conexao = "Data Source =" + Servidor + "; Initial Catalog =" + cbbBanco + "; User Id=" + Usuario + "; Password=" + Senha + ";";

            txtValorTotal.Enabled = false;
            tabela.Columns.Add("Id");
            tabela.Columns.Add("Nome");
            tabela.Columns.Add("Quantidade");
            tabela.Columns.Add("Preço");
            tabela.Columns.Add("Estoque");
            txtValorTotal.Enabled = false;
            txtTroco.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty)

            {
                MessageBox.Show("Escreva o nome do produto para Pesquisar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else 
            {
                string sql = "SELECT * FROM produtos WHERE titulo_produto LIKE '%" + txtNome.Text+"%'";
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                con.Open();
                try
                {
                    adapter.Fill(ds, "produtos");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
                //carregarDados();
                gridCarregar.DataSource = ds.Tables[0];
                gridCarregar.Refresh();
                {
                    
                }

            }
        }

        private void gridVendas_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }

        private void gridCarregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            quantidade = Convert.ToInt32(Interaction.InputBox("Informe a quantidade", "Venda", "0"));
            if (quantidade <= Convert.ToUInt32(gridCarregar.Rows[gridCarregar.CurrentCell.RowIndex].Cells[7].Value.ToString()))
            {
               string id =  gridCarregar.Rows[gridCarregar.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string nome = gridCarregar.Rows[gridCarregar.CurrentCell.RowIndex].Cells[3].Value.ToString();
                //gridVenda.Rows.Add();
                double preco = Convert.ToDouble(gridCarregar.Rows[gridCarregar.CurrentCell.RowIndex].Cells[6].Value.ToString());
                int estoque = Convert.ToInt32(gridCarregar.Rows[gridCarregar.CurrentCell.RowIndex].Cells[7].Value.ToString());
                 linha = tabela.NewRow();
                linha[0] = id;
                linha[1] = nome;
                linha[2] = quantidade;
                linha[3] = preco;
                linha[4] = estoque;
                tabela.Rows.Add(linha);
                gridVenda.DataSource = tabela;
                gridVenda.Refresh();
                totValor = totValor + quantidade*preco;
                txtValorTotal.Text = totValor.ToString();
               

            }
            else
            {
                MessageBox.Show("Você não pode vender uma quantidade maior que a existente no estoque");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO vendas(dataVenda) VALUES('" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "')";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    
                    String sql2 = "SELECT id_Venda FROM vendas";
                    SqlConnection con2 = new SqlConnection(conexao);
                    SqlCommand cmd2 = new SqlCommand(sql2, con2);
                    cmd2.CommandType = CommandType.Text;
                    con2.Open();
                    adapter = new SqlDataAdapter(cmd2);
                    DataSet dsVenda = new DataSet();
                    adapter.Fill(dsVenda, "vendas"); // executa o programa preencher
                    con.Close();
                    
                    ultimaVenda = Convert.ToInt32(dsVenda.Tables[0].Rows[dsVenda.Tables[0].Rows.Count - 1][0].ToString());
                    foreach (DataRow linha in tabela.Rows)
                    {
                        double subTotal = Convert.ToDouble(linha[2].ToString()) * Convert.ToDouble(linha[3].ToString());
                        string sql3 = "INSERT INTO itemVenda(quant_itemVenda, id_Produto, id_Venda, Valor_Venda) VALUES('" + linha[2] + "', '"
                + linha[0] + "', '" + ultimaVenda + "','" + subTotal + "')";
                        SqlConnection con3 = new SqlConnection(conexao);
                        SqlCommand cmd3 = new SqlCommand(sql3, con3);
                        cmd3.CommandType = CommandType.Text;
                        con3.Open();
                        try
                        {
                            int im = cmd3.ExecuteNonQuery();
                            if (im > 0)
                            {
                              
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERRO: " + ex.ToString());
                        }
                        finally
                        {
                            con.Close();
                            

                        }
                        int atual = Convert.ToInt32(linha[4]) - Convert.ToInt32(linha[2]);
                        string sql4 = "UPDATE produtos SET quantidade_Produto = "+atual+" WHERE id_Produto=" + linha[0];
                        SqlConnection con4 = new SqlConnection(conexao);
                        SqlCommand cmd4 = new SqlCommand(sql4, con4);
                        cmd4.CommandType = CommandType.Text;
                        con4.Open();
                        try
                        {
                            int inn = cmd4.ExecuteNonQuery();
                            if (inn > 0)
                            {
                                MessageBox.Show("Venda Realizada");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERRO: " + ex.ToString());
                        }
                        finally
                        {
                            con4.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            int troco = Convert.ToInt32(txtValorRecebido.Text) - Convert.ToInt32(txtValorTotal.Text);
            txtTroco.Text = troco.ToString();
        }
    }
}
