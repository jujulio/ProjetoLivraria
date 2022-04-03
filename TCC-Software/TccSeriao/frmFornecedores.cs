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
using System.Data.Sql;



namespace TccSeriao
{
    public partial class frmFornecedoresCadastrar : Form {
        private string _configuracao = Application.StartupPath + "\\configuracao.cfg";
        string conexao = "Data Source=IZILAB108;Initial Catalog=bookBeans;Integrated Security=True";
        DataSet ds; // armazenar valor
        SqlDataAdapter adapter; //adaptador
        

        public void carregarDados() // metodos para carregar dados mas nao vai exibir.
        {
            String sql = "SELECT*FROM fornecedores";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "fornecedores"); // executa o programa preencher
            con.Close();

        }


        public void limparDados() {
            txtIDFornecedor.Text = "";
            txtNomeFornecedor.Text = "";
            txtTelefoneFornecedor.Text = "";
            txtEmailFornecedor.Text = "";
            txtcnpjFornecedor.Text = "";
            txtcpfFornecedor.Text = "";
            cbbFornecedor.SelectedIndex = -1;



        }

        
        public frmFornecedoresCadastrar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFornecedoresCadastrar_Load(object sender, EventArgs e)
        {
            var cfg = System.IO.File.ReadAllText(_configuracao);
            var chave = cfg.Split('|');
            String Servidor = chave[0];
            String Usuario = chave[1];
            String Senha = chave[2];
            String cbbBanco = chave[3];
            conexao = "Data Source =" + Servidor + "; Initial Catalog =" + cbbBanco + "; User Id=" + Usuario + "; Password=" + Senha + ";";
            {
                limparDados();
            }
            carregarDados();
            gridFornecedor.DataSource = ds.Tables[0];
            gridFornecedor.Refresh();
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text == String.Empty)

            {
                MessageBox.Show("Preencha os campos para Salvar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbbFornecedor.Text == String.Empty) {
                      MessageBox.Show("Preencha os campos para Salvar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "INSERT INTO fornecedores(nome_Fornecedor, email_Fornecedor,telefone_Fornecedor, cnpj_Fornecedor, cpf_Fornecedor, tipo_Fornecedor) VALUES('" + txtNomeFornecedor.Text + "', '"
             + txtEmailFornecedor.Text + "', '" + txtTelefoneFornecedor.Text + "','" + txtcnpjFornecedor.Text + "', '" + txtcpfFornecedor.Text + "','" + cbbFornecedor.Text + "')";
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro Incluído com sucesso.");
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
                carregarDados();
                gridFornecedor.DataSource = ds.Tables[0];
                gridFornecedor.Refresh();
                {
                    limparDados();
                    btnSalvarFornecedor.Enabled = false;
                }

            }
            btnAlterarFornecedor.Enabled = true;
            btnExcluirFornecedor.Enabled = true;
            btnSalvarFornecedor.Enabled = false;
            btnNovoFornecedor.Enabled = true;
        }
    

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            
            
            txtNomeFornecedor.Focus();
            btnNovoFornecedor.Enabled = false;
            btnSalvarFornecedor.Enabled = true;
            btnAlterarFornecedor.Enabled = false;
            btnExcluirFornecedor.Enabled = false;

        }

        private void txtIDFornecedor_TextChanged(object sender, EventArgs e)
        {
            txtIDFornecedor.Enabled = false;
        }

        private void cbbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFornecedor.SelectedIndex == 0) //fisica
            {
                txtcnpjFornecedor.Enabled = false;
                txtcpfFornecedor.Enabled = true;

            }
            else { //juridica
                txtcnpjFornecedor.Enabled = true;
                txtcpfFornecedor.Enabled = false;
             }
            
        }

        private void gridFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text == String.Empty)

            {
                MessageBox.Show("Selecione um registro para Alterar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbbFornecedor.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Alterar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "UPDATE fornecedores SET nome_fornecedor= '" + txtNomeFornecedor.Text + "' , email_fornecedor= '" + txtEmailFornecedor.Text + "' , telefone_fornecedor= '" + txtTelefoneFornecedor.Text + "' , cnpj_fornecedor= '" + txtcnpjFornecedor.Text + "' , cpf_fornecedor='" +
            txtcpfFornecedor.Text + "' , tipo_fornecedor= '" + cbbFornecedor.Text + "'WHERE id_fornecedor=" + txtIDFornecedor.Text;
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro Alterado com sucesso");
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
                carregarDados();
                gridFornecedor.DataSource = ds.Tables[0];
                gridFornecedor.Refresh();
                limparDados();
                {

                }
            }
        }
        private void gridFornecedor_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void gridFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridFornecedor.SelectedRows)
            {
                txtIDFornecedor.Text = row.Cells[0].Value.ToString();
                txtNomeFornecedor.Text = row.Cells[1].Value.ToString();
                txtEmailFornecedor.Text = row.Cells[2].Value.ToString();
                txtTelefoneFornecedor.Text = row.Cells[3].Value.ToString();        
                txtcnpjFornecedor.Text = row.Cells[4].Value.ToString();
                txtcpfFornecedor.Text = row.Cells[5].Value.ToString();
                cbbFornecedor.Text = row.Cells[6].Value.ToString();
                
            }
            
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text == String.Empty)

            {
                MessageBox.Show("Selecione um registro para Excluir!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbbFornecedor.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Excluir!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string sql = "DELETE FROM  fornecedores WHERE id_Fornecedor = " + txtIDFornecedor.Text;
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro Excluido com sucesso");
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

                carregarDados();
                gridFornecedor.DataSource = ds.Tables[0];
                gridFornecedor.Refresh();
                {
                    limparDados();

                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovoFornecedor.Enabled = true;
            btnSalvarFornecedor.Enabled = false;
            btnAlterarFornecedor.Enabled = true;
            btnExcluirFornecedor.Enabled = true;
            limparDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == String.Empty)

            {
                MessageBox.Show("Escreva o Nome do Fornecedor!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string sql = "SELECT * FROM fornecedores WHERE nome_Fornecedor LIKE '%" + txtPesquisar.Text + "%'";
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                con.Open();
                try
                {
                    adapter.Fill(ds, "fornecedores");


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
                gridFornecedor.DataSource = ds.Tables[0];
                gridFornecedor.Refresh();
                {

                }

            }
        }
    }
}
