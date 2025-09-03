namespace AppConversao.Formularios
{
    partial class FormHecParaAlq
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
            this.btConverterHecAlq = new System.Windows.Forms.Button();
            this.txtAlq2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHec2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(285, 246);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 14;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btConverterHecAlq
            // 
            this.btConverterHecAlq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverterHecAlq.Location = new System.Drawing.Point(170, 246);
            this.btConverterHecAlq.Name = "btConverterHecAlq";
            this.btConverterHecAlq.Size = new System.Drawing.Size(75, 23);
            this.btConverterHecAlq.TabIndex = 13;
            this.btConverterHecAlq.Text = "ConverterHecAlq";
            this.btConverterHecAlq.UseVisualStyleBackColor = true;
            this.btConverterHecAlq.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // txtAlq2
            // 
            this.txtAlq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlq2.Location = new System.Drawing.Point(170, 353);
            this.txtAlq2.Name = "txtAlq2";
            this.txtAlq2.Size = new System.Drawing.Size(130, 26);
            this.txtAlq2.TabIndex = 12;
            this.txtAlq2.TextChanged += new System.EventHandler(this.txtHec_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alqueire:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHec2
            // 
            this.txtHec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHec2.Location = new System.Drawing.Point(170, 161);
            this.txtHec2.Name = "txtHec2";
            this.txtHec2.Size = new System.Drawing.Size(130, 26);
            this.txtHec2.TabIndex = 10;
            this.txtHec2.TextChanged += new System.EventHandler(this.txtAlq_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Informe o Hectare";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Converter Hectare para Alqueire";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormHecParaAlq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverterHecAlq);
            this.Controls.Add(this.txtAlq2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHec2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHecParaAlq";
            this.Text = "FormHecParaAlq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btConverterHecAlq;
        private System.Windows.Forms.TextBox txtAlq2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHec2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}