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
    public partial class FormMinParaHoras : Form
    {
        public FormMinParaHoras()
        {
            InitializeComponent();
        }

        private void btConverterHecAlq_Click(object sender, EventArgs e)
        {
            double valorMin2 = 0;
            double valorHoras2 = 0;
            valorMin2 = Convert.ToDouble(txtMin2.Text);
            valorHoras2 = valorMin2 / 60;

            txtHoras2.Text = valorHoras2.ToString("F2");
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtHoras2.Clear();
            txtMin2.Clear();
            txtMin2.Select();
        }
    }
}
