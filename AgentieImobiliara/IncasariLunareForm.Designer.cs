namespace AgentieImobiliara
{
    partial class IncasariLunareForm
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
            this.cmbLuna = new System.Windows.Forms.ComboBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.lblTotalIncasari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmbLuna.Location = new System.Drawing.Point(66, 130);
            this.cmbLuna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLuna.Name = "cmbLuna";
            this.cmbLuna.Size = new System.Drawing.Size(180, 28);
            this.cmbLuna.TabIndex = 0;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(66, 206);
            this.txtAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(180, 26);
            this.txtAn.TabIndex = 1;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(127, 370);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(150, 35);
            this.btnAfiseaza.TabIndex = 2;
            this.btnAfiseaza.Text = "Afișează Încasări";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // lblTotalIncasari
            // 
            this.lblTotalIncasari.AutoSize = true;
            this.lblTotalIncasari.Location = new System.Drawing.Point(62, 52);
            this.lblTotalIncasari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIncasari.Name = "lblTotalIncasari";
            this.lblTotalIncasari.Size = new System.Drawing.Size(108, 20);
            this.lblTotalIncasari.TabIndex = 3;
            this.lblTotalIncasari.Text = "Total Încasări:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Luna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "An";
            // 
            // IncasariLunareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalIncasari);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.cmbLuna);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IncasariLunareForm";
            this.Text = "IncasariLunareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLuna;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Label lblTotalIncasari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}