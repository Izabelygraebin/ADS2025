namespace AppConversao.Formularios
{
    partial class FormKmParaM
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
            this.btNovo = new System.Windows.Forms.Button();
            this.btConverter = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(227, 260);
            this.btNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(112, 35);
            this.btNovo.TabIndex = 14;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btConverter
            // 
            this.btConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter.Location = new System.Drawing.Point(54, 260);
            this.btConverter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(112, 35);
            this.btConverter.TabIndex = 13;
            this.btConverter.Text = "ConverterAlqHec";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.Location = new System.Drawing.Point(54, 425);
            this.txtM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(193, 35);
            this.txtM.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Metros:";
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(54, 129);
            this.txtKm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(193, 35);
            this.txtKm.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Informe o km:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-159, -9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1118, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Converter quilômetros em metros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormKmParaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 538);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKmParaM";
            this.Text = "FormKmParaM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}