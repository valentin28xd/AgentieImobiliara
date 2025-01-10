namespace AgentieImobiliara
{
    partial class ListImobileForm
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
            this.dataGridViewImobile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImobile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImobile
            // 
            this.dataGridViewImobile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImobile.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewImobile.Name = "dataGridViewImobile";
            this.dataGridViewImobile.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewImobile.TabIndex = 0;
            // 
            // ListImobileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewImobile);
            this.Name = "ListImobileForm";
            this.Text = "ListImobileForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImobile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewImobile;
    }
}