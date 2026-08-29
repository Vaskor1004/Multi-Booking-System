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
    public partial class Sompod : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Sompod()
        {
            InitializeComponent();
        }

        private void btnSompodAdd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO SompodStore (serviceName, price)
                             VALUES (@serviceName, @price)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@serviceName", txtShompodServiceName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtShompodPrice.Text));

                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtShompodServiceName.Clear();
            txtShompodPrice.Clear();
            btnShowService_Click(null, null);
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SompodStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridViewSompodService.DataSource = table;
            }
        }

        private void btnShomppodUpdate_Click(object sender, EventArgs e)
        {
            if (gridViewSompodService.CurrentRow == null)
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = Convert.ToInt32(
                gridViewSompodService.CurrentRow.Cells["id"].Value
            );

            string query = @"UPDATE SompodStore
                             SET serviceName = @serviceName,
                                 price = @price
                             WHERE id = @id";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@serviceName",
                    txtShompodServicenameUppdate.Text
                );

                cmd.Parameters.AddWithValue(
                    "@price",
                    decimal.Parse(txtShompodUpdateprice.Text)
                );

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Updated");

            txtShompodId.Clear();
            txtShompodServicenameUppdate.Clear();
            txtShompodUpdateprice.Clear();
            btnShowService_Click(null, null);
        }

        private void gridViewSompodService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtShompodId.Text = gridViewSompodService.CurrentRow.Cells["id"].Value.ToString();
            txtShompodServicenameUppdate.Text = gridViewSompodService.CurrentRow.Cells["serviceName"].Value.ToString();
            txtShompodUpdateprice.Text = gridViewSompodService.CurrentRow.Cells["price"].Value.ToString();
        }

        private void btnShompodDelete_Click(object sender, EventArgs e)
        {
            if (txtShompodId.Text == "")
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = int.Parse(txtShompodId.Text);

            string query = @"DELETE FROM SompodStore
                     WHERE id = @id";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data has been Deleted");
            txtShompodId.Clear();
            txtShompodServicenameUppdate.Clear();
            txtShompodUpdateprice.Clear();
            btnShowService_Click(null, null);
        }
    }
}
