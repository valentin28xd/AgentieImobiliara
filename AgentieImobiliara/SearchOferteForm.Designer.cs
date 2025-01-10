namespace AgentieImobiliara
{
    partial class SearchOferteForm
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
            this.txtNumarCamere = new System.Windows.Forms.TextBox();
            this.txtLocalitate = new System.Windows.Forms.TextBox();
            this.txtPretMinim = new System.Windows.Forms.TextBox();
            this.txtPretMaxim = new System.Windows.Forms.TextBox();
            this.cmbTipOferta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumarCamere
            // 
            this.txtNumarCamere.Location = new System.Drawing.Point(60, 58);
            this.txtNumarCamere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumarCamere.Name = "txtNumarCamere";
            this.txtNumarCamere.Size = new System.Drawing.Size(148, 26);
            this.txtNumarCamere.TabIndex = 0;
            // 
            // txtLocalitate
            // 
            this.txtLocalitate.Location = new System.Drawing.Point(60, 137);
            this.txtLocalitate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocalitate.Name = "txtLocalitate";
            this.txtLocalitate.Size = new System.Drawing.Size(148, 26);
            this.txtLocalitate.TabIndex = 1;
            // 
            // txtPretMinim
            // 
            this.txtPretMinim.Location = new System.Drawing.Point(60, 223);
            this.txtPretMinim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPretMinim.Name = "txtPretMinim";
            this.txtPretMinim.Size = new System.Drawing.Size(148, 26);
            this.txtPretMinim.TabIndex = 2;
            // 
            // txtPretMaxim
            // 
            this.txtPretMaxim.Location = new System.Drawing.Point(60, 309);
            this.txtPretMaxim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPretMaxim.Name = "txtPretMaxim";
            this.txtPretMaxim.Size = new System.Drawing.Size(148, 26);
            this.txtPretMaxim.TabIndex = 3;
            // 
            // cmbTipOferta
            // 
            this.cmbTipOferta.FormattingEnabled = true;
            this.cmbTipOferta.Items.AddRange(new object[] {
            "Vânzare",
            "Închiriere"});
            this.cmbTipOferta.Location = new System.Drawing.Point(60, 414);
            this.cmbTipOferta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipOferta.Name = "cmbTipOferta";
            this.cmbTipOferta.Size = new System.Drawing.Size(180, 28);
            this.cmbTipOferta.TabIndex = 5;
            this.cmbTipOferta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 585);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Caută";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(840, 369);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Număr camere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Localitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pret minim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pret maxim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tip ofertă";
            // 
            // SearchOferteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTipOferta);
            this.Controls.Add(this.txtPretMaxim);
            this.Controls.Add(this.txtPretMinim);
            this.Controls.Add(this.txtLocalitate);
            this.Controls.Add(this.txtNumarCamere);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchOferteForm";
            this.Text = "SearchOferteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumarCamere;
        private System.Windows.Forms.TextBox txtLocalitate;
        private System.Windows.Forms.TextBox txtPretMinim;
        private System.Windows.Forms.TextBox txtPretMaxim;
        private System.Windows.Forms.ComboBox cmbTipOferta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}