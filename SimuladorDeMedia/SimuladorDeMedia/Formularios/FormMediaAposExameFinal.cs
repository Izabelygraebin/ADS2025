using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeMedia.Formularios
{
    public partial class FormMediaAposExameFinal : Form
    {
        public FormMediaAposExameFinal()
        {
            InitializeComponent();
        }

        private void btAprovacao_Click(object sender, EventArgs e)
        {
            double valorMediaFinal = Convert.ToDouble(txtNotaMediaFinal.Text);
            double NotaExameFinal = Convert.ToDouble(txtNotaExameFinal.Text);

            double mediaAposExameFinal = (valorMediaFinal * 6 + NotaExameFinal * 4) / 10;

            if (mediaAposExameFinal >= 50)
            {
                MessageBox.Show("\nAluno (a) : Izabely Graebin" + "\nMédia Final: " + mediaAposExameFinal.ToString("F2") + "\nSituação: Aprovado (a)", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("\nAluno (a) : Izabely Graebin" + "\nMédia Final: " + mediaAposExameFinal.ToString("F2") + "\nSituação: Reprovado (a)" + "\n\nErrar é humano, não desanime", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btMediaAprovacao_Click(object sender, EventArgs e)
        {
            txtNotaMediaFinal.Clear();
            txtNotaExameFinal.Clear();
            txtNotaMediaFinal.Select();
        }
    }
}
