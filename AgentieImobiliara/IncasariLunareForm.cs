using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class IncasariLunareForm : Form
    {
        public IncasariLunareForm()
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                cmbLuna.Items.Add(i.ToString("D2"));
            }
            cmbLuna.SelectedIndex = DateTime.Now.Month - 1;
            txtAn.Text = DateTime.Now.Year.ToString();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            int luna;
            int an;

            if (cmbLuna.SelectedItem == null || !int.TryParse(cmbLuna.SelectedItem.ToString(), out luna))
            {
                MessageBox.Show("Vă rugăm să selectați o lună validă.");
                return;
            }

            if (!int.TryParse(txtAn.Text, out an))
            {
                MessageBox.Show("Vă rugăm să introduceți un an valid.");
                return;
            }

            AfiseazaIncasari(luna, an);
        }

        private void AfiseazaIncasari(int luna, int an)
        {
            decimal totalIncasari = 0;

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT SUM(Valoare_Tranzactie) AS TotalIncasari
                    FROM Contracte
                    WHERE MONTH(Data_Contract) = @Luna AND YEAR(Data_Contract) = @An;
                ";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Luna", luna);
                    command.Parameters.AddWithValue("@An", an);

                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalIncasari = Convert.ToDecimal(result);
                    }
                }

                connection.Close();
            }

            lblTotalIncasari.Text = $"Total încasări pentru {luna:D2}/{an}: {totalIncasari} lei";
        }
    }
}