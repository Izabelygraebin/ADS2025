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
    public partial class FormNotaMinimaExame : Form
    {
        public FormNotaMinimaExame()
        {
            InitializeComponent();
        }

        private void btCalcularMediaFinal_Click(object sender, EventArgs e)
        {
            double valorMediaFinal = Convert.ToDouble(txtMediaFinal.Text);
            if (valorMediaFinal >= 60)
            {
                MessageBox.Show("\nAluno (a) : Izabely Graebin" + "\nMédia Final: " + valorMediaFinal.ToString("F2") + "\nO aluno já está aprovado. Não precisa fazer exame.)", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMediaFinal.Clear();
                txtResultadoMediaFinal.Clear();
                txtMediaFinal.Select();
            }
            else
            {
                double aprovacaoExameFinal = (500 - valorMediaFinal * 6) / 4;

                txtResultadoMediaFinal.Text = aprovacaoExameFinal.ToString("F2");

                MessageBox.Show("\nAluno (a) : Izabely Graebin" + "\nMédia Final: " + valorMediaFinal.ToString("F2") + "\nNota Mínima para ser Aprovado (a) no Exame Final: " + aprovacaoExameFinal.ToString("F2") + "\n\n Bons Estudos ;)", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                
        }

        private void btMediaFinal_Click(object sender, EventArgs e)
        {
            txtMediaFinal.Clear();
            txtResultadoMediaFinal.Clear();
            txtMediaFinal.Select();
        }
    }
}
