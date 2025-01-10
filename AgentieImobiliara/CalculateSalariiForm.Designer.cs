namespace AgentieImobiliara
{
    partial class CalculateSalariiForm
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
            this.dataGridViewSalarii = new System.Windows.Forms.DataGridView();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalarii)).BeginInit();
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
            this.cmbLuna.Location = new System.Drawing.Point(60, 74);
            this.cmbLuna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLuna.Name = "cmbLuna";
            this.cmbLuna.Size = new System.Drawing.Size(180, 28);
            this.cmbLuna.TabIndex = 0;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(60, 163);
            this.txtAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(148, 26);
            this.txtAn.TabIndex = 1;
            // 
            // dataGridViewSalarii
            // 
            this.dataGridViewSalarii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalarii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSalarii.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSalarii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSalarii.Name = "dataGridViewSalarii";
            this.dataGridViewSalarii.RowHeadersWidth = 62;
            this.dataGridViewSalarii.Size = new System.Drawing.Size(1200, 692);
            this.dataGridViewSalarii.TabIndex = 2;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(60, 228);
            this.btnCalculeaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(112, 27);
            this.btnCalculeaza.TabIndex = 3;
            this.btnCalculeaza.Text = "Calculează Salarii";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Luna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anul";
            // 
            // CalculateSalariiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.cmbLuna);
            this.Controls.Add(this.dataGridViewSalarii);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculateSalariiForm";
            this.Text = "CalculateSalariiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalarii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLuna;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.DataGridView dataGridViewSalarii;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}