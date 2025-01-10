using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class CalculateSalariiForm : Form
    {
        public CalculateSalariiForm()
        {
            InitializeComponent();
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            int luna = cmbLuna.SelectedIndex + 1;
            int an;
            if (!int.TryParse(txtAn.Text, out an))
            {
                MessageBox.Show("Introduceți un an valid.");
                return;
            }

            CalculSalarii(luna, an);
            LoadSalarii(luna, an);
        }

        private void CalculSalarii(int luna, int an)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Salarii WHERE Luna = @Luna AND Anul = @Anul;";
                using (var command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Luna", luna);
                    command.Parameters.AddWithValue("@Anul", an);
                    command.ExecuteNonQuery();
                }

                string agentiQuery = "SELECT * FROM Angajati;";
                using (var command = new SqlCommand(agentiQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idAngajat = Convert.ToInt32(reader["ID_Angajat"]);
                            decimal salariuBaza = Convert.ToDecimal(reader["Salariu_Baza"]);

                            decimal totalComisioane = 0;
                            int numarContracte = 0;

                            string comisioaneQuery = @"
                                SELECT SUM(Comision_Agent) AS TotalComisioane, COUNT(*) AS NumarContracte
                                FROM Contracte
                                WHERE ID_Agent = @ID_Agent AND MONTH(Data_Contract) = @Luna AND YEAR(Data_Contract) = @Anul;
                            ";
                            using (var comisioaneCommand = new SqlCommand(comisioaneQuery, connection))
                            {
                                comisioaneCommand.Parameters.AddWithValue("@ID_Agent", idAngajat);
                                comisioaneCommand.Parameters.AddWithValue("@Luna", luna);
                                comisioaneCommand.Parameters.AddWithValue("@Anul", an);

                                using (SqlDataReader comisioaneReader = comisioaneCommand.ExecuteReader())
                                {
                                    if (comisioaneReader.Read())
                                    {
                                        totalComisioane = comisioaneReader["TotalComisioane"] != DBNull.Value ? Convert.ToDecimal(comisioaneReader["TotalComisioane"]) : 0;
                                        numarContracte = comisioaneReader["NumarContracte"] != DBNull.Value ? Convert.ToInt32(comisioaneReader["NumarContracte"]) : 0;
                                    }
                                }
                            }

                            decimal prima = 0;
                            if (numarContracte > 5)
                            {
                                prima = 500;
                            }

                            decimal totalPlata = salariuBaza + totalComisioane + prima;

                            string insertSalariu = @"
                                INSERT INTO Salarii
                                (ID_Angajat, Luna, Anul, Salariu_Baza, Comisioane, Prime, Total_Plata)
                                VALUES
                                (@ID_Angajat, @Luna, @Anul, @Salariu_Baza, @Comisioane, @Prime, @Total_Plata);
                            ";
                            using (var insertCommand = new SqlCommand(insertSalariu, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@ID_Angajat", idAngajat);
                                insertCommand.Parameters.AddWithValue("@Luna", luna);
                                insertCommand.Parameters.AddWithValue("@Anul", an);
                                insertCommand.Parameters.AddWithValue("@Salariu_Baza", salariuBaza);
                                insertCommand.Parameters.AddWithValue("@Comisioane", totalComisioane);
                                insertCommand.Parameters.AddWithValue("@Prime", prima);
                                insertCommand.Parameters.AddWithValue("@Total_Plata", totalPlata);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        private void LoadSalarii(int luna, int an)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        Salarii.ID_Plata,
                        Angajati.Nume + ' ' + Angajati.Prenume AS NumeAgent,
                        Salarii.Salariu_Baza,
                        Salarii.Comisioane,
                        Salarii.Prime,
                        Salarii.Total_Plata
                    FROM Salarii
                    INNER JOIN Angajati ON Salarii.ID_Angajat = Angajati.ID_Angajat
                    WHERE Salarii.Luna = @Luna AND Salarii.Anul = @Anul;
                ";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Luna", luna);
                    command.Parameters.AddWithValue("@Anul", an);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewSalarii.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }
    }
}