using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class ListAngajatiForm : Form
    {
        public ListAngajatiForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListAngajatiForm_Load);
        }

        private void ListAngajatiForm_Load(object sender, EventArgs e)
        {
            LoadAngajati();
        }

        private void LoadAngajati()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Angajati;";

                using (var command = new SqlCommand(selectQuery, connection))
                {
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
