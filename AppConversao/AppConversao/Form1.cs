using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConversao.Formularios;

namespace AppConversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btHecParaAlqu_Click(object sender, EventArgs e)
        {
            //chamda do formulario
            FormHecParaAlq form = new FormHecParaAlq();
            form.ShowDialog();
        }

        private void btAlqParaHec_Click(object sender, EventArgs e)
        {
            FormAlqParaHec form = new FormAlqParaHec();
            form.ShowDialog();
        }

        private void btMparaKm_Click(object sender, EventArgs e)
        {
            FormMparaKm form = new FormMparaKm();
            form.ShowDialog();

        }

        private void btKmparaM_Click(object sender, EventArgs e)
        {
            FormKmParaM form = new FormKmParaM();
            form.ShowDialog();

        }

        private void btHorasParaMin_Click(object sender, EventArgs e)
        {
            FormHorasParaMin form = new FormHorasParaMin();
            form.ShowDialog();

        }

        private void btMinParaHoras_Click(object sender, EventArgs e)
        {
            FormMinParaHoras form = new FormMinParaHoras();
            form.ShowDialog();

        }
    }
}
