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
    public partial class frmPainel : Form
    {
        public object BackupActionType { get; private set; }

        public frmPainel()
        {

            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

            this.lbHora.Text = DateTime.Now.ToShortTimeString();
      


        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFornecedoresCadastrar>().Count() > 0)
            {
                MessageBox.Show("O formulario (Cadastrar Clientes/Fornecedores) já está aberto!");
            }
            else
            {


                frmFornecedoresCadastrar fornecedorCadastro = new frmFornecedoresCadastrar();
                fornecedorCadastro.btnSalvarFornecedor.Enabled = false;
                fornecedorCadastro.MdiParent = this;
                fornecedorCadastro.Show();      // chamar o formulario cadastrar fornecedor

            }


        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmProdutos>().Count() > 0)
            {
                MessageBox.Show("O formulario (Cadastrar Produtos) já está aberto!");
            }
            else
            {

                frmProdutos produtoCadastro = new frmProdutos();
                produtoCadastro.btnSalvarProduto.Enabled = false;
                produtoCadastro.MdiParent = this;
                produtoCadastro.Show();      // chamar o formulario cadastrar Produto 
            }
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exibirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exibirToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void exibirToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVendas>().Count() > 0)
            {
                MessageBox.Show("O formulario (Caixa) já está aberto!");
            }
            else
            {
                frmVendas vendas = new frmVendas();
                vendas.MdiParent = this;
                vendas.Show();      // chamar o formulario exibir vendas
            }
        }

        private void exibirToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void softBeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSoftBeans>().Count() > 0)
            {
                MessageBox.Show("O formulario (SoftBeans) já está aberto!");
            }
            else
            {
                frmSoftBeans empresa = new frmSoftBeans();
                empresa.MdiParent = this;
                empresa.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            backup.MdiParent = this;
            backup.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelatorioVenda>().Count() > 0)
            {
                MessageBox.Show("O formulario (Relatorio) já está aberto!");
            }
            else
            {
                frmRelatorioVenda relatorio = new frmRelatorioVenda();
                relatorio.MdiParent = this;
                relatorio.Show();      // chamar o formulario relatorio
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void servidorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmConectar>().Count() > 0)
            {
                MessageBox.Show("O formulario (Cadastrar Conectar com o Servidor) já está aberto!");
            }
            else
            {
                frmConectar conectar = new frmConectar();
                conectar.MdiParent = this;
                conectar.Show();      // chamar o formulario relatorio
            }
        }

        private void manualDoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmManual0>().Count() > 0)
            {
                MessageBox.Show("O formulario ( Manual do Usuario) já está aberto!");
            }
            else
            {
                frmManual0 primeiro = new frmManual0();
                primeiro.MdiParent = this;
                primeiro.Show();      // chamar o formulario Manual do Usuario
            }
        }

        private void frmPainel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
