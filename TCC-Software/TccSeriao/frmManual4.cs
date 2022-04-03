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
    public partial class frmManual4 : Form
    {
        public frmManual4()
        {
            InitializeComponent();
        }

        private void frmManual4_Load(object sender, EventArgs e)
        {
            btnAvançar.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmManual3 quarto = new frmManual3();
            quarto.Show();      // chamar o formulario Manual do Usuario
            this.Close();
        }
    }
}
