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
    public partial class Shahriar : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Shahriar()
        {
            InitializeComponent();
        }
        private void btnShahriarAdd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO ShahriarStore (serviceName, price)
                             VALUES (@serviceName, @price)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@serviceName", txtaddService.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Saved");

            txtaddService.Clear();
            txtPrice.Clear();
            btnShahriarCustomerShow_Click(null, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShahriarCustomerShow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ShahriarStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);
                ShahriarGridView.DataSource = table;
            }
        }

        private void btnShahriarUpdate_Click(object sender, EventArgs e)
        {
            if (ShahriarGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = Convert.ToInt32(
                ShahriarGridView.CurrentRow.Cells["id"].Value
            );

            string query = @"UPDATE ShahriarStore
                             SET serviceName = @serviceName,
                                 price = @price
                             WHERE id = @id";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@serviceName",
                    txtUpdateServiceName.Text
                );

                cmd.Parameters.AddWithValue(
                    "@price",
                    decimal.Parse(txtUpdatePrice.Text)
                );

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Updated");

            txtId.Clear();
            txtUpdateServiceName.Clear();
            txtUpdatePrice.Clear();
            btnShahriarCustomerShow_Click(null, null);
        }

       /* private void ShahriarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = ShahriarGridView.CurrentRow.Cells["id"].Value.ToString();
            txtUpdateServiceName.Text = ShahriarGridView.CurrentRow.Cells["serviceName"].Value.ToString();
            txtUpdatePrice.Text = ShahriarGridView.CurrentRow.Cells["price"].Value.ToString();
        }
       */
        private void btnShahriarDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = int.Parse(txtId.Text);

            string query = @"DELETE FROM ShahriarStore
                     WHERE id = @id";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Deleted");
            txtId.Clear();
            txtUpdateServiceName.Clear();
            txtUpdatePrice.Clear();
            btnShahriarCustomerShow_Click(null, null);
        }

        private void ShahriarGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = ShahriarGridView.CurrentRow.Cells["id"].Value.ToString();
            txtUpdateServiceName.Text = ShahriarGridView.CurrentRow.Cells["serviceName"].Value.ToString();
            txtUpdatePrice.Text = ShahriarGridView.CurrentRow.Cells["price"].Value.ToString();
        }

        private void btnShahriarNext_Click(object sender, EventArgs e)
        {
            ShahriarApprove shahriarApprove = new ShahriarApprove();
            shahriarApprove.Show();
            this.Hide();
        }
    }
}
