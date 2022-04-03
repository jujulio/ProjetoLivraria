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
    public partial class frmConectar : Form
    {
        private string _configuracao = Application.StartupPath + "\\configuracao.cfg";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader ler;
        String sql = "";
        String conexao = "";
        public frmConectar()
        {
            InitializeComponent();
        }

        private void frmConectar_Load(object sender, EventArgs e)
        {

            var cfg = System.IO.File.ReadAllText(_configuracao);
            var chave = cfg.Split('|');
            txtServidorBanco.Text = chave[0];
            txtUserServ.Text = chave[1];
            txtSenhaServ.Text = chave[2];
            cbbBancos.Text = chave[3];



        }

        private void btnConectarServ_Click(object sender, EventArgs e)
        {
            if (txtServidorBanco.Text == String.Empty)

            {
                MessageBox.Show("Preencha os campos para Conectar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtUserServ.Text == String.Empty)
            {
                MessageBox.Show("Preencha os campos para Conectar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtSenhaServ.Text == String.Empty)
            {
                MessageBox.Show("Preencha os campos para Conectar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }

            try
            {
                conexao = "Data Source=" + txtServidorBanco.Text + ";User Id=" + txtUserServ.Text + "; Password=" + txtSenhaServ.Text + ";";
                con = new SqlConnection(conexao);
                con.Open();
                sql = "EXEC sp_helpdb";
                cmd = new SqlCommand(sql, con);
                ler = cmd.ExecuteReader();
                cbbBancos.Items.Clear();
                while (ler.Read())
                {
                    cbbBancos.Items.Add(ler[0].ToString());
                }
                con.Close();
                ler.Dispose();
                con.Dispose();


            }
            catch (Exception)
            {
                MessageBox.Show("Erro, Servidor não Encontrado!");
                
            }
            txtConectar.Enabled = false;

            txtSenhaServ.Enabled = false;
            txtServidorBanco.Enabled = false;
            txtUserServ.Enabled = false;


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBancos.SelectedIndex == -1)
            {

            }
            else
            {
                cbbBancos.Enabled = false;

            }
        }
        private void btnDesconectarServ_Click(object sender, EventArgs e)
        {




        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var chaves = string.Format("{0}|{1}|{2}|{3}", txtServidorBanco.Text, txtUserServ.Text, txtSenhaServ.Text, cbbBancos.Text);
            System.IO.File.WriteAllText(_configuracao, chaves);
            btnSalvar.Enabled = false;
            cbbBancos.Enabled = false;
           
        }

        private void frmConectar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmConectar_FormClosing(object sender, FormClosingEventArgs e)
        {
            var chaves = string.Format("{0}|{1}|{2}|{3}", txtServidorBanco.Text, txtUserServ.Text, txtSenhaServ.Text, cbbBancos.Text);
            System.IO.File.WriteAllText(_configuracao, chaves);
        }
    }
}
