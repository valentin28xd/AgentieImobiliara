using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class TranzactiiPeAgentiForm : Form
    {
        public TranzactiiPeAgentiForm()
        {
            InitializeComponent();
            LoadTranzactii();
        }

        private void LoadTranzactii()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        Agent.Nume + ' ' + Agent.Prenume AS NumeAgent,
                        COUNT(Contracte.ID_Contract) AS NumarTranzactii,
                        SUM(Contracte.Comision_Agent) AS TotalComisionAgent
                    FROM Contracte
                    INNER JOIN Angajati AS Agent ON Contracte.ID_Agent = Agent.ID_Angajat
                    GROUP BY Agent.Nume, Agent.Prenume, Agent.ID_Angajat;
                ";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewTranzactii.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }
    }
}
