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
    public partial class frmManual2 : Form
    {
        public frmManual2()
        {
            InitializeComponent();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            frmManual3 quarto = new frmManual3();
            quarto.Show();      // chamar o formulario Manual do Usuario
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmManual1 segundo = new frmManual1();
            segundo.Show();      // chamar o formulario Manual do Usuario
            this.Close();
        }
    }
}
