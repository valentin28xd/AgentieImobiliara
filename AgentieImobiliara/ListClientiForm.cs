using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class ListClientiForm : Form
    {
        public ListClientiForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListClientiForm_Load);
        }

        private void ListClientiForm_Load(object sender, EventArgs e)
        {
            LoadClienti();
        }

        private void LoadClienti()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Clienti;";

                using (var command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewClienti.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }
    }
}
