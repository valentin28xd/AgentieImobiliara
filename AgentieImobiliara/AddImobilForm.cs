using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class AddImobilForm : Form
    {
        public AddImobilForm()
        {
            InitializeComponent();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string insertQuery = @"
                        INSERT INTO Imobile 
                        (Tip, Localitate, Adresa, Etaj, Suprafata, Telefon, Imbunatatiri, Pret_Solicitat, Status)
                        VALUES
                        (@Tip, @Localitate, @Adresa, @Etaj, @Suprafata, @Telefon, @Imbunatatiri, @Pret_Solicitat, @Status);
                    ";

                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Tip", cmbTip.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Localitate", txtLocalitate.Text);
                        command.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
                        command.Parameters.AddWithValue("@Etaj", string.IsNullOrEmpty(txtEtaj.Text) ? (object)DBNull.Value : Convert.ToInt32(txtEtaj.Text));
                        command.Parameters.AddWithValue("@Suprafata", Convert.ToDouble(txtSuprafata.Text));
                        command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        command.Parameters.AddWithValue("@Imbunatatiri", txtImbunatatiri.Text);
                        command.Parameters.AddWithValue("@Pret_Solicitat", Convert.ToDecimal(txtPretSolicitat.Text));
                        command.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Imobilul a fost adăugat cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea imobilului: " + ex.Message);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}