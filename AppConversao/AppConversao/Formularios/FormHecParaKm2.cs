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
    public partial class FormHecParaKm2 : Form
    {
        public FormHecParaKm2()
        {
            InitializeComponent();
        }

        private void btConverterHecAlq_Click(object sender, EventArgs e)
        {
            double valorHec22 = 0;
            double valorKm22 = 0;

            valorHec22 = Convert.ToDouble(txtHec22.Text);
            valorKm22 = valorHec22 * 0.01; // 1 hectare = 0.01 km²
            txtkm22.Text = valorKm22.ToString("F2");
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtHec22.Clear();
            txtkm22.Clear();
            txtHec22.Select(); // Seleciona o campo de entrada de hectares para facilitar a nova entrada
        }
    }
}
