using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class PrintFluturasForm : Form
    {
        public PrintFluturasForm()
        {
            InitializeComponent();
            LoadAngajati();
        }

        private void LoadAngajati()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = "SELECT ID_Angajat, Nume + ' ' + Prenume AS NumeComplet FROM Angajati;";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cmbAngajati.DisplayMember = "NumeComplet";
                        cmbAngajati.ValueMember = "ID_Angajat";
                        cmbAngajati.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            if (cmbAngajati.SelectedValue == null)
            {
                MessageBox.Show("Selectați un angajat.");
                return;
            }

            int idAngajat = Convert.ToInt32(cmbAngajati.SelectedValue);
            int luna = cmbLuna.SelectedIndex + 1;
            int an;
            if (!int.TryParse(txtAn.Text, out an))
            {
                MessageBox.Show("Introduceți un an valid.");
                return;
            }

            LoadDetaliiSalariu(idAngajat, luna, an);
        }

        private void LoadDetaliiSalariu(int idAngajat, int luna, int an)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                SELECT
                    Angajati.Nume + ' ' + Angajati.Prenume AS NumeAgent,
                    Salarii.Salariu_Baza,
                    Salarii.Comisioane,
                    Salarii.Prime,
                    Salarii.Total_Plata
                FROM Salarii
                INNER JOIN Angajati ON Salarii.ID_Angajat = Angajati.ID_Angajat
                WHERE Salarii.ID_Angajat = @ID_Angajat AND Salarii.Luna = @Luna AND Salarii.Anul = @Anul;
            ";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Angajat", idAngajat);
                    command.Parameters.AddWithValue("@Luna", luna);
                    command.Parameters.AddWithValue("@Anul", an);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string detalii = $"Fluturaș de salariu pentru luna {luna}/{an}\n\n";
                            detalii += $"Angajat: {reader["NumeAgent"]}\n";
                            detalii += $"Salariu de bază: {reader["Salariu_Baza"]} lei\n";
                            detalii += $"Comisioane: {reader["Comisioane"]} lei\n";
                            detalii += $"Prime: {reader["Prime"]} lei\n";
                            detalii += $"Total de plată: {reader["Total_Plata"]} lei\n";

                            txtDetaliiSalariu.Text = detalii;
                        }
                        else
                        {
                            MessageBox.Show("Nu există date pentru angajatul și perioada selectată.");
                            txtDetaliiSalariu.Clear();
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnImprima_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(txtDetaliiSalariu.Text, new Font("Arial", 12), Brushes.Black, 100, 100);
            };
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}

