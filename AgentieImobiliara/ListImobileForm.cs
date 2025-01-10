using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class ListImobileForm : Form
    {
        public ListImobileForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListImobileForm_Load);
        }

        private void ListImobileForm_Load(object sender, EventArgs e)
        {
            LoadImobile();
        }

        private void LoadImobile()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Imobile;";

                using (var command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewImobile.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }
    }
}
