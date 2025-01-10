namespace AgentieImobiliara
{
    partial class GenerateContractForm
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
            this.cmbOferte = new System.Windows.Forms.ComboBox();
            this.cmbClienti = new System.Windows.Forms.ComboBox();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.txtPretSolicitat = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTipImobil = new System.Windows.Forms.TextBox();
            this.txtTipOferta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenereazaContract = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOferte
            // 
            this.cmbOferte.FormattingEnabled = true;
            this.cmbOferte.Location = new System.Drawing.Point(51, 62);
            this.cmbOferte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOferte.Name = "cmbOferte";
            this.cmbOferte.Size = new System.Drawing.Size(180, 28);
            this.cmbOferte.TabIndex = 0;
            this.cmbOferte.SelectedIndexChanged += new System.EventHandler(this.cmbOferte_SelectedIndexChanged);
            // 
            // cmbClienti
            // 
            this.cmbClienti.FormattingEnabled = true;
            this.cmbClienti.Location = new System.Drawing.Point(51, 144);
            this.cmbClienti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClienti.Name = "cmbClienti";
            this.cmbClienti.Size = new System.Drawing.Size(180, 28);
            this.cmbClienti.TabIndex = 1;
            // 
            // txtAgent
            // 
            this.txtAgent.Location = new System.Drawing.Point(388, 439);
            this.txtAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(148, 26);
            this.txtAgent.TabIndex = 9;
            // 
            // txtPretSolicitat
            // 
            this.txtPretSolicitat.Location = new System.Drawing.Point(388, 349);
            this.txtPretSolicitat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPretSolicitat.Name = "txtPretSolicitat";
            this.txtPretSolicitat.Size = new System.Drawing.Size(148, 26);
            this.txtPretSolicitat.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(388, 245);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(148, 26);
            this.txtAdresa.TabIndex = 7;
            // 
            // txtTipImobil
            // 
            this.txtTipImobil.Location = new System.Drawing.Point(388, 160);
            this.txtTipImobil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipImobil.Name = "txtTipImobil";
            this.txtTipImobil.Size = new System.Drawing.Size(148, 26);
            this.txtTipImobil.TabIndex = 6;
            // 
            // txtTipOferta
            // 
            this.txtTipOferta.Location = new System.Drawing.Point(386, 62);
            this.txtTipOferta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipOferta.Name = "txtTipOferta";
            this.txtTipOferta.Size = new System.Drawing.Size(148, 26);
            this.txtTipOferta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Agent responsabil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preț solicitat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresă";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip imobil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip ofertă";
            // 
            // btnGenereazaContract
            // 
            this.btnGenereazaContract.Location = new System.Drawing.Point(53, 667);
            this.btnGenereazaContract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenereazaContract.Name = "btnGenereazaContract";
            this.btnGenereazaContract.Size = new System.Drawing.Size(202, 35);
            this.btnGenereazaContract.TabIndex = 3;
            this.btnGenereazaContract.Text = "Generează Contract";
            this.btnGenereazaContract.UseVisualStyleBackColor = true;
            this.btnGenereazaContract.Click += new System.EventHandler(this.btnGenereazaContract_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(335, 667);
            this.btnAnuleaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(208, 35);
            this.btnAnuleaza.TabIndex = 4;
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oferte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Clienti";
            // 
            // GenerateContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 766);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPretSolicitat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.txtTipImobil);
            this.Controls.Add(this.btnGenereazaContract);
            this.Controls.Add(this.txtTipOferta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClienti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOferte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GenerateContractForm";
            this.Text = "GenerateContractForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOferte;
        private System.Windows.Forms.ComboBox cmbClienti;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.TextBox txtPretSolicitat;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTipImobil;
        private System.Windows.Forms.TextBox txtTipOferta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenereazaContract;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}