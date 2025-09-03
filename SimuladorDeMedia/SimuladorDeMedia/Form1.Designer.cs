namespace SimuladorDeMedia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btMediaAposExameFinal = new System.Windows.Forms.Button();
            this.btNotaMinimaExame = new System.Windows.Forms.Button();
            this.btMediaNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "Simulador de Média";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMediaAposExameFinal
            // 
            this.btMediaAposExameFinal.Location = new System.Drawing.Point(206, 328);
            this.btMediaAposExameFinal.Name = "btMediaAposExameFinal";
            this.btMediaAposExameFinal.Size = new System.Drawing.Size(393, 47);
            this.btMediaAposExameFinal.TabIndex = 6;
            this.btMediaAposExameFinal.Text = "Verificar a média final após a nota do Exame Final";
            this.btMediaAposExameFinal.UseVisualStyleBackColor = true;
            this.btMediaAposExameFinal.Click += new System.EventHandler(this.btMediaAposExameFinal_Click);
            // 
            // btNotaMinimaExame
            // 
            this.btNotaMinimaExame.Location = new System.Drawing.Point(206, 254);
            this.btNotaMinimaExame.Name = "btNotaMinimaExame";
            this.btNotaMinimaExame.Size = new System.Drawing.Size(393, 47);
            this.btNotaMinimaExame.TabIndex = 5;
            this.btNotaMinimaExame.Text = "Nota mínima para ser no Exame";
            this.btNotaMinimaExame.UseVisualStyleBackColor = true;
            this.btNotaMinimaExame.Click += new System.EventHandler(this.btNotaMinimaExame_Click);
            // 
            // btMediaNota
            // 
            this.btMediaNota.Location = new System.Drawing.Point(206, 179);
            this.btMediaNota.Name = "btMediaNota";
            this.btMediaNota.Size = new System.Drawing.Size(393, 47);
            this.btMediaNota.TabIndex = 4;
            this.btMediaNota.Text = "Simular média";
            this.btMediaNota.UseVisualStyleBackColor = true;
            this.btMediaNota.Click += new System.EventHandler(this.btMediaNota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMediaAposExameFinal);
            this.Controls.Add(this.btNotaMinimaExame);
            this.Controls.Add(this.btMediaNota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMediaAposExameFinal;
        private System.Windows.Forms.Button btNotaMinimaExame;
        private System.Windows.Forms.Button btMediaNota;
    }
}

