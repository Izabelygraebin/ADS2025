namespace AppConversao
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
            this.btHecParaAlqu = new System.Windows.Forms.Button();
            this.btAlqParaHec = new System.Windows.Forms.Button();
            this.btKmparaM = new System.Windows.Forms.Button();
            this.btMparaKm = new System.Windows.Forms.Button();
            this.btMinParaHoras = new System.Windows.Forms.Button();
            this.btHorasParaMin = new System.Windows.Forms.Button();
            this.btHecParaKm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1118, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btHecParaAlqu
            // 
            this.btHecParaAlqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHecParaAlqu.Location = new System.Drawing.Point(267, 151);
            this.btHecParaAlqu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHecParaAlqu.Name = "btHecParaAlqu";
            this.btHecParaAlqu.Size = new System.Drawing.Size(303, 45);
            this.btHecParaAlqu.TabIndex = 1;
            this.btHecParaAlqu.Text = "Converter Hec para Alq";
            this.btHecParaAlqu.UseVisualStyleBackColor = true;
            this.btHecParaAlqu.Click += new System.EventHandler(this.btHecParaAlqu_Click);
            // 
            // btAlqParaHec
            // 
            this.btAlqParaHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlqParaHec.Location = new System.Drawing.Point(616, 151);
            this.btAlqParaHec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAlqParaHec.Name = "btAlqParaHec";
            this.btAlqParaHec.Size = new System.Drawing.Size(303, 45);
            this.btAlqParaHec.TabIndex = 2;
            this.btAlqParaHec.Text = "Converter Alq para Hec";
            this.btAlqParaHec.UseVisualStyleBackColor = true;
            this.btAlqParaHec.Click += new System.EventHandler(this.btAlqParaHec_Click);
            // 
            // btKmparaM
            // 
            this.btKmparaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKmparaM.Location = new System.Drawing.Point(616, 237);
            this.btKmparaM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btKmparaM.Name = "btKmparaM";
            this.btKmparaM.Size = new System.Drawing.Size(303, 45);
            this.btKmparaM.TabIndex = 4;
            this.btKmparaM.Text = " Converter Km em m";
            this.btKmparaM.UseVisualStyleBackColor = true;
            this.btKmparaM.Click += new System.EventHandler(this.btKmparaM_Click);
            // 
            // btMparaKm
            // 
            this.btMparaKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMparaKm.Location = new System.Drawing.Point(267, 237);
            this.btMparaKm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMparaKm.Name = "btMparaKm";
            this.btMparaKm.Size = new System.Drawing.Size(303, 45);
            this.btMparaKm.TabIndex = 3;
            this.btMparaKm.Text = " Converter m em km";
            this.btMparaKm.UseVisualStyleBackColor = true;
            this.btMparaKm.Click += new System.EventHandler(this.btMparaKm_Click);
            // 
            // btMinParaHoras
            // 
            this.btMinParaHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinParaHoras.Location = new System.Drawing.Point(616, 325);
            this.btMinParaHoras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMinParaHoras.Name = "btMinParaHoras";
            this.btMinParaHoras.Size = new System.Drawing.Size(303, 45);
            this.btMinParaHoras.TabIndex = 6;
            this.btMinParaHoras.Text = "Converter Min em Horas ";
            this.btMinParaHoras.UseVisualStyleBackColor = true;
            this.btMinParaHoras.Click += new System.EventHandler(this.btMinParaHoras_Click);
            // 
            // btHorasParaMin
            // 
            this.btHorasParaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHorasParaMin.Location = new System.Drawing.Point(267, 325);
            this.btHorasParaMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHorasParaMin.Name = "btHorasParaMin";
            this.btHorasParaMin.Size = new System.Drawing.Size(303, 45);
            this.btHorasParaMin.TabIndex = 5;
            this.btHorasParaMin.Text = " Converter Horas em Min";
            this.btHorasParaMin.UseVisualStyleBackColor = true;
            this.btHorasParaMin.Click += new System.EventHandler(this.btHorasParaMin_Click);
            // 
            // btHecParaKm2
            // 
            this.btHecParaKm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHecParaKm2.Location = new System.Drawing.Point(442, 409);
            this.btHecParaKm2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHecParaKm2.Name = "btHecParaKm2";
            this.btHecParaKm2.Size = new System.Drawing.Size(303, 45);
            this.btHecParaKm2.TabIndex = 7;
            this.btHecParaKm2.Text = "Converter Hectares em Km²";
            this.btHecParaKm2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btHecParaKm2);
            this.Controls.Add(this.btMinParaHoras);
            this.Controls.Add(this.btHorasParaMin);
            this.Controls.Add(this.btKmparaM);
            this.Controls.Add(this.btMparaKm);
            this.Controls.Add(this.btAlqParaHec);
            this.Controls.Add(this.btHecParaAlqu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHecParaAlqu;
        private System.Windows.Forms.Button btAlqParaHec;
        private System.Windows.Forms.Button btKmparaM;
        private System.Windows.Forms.Button btMparaKm;
        private System.Windows.Forms.Button btMinParaHoras;
        private System.Windows.Forms.Button btHorasParaMin;
        private System.Windows.Forms.Button btHecParaKm2;
    }
}

