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
    public partial class FormHecParaAlq : Form
    {
        public FormHecParaAlq()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double valorHec2 = 0;
            double valorAlq2 = 0;

            valorHec2 = Convert.ToDouble(txtHec2.Text);

            valorAlq2 = valorHec2 / 2.42;

            txtAlq2.Text = valorAlq2.ToString("F2");
        }

        private void txtHec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAlq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtHec2.Clear();
            txtAlq2.Clear();
            txtHec2.Select();
        }
    }
}
