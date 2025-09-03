using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorDeMedia.Formularios;

namespace SimuladorDeMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btMediaNota_Click(object sender, EventArgs e)
        {
            FormSimularMedia form = new FormSimularMedia();
            form.ShowDialog();
        }

        private void btNotaMinimaExame_Click(object sender, EventArgs e)
        {
            FormNotaMinimaExame form = new FormNotaMinimaExame();
            form.ShowDialog();
        }

        private void btMediaAposExameFinal_Click(object sender, EventArgs e)
        {
            FormMediaAposExameFinal form = new FormMediaAposExameFinal();
            form.ShowDialog();
        }
    }
}
