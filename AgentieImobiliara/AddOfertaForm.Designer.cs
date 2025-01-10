namespace AgentieImobiliara
{
    partial class AddOfertaForm
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
            this.cmbImobile = new System.Windows.Forms.ComboBox();
            this.cmbClienti = new System.Windows.Forms.ComboBox();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.cmbTipOferta = new System.Windows.Forms.ComboBox();
            this.dtpDataAdaugare = new System.Windows.Forms.DateTimePicker();
            this.txtTarifLuna = new System.Windows.Forms.TextBox();
            this.txtNumarLuniMinim = new System.Windows.Forms.TextBox();
            this.txtNumarLuniMaxim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTarifLuna = new System.Windows.Forms.Label();
            this.lblNumarLuniMinim = new System.Windows.Forms.Label();
            this.lblNumarLuniMaxim = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbImobile
            // 
            this.cmbImobile.FormattingEnabled = true;
            this.cmbImobile.Location = new System.Drawing.Point(38, 62);
            this.cmbImobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbImobile.Name = "cmbImobile";
            this.cmbImobile.Size = new System.Drawing.Size(180, 28);
            this.cmbImobile.TabIndex = 0;
            // 
            // cmbClienti
            // 
            this.cmbClienti.FormattingEnabled = true;
            this.cmbClienti.Items.AddRange(new object[] {
            "Vânzător",
            "Cumpărător"});
            this.cmbClienti.Location = new System.Drawing.Point(38, 136);
            this.cmbClienti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClienti.Name = "cmbClienti";
            this.cmbClienti.Size = new System.Drawing.Size(180, 28);
            this.cmbClienti.TabIndex = 1;
            // 
            // cmbAgent
            // 
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(38, 211);
            this.cmbAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(180, 28);
            this.cmbAgent.TabIndex = 2;
            // 
            // cmbTipOferta
            // 
            this.cmbTipOferta.FormattingEnabled = true;
            this.cmbTipOferta.Items.AddRange(new object[] {
            "Vânzare",
            "Închiriere"});
            this.cmbTipOferta.Location = new System.Drawing.Point(38, 286);
            this.cmbTipOferta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipOferta.Name = "cmbTipOferta";
            this.cmbTipOferta.Size = new System.Drawing.Size(180, 28);
            this.cmbTipOferta.TabIndex = 3;
            // 
            // dtpDataAdaugare
            // 
            this.dtpDataAdaugare.Location = new System.Drawing.Point(38, 378);
            this.dtpDataAdaugare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataAdaugare.Name = "dtpDataAdaugare";
            this.dtpDataAdaugare.Size = new System.Drawing.Size(298, 26);
            this.dtpDataAdaugare.TabIndex = 4;
            // 
            // txtTarifLuna
            // 
            this.txtTarifLuna.Location = new System.Drawing.Point(38, 465);
            this.txtTarifLuna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTarifLuna.Name = "txtTarifLuna";
            this.txtTarifLuna.Size = new System.Drawing.Size(148, 26);
            this.txtTarifLuna.TabIndex = 5;
            // 
            // txtNumarLuniMinim
            // 
            this.txtNumarLuniMinim.Location = new System.Drawing.Point(38, 542);
            this.txtNumarLuniMinim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumarLuniMinim.Name = "txtNumarLuniMinim";
            this.txtNumarLuniMinim.Size = new System.Drawing.Size(148, 26);
            this.txtNumarLuniMinim.TabIndex = 6;
            // 
            // txtNumarLuniMaxim
            // 
            this.txtNumarLuniMaxim.Location = new System.Drawing.Point(38, 627);
            this.txtNumarLuniMaxim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumarLuniMaxim.Name = "txtNumarLuniMaxim";
            this.txtNumarLuniMaxim.Size = new System.Drawing.Size(148, 26);
            this.txtNumarLuniMaxim.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imobil ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Client ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Agent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tip Ofertă";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Adăugare";
            // 
            // lblTarifLuna
            // 
            this.lblTarifLuna.AutoSize = true;
            this.lblTarifLuna.Location = new System.Drawing.Point(37, 440);
            this.lblTarifLuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarifLuna.Name = "lblTarifLuna";
            this.lblTarifLuna.Size = new System.Drawing.Size(80, 20);
            this.lblTarifLuna.TabIndex = 13;
            this.lblTarifLuna.Text = "Tarif Lună";
            // 
            // lblNumarLuniMinim
            // 
            this.lblNumarLuniMinim.AutoSize = true;
            this.lblNumarLuniMinim.Location = new System.Drawing.Point(34, 517);
            this.lblNumarLuniMinim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumarLuniMinim.Name = "lblNumarLuniMinim";
            this.lblNumarLuniMinim.Size = new System.Drawing.Size(135, 20);
            this.lblNumarLuniMinim.TabIndex = 14;
            this.lblNumarLuniMinim.Text = "Număr Luni Minim";
            // 
            // lblNumarLuniMaxim
            // 
            this.lblNumarLuniMaxim.AutoSize = true;
            this.lblNumarLuniMaxim.Location = new System.Drawing.Point(37, 602);
            this.lblNumarLuniMaxim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumarLuniMaxim.Name = "lblNumarLuniMaxim";
            this.lblNumarLuniMaxim.Size = new System.Drawing.Size(139, 20);
            this.lblNumarLuniMaxim.TabIndex = 15;
            this.lblNumarLuniMaxim.Text = "Număr Luni Maxim";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(70, 757);
            this.btnAnuleaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(112, 35);
            this.btnAnuleaza.TabIndex = 27;
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(518, 757);
            this.btnSalveaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(112, 35);
            this.btnSalveaza.TabIndex = 26;
            this.btnSalveaza.Text = "Salvează ";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // AddOfertaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 811);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lblNumarLuniMaxim);
            this.Controls.Add(this.lblNumarLuniMinim);
            this.Controls.Add(this.lblTarifLuna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumarLuniMaxim);
            this.Controls.Add(this.txtNumarLuniMinim);
            this.Controls.Add(this.txtTarifLuna);
            this.Controls.Add(this.dtpDataAdaugare);
            this.Controls.Add(this.cmbTipOferta);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.cmbClienti);
            this.Controls.Add(this.cmbImobile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddOfertaForm";
            this.Text = "AddOfertaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbImobile;
        private System.Windows.Forms.ComboBox cmbClienti;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.ComboBox cmbTipOferta;
        private System.Windows.Forms.DateTimePicker dtpDataAdaugare;
        private System.Windows.Forms.TextBox txtTarifLuna;
        private System.Windows.Forms.TextBox txtNumarLuniMinim;
        private System.Windows.Forms.TextBox txtNumarLuniMaxim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTarifLuna;
        private System.Windows.Forms.Label lblNumarLuniMinim;
        private System.Windows.Forms.Label lblNumarLuniMaxim;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnSalveaza;
    }
}