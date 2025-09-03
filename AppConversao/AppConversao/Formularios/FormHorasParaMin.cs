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
    public partial class FormHorasParaMin : Form
    {
        public FormHorasParaMin()
        {
            InitializeComponent();
        }

        private void btConverterHecAlq_Click(object sender, EventArgs e)
        {
            double valorHoras = 0;
            double valorMin = 0;

            valorHoras = Convert.ToDouble(txtHoras.Text);
            valorMin = valorHoras * 60;

            txtMin.Text = valorMin.ToString("F2");
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtHoras.Clear();
            txtMin.Clear();
            txtHoras.Select();
        }
    }
}
