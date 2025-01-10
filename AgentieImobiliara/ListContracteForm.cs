using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class ListContracteForm : Form
    {
        public ListContracteForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListContracteForm_Load);
        }

        private void ListContracteForm_Load(object sender, EventArgs e)
        {
            LoadContracte();
        }

        private void LoadContracte()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                SELECT
                    Contracte.ID_Contract,
                    Contracte.Data_Contract,
                    Contracte.Valoare_Tranzactie,
                    Contracte.Comision_Firma,
                    Contracte.Comision_Agent,
                    Oferte.Tip_Oferta,
                    Imobile.Adresa AS AdresaImobil,
                    Agent.Nume + ' ' + Agent.Prenume AS NumeAgent,
                    ClientVanzator.Nume + ' ' + ClientVanzator.Prenume AS Vanzator,
                    ClientCumparator.Nume + ' ' + ClientCumparator.Prenume AS Cumparator
                FROM Contracte
                INNER JOIN Oferte ON Contracte.ID_Oferta = Oferte.ID_Oferta
                INNER JOIN Imobile ON Oferte.ID_Imobil = Imobile.ID_Imobil
                INNER JOIN Angajati AS Agent ON Contracte.ID_Agent = Agent.ID_Angajat
                INNER JOIN Clienti AS ClientVanzator ON Oferte.ID_Client = ClientVanzator.ID_Client
                INNER JOIN Clienti AS ClientCumparator ON Contracte.ID_Client_Cumparator = ClientCumparator.ID_Client;
            ";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewContracte.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadContracte();
        }
    }
}
