namespace SimuladorDeMedia.Formularios
{
    partial class FormMediaAposExameFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultadoAprovacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btMediaAprovacao = new System.Windows.Forms.Button();
            this.btAprovacao = new System.Windows.Forms.Button();
            this.txtNotaExameFinal = new System.Windows.Forms.TextBox();
            this.txtNotaMediaFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultadoAprovacao
            // 
            this.txtResultadoAprovacao.Location = new System.Drawing.Point(552, 146);
            this.txtResultadoAprovacao.Name = "txtResultadoAprovacao";
            this.txtResultadoAprovacao.Size = new System.Drawing.Size(90, 26);
            this.txtResultadoAprovacao.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Resultado";
            // 
            // btMediaAprovacao
            // 
            this.btMediaAprovacao.Location = new System.Drawing.Point(355, 219);
            this.btMediaAprovacao.Name = "btMediaAprovacao";
            this.btMediaAprovacao.Size = new System.Drawing.Size(140, 38);
            this.btMediaAprovacao.TabIndex = 23;
            this.btMediaAprovacao.Text = "Limpar";
            this.btMediaAprovacao.UseVisualStyleBackColor = true;
            this.btMediaAprovacao.Click += new System.EventHandler(this.btMediaAprovacao_Click);
            // 
            // btAprovacao
            // 
            this.btAprovacao.Location = new System.Drawing.Point(355, 134);
            this.btAprovacao.Name = "btAprovacao";
            this.btAprovacao.Size = new System.Drawing.Size(140, 38);
            this.btAprovacao.TabIndex = 22;
            this.btAprovacao.Text = "Calcular Média";
            this.btAprovacao.UseVisualStyleBackColor = true;
            this.btAprovacao.Click += new System.EventHandler(this.btAprovacao_Click);
            // 
            // txtNotaExameFinal
            // 
            this.txtNotaExameFinal.Location = new System.Drawing.Point(97, 231);
            this.txtNotaExameFinal.Name = "txtNotaExameFinal";
            this.txtNotaExameFinal.Size = new System.Drawing.Size(90, 26);
            this.txtNotaExameFinal.TabIndex = 21;
            // 
            // txtNotaMediaFinal
            // 
            this.txtNotaMediaFinal.Location = new System.Drawing.Point(97, 146);
            this.txtNotaMediaFinal.Name = "txtNotaMediaFinal";
            this.txtNotaMediaFinal.Size = new System.Drawing.Size(90, 26);
            this.txtNotaMediaFinal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nota do Exame Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nota da Média Final";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "Verificar a média final após a nota do Exame Final";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMediaAposExameFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultadoAprovacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btMediaAprovacao);
            this.Controls.Add(this.btAprovacao);
            this.Controls.Add(this.txtNotaExameFinal);
            this.Controls.Add(this.txtNotaMediaFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMediaAposExameFinal";
            this.Text = "FormMediaAposExameFinal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultadoAprovacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btMediaAprovacao;
        private System.Windows.Forms.Button btAprovacao;
        private System.Windows.Forms.TextBox txtNotaExameFinal;
        private System.Windows.Forms.TextBox txtNotaMediaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}