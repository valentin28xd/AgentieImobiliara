using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class AddAngajatForm : Form
    {
        public AddAngajatForm()
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
                        INSERT INTO Angajati 
                        (Nume, Prenume, CNP, Adresa, Telefon, Email, Data_Angajare, Salariu_Baza)
                        VALUES
                        (@Nume, @Prenume, @CNP, @Adresa, @Telefon, @Email, @Data_Angajare, @Salariu_Baza);
                    ";

                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nume", txtNume.Text);
                        command.Parameters.AddWithValue("@Prenume", txtPrenume.Text);
                        command.Parameters.AddWithValue("@CNP", txtCNP.Text);
                        command.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
                        command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Data_Angajare", dtpDataAngajare.Value.Date);
                        command.Parameters.AddWithValue("@Salariu_Baza", Convert.ToDecimal(txtSalariuBaza.Text));

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Angajatul a fost adăugat cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea angajatului: " + ex.Message);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}