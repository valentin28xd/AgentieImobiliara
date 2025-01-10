using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class SearchOferteForm : Form
    {
        public SearchOferteForm()
        {
            InitializeComponent();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT Oferte.*, Imobile.*
                FROM Oferte
                INNER JOIN Imobile ON Oferte.ID_Imobil = Imobile.ID_Imobil
                WHERE 1=1
            ";

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(txtNumarCamere.Text))
                    {
                        query += " AND Imobile.Numar_Camere = @NumarCamere";
                        command.Parameters.AddWithValue("@NumarCamere", txtNumarCamere.Text);
                    }

                    if (!string.IsNullOrEmpty(txtLocalitate.Text))
                    {
                        query += " AND Imobile.Localitate LIKE @Localitate";
                        command.Parameters.AddWithValue("@Localitate", "%" + txtLocalitate.Text + "%");
                    }

                    if (!string.IsNullOrEmpty(txtPretMinim.Text))
                    {
                        query += " AND Imobile.Pret_Solicitat >= @PretMinim";
                        command.Parameters.AddWithValue("@PretMinim", Convert.ToDecimal(txtPretMinim.Text));
                    }

                    if (!string.IsNullOrEmpty(txtPretMaxim.Text))
                    {
                        query += " AND Imobile.Pret_Solicitat <= @PretMaxim";
                        command.Parameters.AddWithValue("@PretMaxim", Convert.ToDecimal(txtPretMaxim.Text));
                    }

                    if (cmbTipOferta.SelectedItem != null)
                    {
                        query += " AND Oferte.Tip_Oferta = @TipOferta";
                        command.Parameters.AddWithValue("@TipOferta", cmbTipOferta.SelectedItem.ToString());
                    }

                    command.CommandText = query;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }
    }
}
