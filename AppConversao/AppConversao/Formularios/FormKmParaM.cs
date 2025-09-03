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
    public partial class FormKmParaM : Form
    {
        public FormKmParaM()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double valorKm = 0;
            double valorM = 0;

            valorKm = Convert.ToDouble(txtKm.Text);
            valorM = valorKm * 1000;

            txtM.Text = valorM.ToString("F2");

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtKm.Clear();
            txtM.Clear();
            txtKm.Select();
        }
    }
}
