using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
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
                        INSERT INTO Clienti
                        (Nume, Prenume, CNP, Adresa, Telefon, Email, Tip_Client)
                        VALUES
                        (@Nume, @Prenume, @CNP, @Adresa, @Telefon, @Email, @Tip_Client);
                    ";

                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nume", txtNume.Text);
                        command.Parameters.AddWithValue("@Prenume", txtPrenume.Text);
                        command.Parameters.AddWithValue("@CNP", txtCNP.Text);
                        command.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
                        command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Tip_Client", cmbTipClient.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Clientul a fost adăugat cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea clientului: " + ex.Message);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
