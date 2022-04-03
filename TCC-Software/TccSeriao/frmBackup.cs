using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace TccSeriao
{
    public partial class frmBackup : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader ler;
        String sql = "";
        String conexao = "";


        public void limparDados()
        {
            txtLocal.Text = "";
            txtLocalPatch.Text = "";
            txtSenhaBak.Text = "";
            txtServidor.Text = "";
            txtUsuarioBak.Text = "";
            cbbBancoDados.SelectedIndex = -1;
        }
        public frmBackup()
        {
            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
                if (txtServidor.Text == String.Empty)

                {
                    MessageBox.Show("Preencha os campos para Conectar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txtUsuarioBak.Text == String.Empty)
                {
                    MessageBox.Show("Preencha os campos para Conectar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSenhaBak.Text == String.Empty)
                {
                    MessageBox.Show("Preencha os campos para Conectar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                }

                try
                {
                    conexao = "Data Source=" + txtServidor.Text + "; User Id=" + txtUsuarioBak.Text + "; Password=" + txtSenhaBak.Text + "";
                    con = new SqlConnection(conexao);
                    con.Open();
                    sql = "EXEC sp_databases";
                    cmd = new SqlCommand(sql, con);
                    ler = cmd.ExecuteReader();
                    cbbBancoDados.Items.Clear();
                    while (ler.Read())
                    {
                        cbbBancoDados.Items.Add(ler[0].ToString());
                    }
                    ler.Dispose();
                    con.Close();
                    con.Dispose();
                    txtServidor.Enabled = false;
                    txtUsuarioBak.Enabled = false;
                    txtSenhaBak.Enabled = false;
                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                    btnBackup.Enabled = true;
                    btnRestaurar.Enabled = true;
                    cbbBancoDados.Enabled = true;

                }
                catch (Exception )
                {
                    MessageBox.Show("Erro, Servidor não Encontrado!");
                }
            }
           
            
        
    

        private void frmBackup_Load(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = false;
            btnRestaurar.Enabled = false;
            btnBackup.Enabled = false;
            cbbBancoDados.Enabled = false;
            limparDados();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            txtServidor.Enabled = true;
            txtUsuarioBak.Enabled = true;
            txtSenhaBak.Enabled = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            cbbBancoDados.Enabled = false;
            btnBackup.Enabled = false;
            btnRestaurar.Enabled = false;
            limparDados();
            con.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLocal_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocal.Text = dlg.SelectedPath;
            }
            else
            {

            }
        }

        private void btnBackup_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbbBancoDados.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione um Banco de Dados!");
                    return;
                }
                con = new SqlConnection(conexao);
                con.Open();
                sql = "BACKUP DATABASE " + cbbBancoDados.Text + " TO DISK = '" + txtLocal.Text + "\\" + cbbBancoDados.Text + "" + ".bak'";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("Backup Concluído");

            }
            catch (Exception )
            {

                MessageBox.Show("Erro, não é Possivel fazer Backup");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocalPatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocalPatch.Text = dlg.FileName;
            }
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbBancoDados.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione um Banco de Dados!");
                    return;
                }
                con = new SqlConnection(conexao);
                con.Open();
                sql = "Alter Database "+cbbBancoDados.Text+" Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql = "Restore Database "+cbbBancoDados.Text + " FROM DISK = '"+txtLocalPatch.Text +"' WITH REPLACE;";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("Restauração Concluída!");

            }
            catch (Exception )
            {

                MessageBox.Show("Erro, não é Possivel Restaurar");
            }
        }

        private void txtLocalPatch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
