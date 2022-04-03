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

    public partial class frmProdutos : Form
    {
       private string _configuracao = Application.StartupPath + "\\configuracao.cfg";
        string conexao = "Data Source=IZILAB108;Initial Catalog=bookBeans;Integrated Security=True";
        DataSet ds; // armazenar valor
        SqlDataAdapter adapter; //adaptador


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

        public void limparDados()
        {
            txtTitulo.Text = "";
            txtEditora.Text = "";
            txtAnoPubli.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            txtDescricao.Text = "";
            cbbCategoria.SelectedIndex = -1;
            cbbConservacao.SelectedIndex = -1;

        }

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {

            var cfg = System.IO.File.ReadAllText(_configuracao);
            var chave = cfg.Split('|');
            String Servidor = chave[0];
            String Usuario = chave[1];
            String Senha = chave[2];
            String cbbBanco = chave[3];
            conexao = "Data Source =" + Servidor + "; Initial Catalog =" + cbbBanco + "; User Id=" + Usuario + "; Password=" + Senha+";";

            carregarDados();
            gridProduto.DataSource = ds.Tables[0];
            gridProduto.Refresh();
            {
                txtIDProduto.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {

            {
                btnSalvarProduto.Enabled = true;
                btnNovoProduto.Enabled = false;
                btnAlterarProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;

            }
        }

        private void cbbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {

            if (txtTitulo.Text == String.Empty)

            {
                MessageBox.Show("Preencha os campos para Salvar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbbCategoria.Text == String.Empty)
            {
                MessageBox.Show("Preencha os campos para Salvar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbConservacao.Text == String.Empty)
            {
                MessageBox.Show("Preencha os campos para Salvar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPreco.Text == String.Empty)
            {
                MessageBox.Show("Preencha os campos para Salvar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQuantidade.Text == String.Empty)
            {
                MessageBox.Show("Preencha os campos para Salvar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string sql = "INSERT INTO produtos(titulo_Produto, editora_Produto, ano_Produto, preco_Produto, quantidade_Produto, descricao_Produto, categoria_Produto, conservacao_Produto) VALUES('" + txtTitulo.Text + "', '"
                 + txtEditora.Text + "', '" + txtAnoPubli.Text + "','" +Convert.ToDouble(txtPreco.Text)+ "', '" + txtQuantidade.Text + "','" + txtDescricao.Text + "','" + cbbCategoria.Text + "','" + cbbConservacao.Text + "')";
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro Incluído com sucesso");
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
                gridProduto.DataSource = ds.Tables[0];
                gridProduto.Refresh();
                {
                    limparDados();
                    btnSalvarProduto.Enabled = false;
                }
            }

            btnAlterarProduto.Enabled = true;
            btnExcluirProduto.Enabled = true;
            btnNovoProduto.Enabled = true;
            btnSalvarProduto.Enabled = false;
        }


        private void gridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void gridProduto_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridProduto.SelectedRows)
            {
                txtIDProduto.Text = row.Cells[0].Value.ToString();
                cbbCategoria.Text = row.Cells[1].Value.ToString();
                cbbConservacao.Text = row.Cells[2].Value.ToString();
                txtTitulo.Text = row.Cells[3].Value.ToString();
                txtEditora.Text = row.Cells[4].Value.ToString();
                txtAnoPubli.Text = row.Cells[5].Value.ToString();
                txtPreco.Text = row.Cells[6].Value.ToString();
                txtQuantidade.Text = row.Cells[7].Value.ToString();
                txtDescricao.Text = row.Cells[8].Value.ToString();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == String.Empty)

            {
                MessageBox.Show("Selecione um registro para Alterar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbbCategoria.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Alterar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbConservacao.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Alterar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPreco.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Alterar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQuantidade.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Alterar!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "UPDATE produtos SET categoria_Produto= '" + cbbCategoria.Text + "' , conservacao_Produto= '" + cbbConservacao.Text + "' , titulo_produto= '" + txtTitulo.Text + "' , editora_Produto= '" + txtEditora.Text + "' , ano_Produto='" +
            txtAnoPubli.Text + "' , preco_Produto= '" + Convert.ToDouble(txtPreco.Text) + "' , quantidade_Produto= '" + txtQuantidade.Text + "' , descricao_Produto= '" + txtDescricao.Text + "'WHERE id_Produto=" + txtIDProduto.Text;
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
                gridProduto.DataSource = ds.Tables[0];
                gridProduto.Refresh();
                {
                    limparDados();
                }

            }
        }

        private void txtIDProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == String.Empty)

            {
                MessageBox.Show("Selecione um registro para Excluir!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbbCategoria.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Excluir!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbConservacao.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Excluir!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPreco.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Excluir!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQuantidade.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro para Excluir!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "DELETE FROM  produtos WHERE id_Produto = " + txtIDProduto.Text;
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
                gridProduto.DataSource = ds.Tables[0];
                gridProduto.Refresh();
                {
                    limparDados();
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == String.Empty)

            {
                MessageBox.Show("Escreva o Nome do Produto!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string sql = "SELECT * FROM produtos WHERE titulo_Produto LIKE '%" + txtPesquisar.Text + "%'";
                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                con.Open();
                try
                {
                    adapter.Fill(ds, "Produtos");


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
                gridProduto.DataSource = ds.Tables[0];
                gridProduto.Refresh();
                {

                }
            }
        }
    }
}
                

                
            
    


