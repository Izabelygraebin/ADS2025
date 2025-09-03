namespace SimuladorDeMedia.Formularios
{
    partial class FormSimularMedia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.btCalcularMedia = new System.Windows.Forms.Button();
            this.btMedia = new System.Windows.Forms.Button();
            this.txtResultadoMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Simular de Média";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Insira a nota da 1ª Etapa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insira a nota da 2ª Etapa";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(100, 145);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(90, 26);
            this.txtNota1.TabIndex = 11;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(100, 230);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(90, 26);
            this.txtNota2.TabIndex = 12;
            // 
            // btCalcularMedia
            // 
            this.btCalcularMedia.Location = new System.Drawing.Point(358, 133);
            this.btCalcularMedia.Name = "btCalcularMedia";
            this.btCalcularMedia.Size = new System.Drawing.Size(140, 38);
            this.btCalcularMedia.TabIndex = 13;
            this.btCalcularMedia.Text = "Calcular Média";
            this.btCalcularMedia.UseVisualStyleBackColor = true;
            this.btCalcularMedia.Click += new System.EventHandler(this.btCalcularMedia_Click);
            // 
            // btMedia
            // 
            this.btMedia.Location = new System.Drawing.Point(358, 218);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(140, 38);
            this.btMedia.TabIndex = 14;
            this.btMedia.Text = "Limpar";
            this.btMedia.UseVisualStyleBackColor = true;
            this.btMedia.Click += new System.EventHandler(this.btMedia_Click);
            // 
            // txtResultadoMedia
            // 
            this.txtResultadoMedia.Location = new System.Drawing.Point(555, 145);
            this.txtResultadoMedia.Name = "txtResultadoMedia";
            this.txtResultadoMedia.Size = new System.Drawing.Size(90, 26);
            this.txtResultadoMedia.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Resultado";
            // 
            // FormSimularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultadoMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btMedia);
            this.Controls.Add(this.btCalcularMedia);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSimularMedia";
            this.Text = "FormSimularMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Button btCalcularMedia;
        private System.Windows.Forms.Button btMedia;
        private System.Windows.Forms.TextBox txtResultadoMedia;
        private System.Windows.Forms.Label label4;
    }
}