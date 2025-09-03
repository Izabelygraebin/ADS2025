namespace AppConversao.Formularios
{
    partial class FormHecParaKm2
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
            this.txtkm22 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHec22 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(313, 292);
            this.btNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(112, 35);
            this.btNovo.TabIndex = 28;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btConverterHecAlq
            // 
            this.btConverterHecAlq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverterHecAlq.Location = new System.Drawing.Point(140, 292);
            this.btConverterHecAlq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConverterHecAlq.Name = "btConverterHecAlq";
            this.btConverterHecAlq.Size = new System.Drawing.Size(112, 35);
            this.btConverterHecAlq.TabIndex = 27;
            this.btConverterHecAlq.Text = "ConverterHecAlq";
            this.btConverterHecAlq.UseVisualStyleBackColor = true;
            this.btConverterHecAlq.Click += new System.EventHandler(this.btConverterHecAlq_Click);
            // 
            // txtkm22
            // 
            this.txtkm22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkm22.Location = new System.Drawing.Point(140, 457);
            this.txtkm22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkm22.Name = "txtkm22";
            this.txtkm22.Size = new System.Drawing.Size(193, 35);
            this.txtkm22.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Km²:";
            // 
            // txtHec22
            // 
            this.txtHec22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHec22.Location = new System.Drawing.Point(140, 162);
            this.txtHec22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHec22.Name = "txtHec22";
            this.txtHec22.Size = new System.Drawing.Size(193, 35);
            this.txtHec22.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Informe o Hectare:";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-73, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1118, 58);
            this.label1.TabIndex = 22;
            this.label1.Text = "Converter Hectares para Km²";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHecParaKm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 563);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverterHecAlq);
            this.Controls.Add(this.txtkm22);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHec22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHecParaKm2";
            this.Text = "FormHecParaKm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btConverterHecAlq;
        private System.Windows.Forms.TextBox txtkm22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHec22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}