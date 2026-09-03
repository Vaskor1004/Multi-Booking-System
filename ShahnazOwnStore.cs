using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Booking_System
{
    public partial class ShahnazOwnStore : Form
    {
        string ConnectionString =
          "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ShahnazOwnStore()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShahnazApprove shahnazApprove = new ShahnazApprove();
            shahnazApprove.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO ShahnazStore (serviceName, price)
                             VALUES (@serviceName, @price)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@serviceName", txtboxServiceName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtboxPrice.Text));

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Saved");

            txtboxServiceName.Clear();
            txtboxPrice.Clear();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ShahnazStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridviewShowService.DataSource = table;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridviewShowService.CurrentRow == null)
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = Convert.ToInt32(
                gridviewShowService.CurrentRow.Cells["id"].Value
            );

            string query = @"UPDATE ShahnazStore
                             SET serviceName = @serviceName,
                                 price = @price
                             WHERE id = @id";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@serviceName",
                    txtboxUName.Text
                );

                cmd.Parameters.AddWithValue(
                    "@price",
                    decimal.Parse(txtboxUService.Text)
                );

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Updated");

            txtboxUD.Clear();
            txtboxUName.Clear();
            txtboxUService.Clear();
            BtnShow_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtboxUD.Text == "")
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = int.Parse(txtboxUD.Text);

            string query = @"DELETE FROM ShahnazStore
                     WHERE id = @id";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Deleted");
            txtboxUD.Clear();
            txtboxUName.Clear();
            txtboxUService.Clear();
            BtnShow_Click(null, null);
        }

        private void gridviewShowService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxUD.Text = gridviewShowService.CurrentRow.Cells["id"].Value.ToString();
            txtboxUName.Text = gridviewShowService.CurrentRow.Cells["serviceName"].Value.ToString();
            txtboxUService.Text = gridviewShowService.CurrentRow.Cells["price"].Value.ToString();
        }
    }
    
}

