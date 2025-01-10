namespace AgentieImobiliara
{
    partial class PrintFluturasForm
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
            this.cmbAngajati = new System.Windows.Forms.ComboBox();
            this.cmbLuna = new System.Windows.Forms.ComboBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtDetaliiSalariu = new System.Windows.Forms.TextBox();
            this.btnImprima = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAngajati
            // 
            this.cmbAngajati.FormattingEnabled = true;
            this.cmbAngajati.Location = new System.Drawing.Point(56, 60);
            this.cmbAngajati.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAngajati.Name = "cmbAngajati";
            this.cmbAngajati.Size = new System.Drawing.Size(180, 28);
            this.cmbAngajati.TabIndex = 0;
            // 
            // cmbLuna
            // 
            this.cmbLuna.FormattingEnabled = true;
            this.cmbLuna.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbLuna.Location = new System.Drawing.Point(56, 146);
            this.cmbLuna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLuna.Name = "cmbLuna";
            this.cmbLuna.Size = new System.Drawing.Size(180, 28);
            this.cmbLuna.TabIndex = 1;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(56, 232);
            this.txtAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(180, 26);
            this.txtAn.TabIndex = 2;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(56, 355);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(112, 35);
            this.btnAfiseaza.TabIndex = 3;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtDetaliiSalariu
            // 
            this.txtDetaliiSalariu.Location = new System.Drawing.Point(56, 468);
            this.txtDetaliiSalariu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetaliiSalariu.Multiline = true;
            this.txtDetaliiSalariu.Name = "txtDetaliiSalariu";
            this.txtDetaliiSalariu.ReadOnly = true;
            this.txtDetaliiSalariu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetaliiSalariu.Size = new System.Drawing.Size(180, 29);
            this.txtDetaliiSalariu.TabIndex = 4;
            // 
            // btnImprima
            // 
            this.btnImprima.Location = new System.Drawing.Point(56, 558);
            this.btnImprima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprima.Name = "btnImprima";
            this.btnImprima.Size = new System.Drawing.Size(112, 35);
            this.btnImprima.TabIndex = 5;
            this.btnImprima.Text = "Imprima";
            this.btnImprima.UseVisualStyleBackColor = true;
            this.btnImprima.Click += new System.EventHandler(this.btnImprima_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Angajati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Luna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "An";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Detalii salariu";
            // 
            // PrintFluturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprima);
            this.Controls.Add(this.txtDetaliiSalariu);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.cmbLuna);
            this.Controls.Add(this.cmbAngajati);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintFluturasForm";
            this.Text = "PrintFluturasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAngajati;
        private System.Windows.Forms.ComboBox cmbLuna;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtDetaliiSalariu;
        private System.Windows.Forms.Button btnImprima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}