namespace AppConversao.Formularios
{
    partial class FormMparaKm
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
            this.txtKm1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM1 = new System.Windows.Forms.TextBox();
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
            this.btNovo.TabIndex = 21;
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
            this.btConverter.TabIndex = 20;
            this.btConverter.Text = "ConverterAlqHec";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // txtKm1
            // 
            this.txtKm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm1.Location = new System.Drawing.Point(54, 425);
            this.txtKm1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKm1.Name = "txtKm1";
            this.txtKm1.Size = new System.Drawing.Size(193, 35);
            this.txtKm1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Km:";
            // 
            // txtM1
            // 
            this.txtM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM1.Location = new System.Drawing.Point(54, 129);
            this.txtM1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(193, 35);
            this.txtM1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Informe o metro:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-159, -9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1118, 58);
            this.label1.TabIndex = 15;
            this.label1.Text = "Converter metros em quilômetros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMparaKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 497);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.txtKm1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtM1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMparaKm";
            this.Text = "FormMparaKm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.TextBox txtKm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}