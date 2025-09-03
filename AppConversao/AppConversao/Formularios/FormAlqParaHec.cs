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
    public partial class FormAlqParaHec : Form
    {
        public FormAlqParaHec()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double valorAlq = 0;
            double valorHec = 0;

            valorAlq = Convert.ToDouble(txtAlq.Text);

            valorHec = valorAlq * 2.42;

            txtHec.Text = valorHec.ToString("F2");


        }

        private void txtHec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtAlq.Clear();
            txtHec.Clear();
            txtAlq.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAlq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
