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
    public partial class frmManual0 : Form
    {
        public frmManual0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManual1 segundo = new frmManual1();
            segundo.Show();      // chamar o formulario Manual do Usuario
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManual0_Load(object sender, EventArgs e)
        {
            btnVoltar.Enabled = false;
        }
    }
}
