using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConversao.Formularios
{
    public partial class FormMparaKm : Form
    {
        public FormMparaKm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double valorM1 = 0;
            double valorKm1 = 0;
            valorM1 = Convert.ToDouble(txtM1.Text);
            valorKm1 = valorM1 / 1000;

            txtKm1.Text = valorKm1.ToString("F2");
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtKm1.Clear();
            txtM1.Clear();
            txtM1.Select();
        }
    }
}
