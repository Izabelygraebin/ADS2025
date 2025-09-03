namespace AppConversao.Formularios
{
    partial class FormAlqParaHec
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
            this.txtAlq = new System.Windows.Forms.TextBox();
            this.txtHec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btConverter = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Converter Alqueire para Hectare";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe o Alqueire";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAlq
            // 
            this.txtAlq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlq.Location = new System.Drawing.Point(154, 99);
            this.txtAlq.Name = "txtAlq";
            this.txtAlq.Size = new System.Drawing.Size(130, 26);
            this.txtAlq.TabIndex = 3;
            this.txtAlq.TextChanged += new System.EventHandler(this.txtAlq_TextChanged);
            // 
            // txtHec
            // 
            this.txtHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHec.Location = new System.Drawing.Point(154, 291);
            this.txtHec.Name = "txtHec";
            this.txtHec.Size = new System.Drawing.Size(130, 26);
            this.txtHec.TabIndex = 5;
            this.txtHec.TextChanged += new System.EventHandler(this.txtHec_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hectare:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btConverter
            // 
            this.btConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter.Location = new System.Drawing.Point(154, 184);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(75, 23);
            this.btConverter.TabIndex = 6;
            this.btConverter.Text = "ConverterAlqHec";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(269, 184);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 7;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormAlqParaHec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.txtHec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlqParaHec";
            this.Text = "FormAlqParaHec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlq;
        private System.Windows.Forms.TextBox txtHec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.Button btNovo;
    }
}