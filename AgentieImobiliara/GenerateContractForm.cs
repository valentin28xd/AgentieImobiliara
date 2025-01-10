using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class GenerateContractForm : Form
    {
        public GenerateContractForm()
        {
            InitializeComponent();
            LoadOferte();
            LoadClienti();
        }

        private void LoadOferte()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT Oferte.ID_Oferta, Imobile.Adresa + ' - ' + Oferte.Tip_Oferta AS DetaliiOferta
                    FROM Oferte
                    INNER JOIN Imobile ON Oferte.ID_Imobil = Imobile.ID_Imobil
                    WHERE Oferte.ID_Oferta NOT IN (SELECT ID_Oferta FROM Contracte);
                ";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cmbOferte.DisplayMember = "DetaliiOferta";
                        cmbOferte.ValueMember = "ID_Oferta";
                        cmbOferte.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void LoadClienti()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = "SELECT ID_Client, Nume + ' ' + Prenume AS NumeComplet FROM Clienti;";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cmbClienti.DisplayMember = "NumeComplet";
                        cmbClienti.ValueMember = "ID_Client";
                        cmbClienti.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void cmbOferte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOferte.SelectedValue != null)
            {
                LoadOfertaDetails(Convert.ToInt32(cmbOferte.SelectedValue));
            }
        }

        private void LoadOfertaDetails(int idOferta)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT Oferte.Tip_Oferta, Imobile.Tip AS TipImobil, Imobile.Adresa, Imobile.Pret_Solicitat, Angajati.Nume + ' ' + Angajati.Prenume AS Agent
                    FROM Oferte
                    INNER JOIN Imobile ON Oferte.ID_Imobil = Imobile.ID_Imobil
                    INNER JOIN Angajati ON Oferte.ID_Agent = Angajati.ID_Angajat
                    WHERE Oferte.ID_Oferta = @ID_Oferta;
                ";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Oferta", idOferta);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTipOferta.Text = reader["Tip_Oferta"].ToString();
                            txtTipImobil.Text = reader["TipImobil"].ToString();
                            txtAdresa.Text = reader["Adresa"].ToString();
                            txtPretSolicitat.Text = reader["Pret_Solicitat"].ToString();
                            txtAgent.Text = reader["Agent"].ToString();
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnGenereazaContract_Click(object sender, EventArgs e)
        {
            if (cmbOferte.SelectedValue == null || cmbClienti.SelectedValue == null)
            {
                MessageBox.Show("Vă rugăm să selectați o ofertă și un client.");
                return;
            }

            int idOferta = Convert.ToInt32(cmbOferte.SelectedValue);
            int idClientCumparator = Convert.ToInt32(cmbClienti.SelectedValue);

            string tipOferta = txtTipOferta.Text;
            decimal valoareTranzactie = Convert.ToDecimal(txtPretSolicitat.Text);
            decimal comisionFirma = 0;
            decimal comisionAgent = 0;

            if (tipOferta == "Vânzare")
            {
                comisionFirma = 0.10m * valoareTranzactie;
            }
            else if (tipOferta == "Închiriere")
            {
                comisionFirma = valoareTranzactie;
            }

            comisionAgent = 0.25m * comisionFirma;

            int idAgent = 0;
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = "SELECT ID_Agent FROM Oferte WHERE ID_Oferta = @ID_Oferta;";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Oferta", idOferta);
                    idAgent = Convert.ToInt32(command.ExecuteScalar());
                }

                connection.Close();
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO Contracte
                    (ID_Oferta, ID_Client_Cumparator, ID_Agent, Data_Contract, Valoare_Tranzactie, Comision_Firma, Comision_Agent)
                    VALUES
                    (@ID_Oferta, @ID_Client_Cumparator, @ID_Agent, @Data_Contract, @Valoare_Tranzactie, @Comision_Firma, @Comision_Agent);
                ";

                using (var command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID_Oferta", idOferta);
                    command.Parameters.AddWithValue("@ID_Client_Cumparator", idClientCumparator);
                    command.Parameters.AddWithValue("@ID_Agent", idAgent);
                    command.Parameters.AddWithValue("@Data_Contract", DateTime.Now);
                    command.Parameters.AddWithValue("@Valoare_Tranzactie", valoareTranzactie);
                    command.Parameters.AddWithValue("@Comision_Firma", comisionFirma);
                    command.Parameters.AddWithValue("@Comision_Agent", comisionAgent);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Contractul a fost generat cu succes!");

            UpdateOfertaStatus(idOferta);
            this.Close();
        }

        private void UpdateOfertaStatus(int idOferta)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string updateOferta = "UPDATE Oferte SET Status = 'Finalizată' WHERE ID_Oferta = @ID_Oferta;";
                using (var command = new SqlCommand(updateOferta, connection))
                {
                    command.Parameters.AddWithValue("@ID_Oferta", idOferta);
                    command.ExecuteNonQuery();
                }

                string updateImobil = @"
                    UPDATE Imobile
                    SET Status = 'Indisponibil'
                    WHERE ID_Imobil = (SELECT ID_Imobil FROM Oferte WHERE ID_Oferta = @ID_Oferta);
                ";
                using (var command = new SqlCommand(updateImobil, connection))
                {
                    command.Parameters.AddWithValue("@ID_Oferta", idOferta);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}