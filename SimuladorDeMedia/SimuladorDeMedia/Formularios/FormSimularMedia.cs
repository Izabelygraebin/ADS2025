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
    public partial class FormSimularMedia : Form
    {
        public FormSimularMedia()
        {
            InitializeComponent();
        }

        private void btCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double media = (nota1 + nota2) / 2;
            txtResultadoMedia.Text = media.ToString("F2");

            if (media <= 60)
            {
                MessageBox.Show("\nAluno (a) : Izabely Graebin" + "\nMédia: " + media.ToString("F2") + "\nSituação : Reprovado (a)"+"\n\nO Aluno deverá realizar o Exame Final", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("\nAluno (a) : Izabely Graebin"+ "\nMédia: " +  media.ToString("F2") + "\nSituação: Aprovado (a)", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtResultadoMedia.Clear();
            txtNota1.Select();

        }
    }
}
