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
    public partial class frmManual3 : Form
    {
        public frmManual3()
        {
            InitializeComponent();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            frmManual4 quinto = new frmManual4();
            quinto.Show();      // chamar o formulario Manual do Usuario
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmManual2 terceiro = new frmManual2();
            terceiro.Show();      // chamar o formulario Manual do Usuario
            this.Close();
        }
    }
}
