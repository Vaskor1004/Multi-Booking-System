/*using System;
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
    public partial class Tirtho : Form
    {
        public Tirtho()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "INSERT INTO TirthoStore (serviceName, price)\r\nVALUES\r\n('" + txtboxServiceName.Text + "', '" + txtboxPrice.Text + "');";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data has been Saved");
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(ConnectionString); 
            con.Open();
            string Query = "SELECT * FROM TirthoStore";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Multi_Booking_System
{
    public partial class Tirtho : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Tirtho()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO TirthoStore (serviceName, price)
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
            string query = "SELECT * FROM TirthoStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridviewTirtho.DataSource = table;
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (gridviewTirtho.CurrentRow == null)
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = Convert.ToInt32(
                gridviewTirtho.CurrentRow.Cells["id"].Value
            );
           
            string query = @"UPDATE TirthoStore
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

        private void gridviewTirtho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxUD.Text = gridviewTirtho.CurrentRow.Cells["id"].Value.ToString();
            txtboxUName.Text = gridviewTirtho.CurrentRow.Cells["serviceName"].Value.ToString();
            txtboxUService.Text = gridviewTirtho.CurrentRow.Cells["price"].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txtboxUD.Text == "")
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            int id = int.Parse(txtboxUD.Text);

            string query = @"DELETE FROM TirthoStore
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

        private void btnUserSerial_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT
            B.bookingId,

            U.name AS CustomerName,

            U.phone AS CustomerPhone,

            T.serviceName,

            T.price,

            B.bookingDate,

            B.status

        FROM Bookings B

        INNER JOIN Users U
        ON B.customerId = U.id
        INNER JOIN BookingDetails BD
        ON B.bookingId = BD.bookingId
        INNER JOIN TirthoStore T
        ON BD.serviceId = T.id
        ORDER BY B.bookingId ASC";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewUserSerial.DataSource = table;
            }
        }
    }
}
