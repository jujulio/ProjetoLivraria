using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccSeriao
{
    public partial class frmLogin : Form
    {
        public void limparDados() {
            txtUsuario.Text = "";
            txtSenha.Text = "";

        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "softbeans") && (txtSenha.Text == "12345"))
            {

                frmPainel painel = new frmPainel();
                painel.Show();
                this.Visible = true;

                frmConectar conectar = new frmConectar();
                conectar.Show();
                this.Visible = true;
                
            }
            else {
                limparDados();
                MessageBox.Show("Usuário ou Senha inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
