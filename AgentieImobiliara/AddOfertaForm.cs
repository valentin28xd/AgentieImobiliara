using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class AddOfertaForm : Form
    {
        public AddOfertaForm()
        {
            InitializeComponent();
            LoadImobile();
            LoadClienti();
            LoadAngajati();
        }

        private void LoadImobile()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT ID_Imobil, Adresa
                    FROM Imobile
                    WHERE Status = 'Disponibil';
                ";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cmbImobile.DisplayMember = "Adresa";
                        cmbImobile.ValueMember = "ID_Imobil";
                        cmbImobile.DataSource = dt;
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

                string query = @"
                    SELECT ID_Client, Nume + ' ' + Prenume AS NumeComplet
                    FROM Clienti
                    WHERE Tip_Client = 'Vânzător';
                ";

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

        private void LoadAngajati()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT ID_Angajat, Nume + ' ' + Prenume AS NumeComplet
                    FROM Angajati;
                ";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cmbAgent.DisplayMember = "NumeComplet";
                        cmbAgent.ValueMember = "ID_Angajat";
                        cmbAgent.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbImobile.SelectedValue == null ||
                    cmbClienti.SelectedValue == null ||
                    cmbAgent.SelectedValue == null ||
                    cmbTipOferta.SelectedItem == null)
                {
                    MessageBox.Show("Vă rugăm să completați toate câmpurile obligatorii.");
                    return;
                }

                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string insertQuery = @"
                        INSERT INTO Oferte
                        (ID_Imobil, ID_Client, ID_Agent, Tip_Oferta, Data_Adaugare, Tarif_Luna, Numar_Luni_Minim, Numar_Luni_Maxim)
                        VALUES
                        (@ID_Imobil, @ID_Client, @ID_Agent, @Tip_Oferta, @Data_Adaugare, @Tarif_Luna, @Numar_Luni_Minim, @Numar_Luni_Maxim);
                    ";

                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Imobil", cmbImobile.SelectedValue);
                        command.Parameters.AddWithValue("@ID_Client", cmbClienti.SelectedValue);
                        command.Parameters.AddWithValue("@ID_Agent", cmbAgent.SelectedValue);
                        command.Parameters.AddWithValue("@Tip_Oferta", cmbTipOferta.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Data_Adaugare", dtpDataAdaugare.Value.Date);

                        if (string.IsNullOrEmpty(txtTarifLuna.Text))
                            command.Parameters.AddWithValue("@Tarif_Luna", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Tarif_Luna", Convert.ToDecimal(txtTarifLuna.Text));

                        if (string.IsNullOrEmpty(txtNumarLuniMinim.Text))
                            command.Parameters.AddWithValue("@Numar_Luni_Minim", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Numar_Luni_Minim", Convert.ToInt32(txtNumarLuniMinim.Text));

                        if (string.IsNullOrEmpty(txtNumarLuniMaxim.Text))
                            command.Parameters.AddWithValue("@Numar_Luni_Maxim", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Numar_Luni_Maxim", Convert.ToInt32(txtNumarLuniMaxim.Text));

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Oferta a fost adăugată cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea ofertei: " + ex.Message);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipOferta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipOferta.SelectedItem.ToString() == "Închiriere")
            {
                lblTarifLuna.Visible = true;
                txtTarifLuna.Visible = true;
                lblNumarLuniMinim.Visible = true;
                txtNumarLuniMinim.Visible = true;
                lblNumarLuniMaxim.Visible = true;
                txtNumarLuniMaxim.Visible = true;
            }
            else
            {
                lblTarifLuna.Visible = false;
                txtTarifLuna.Visible = false;
                lblNumarLuniMinim.Visible = false;
                txtNumarLuniMinim.Visible = false;
                lblNumarLuniMaxim.Visible = false;
                txtNumarLuniMaxim.Visible = false;
            }
        }
    }
}