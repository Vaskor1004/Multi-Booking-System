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
    public partial class SompodApprove : Form
    {
        string ConnectionString =
          "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public SompodApprove()
        {
            InitializeComponent();
        }

        private void btnCustomerSerial_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT
            BS.bookingId,

            U.name AS CustomerName,

            U.phone AS CustomerPhone,

            S.serviceName,

            S.price,

            BS.bookingDate,

            BS.status

        FROM BookingsSompod BS

        INNER JOIN Users U
        ON BS.customerId = U.id
        INNER JOIN BookingDetailsSompod BDS
        ON BS.bookingId = BDS.bookingId
        INNER JOIN SompodStore S
        ON BDS.serviceId = S.id
        ORDER BY BS.bookingId ASC";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewCustomerSerial.DataSource = table;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (gridViewCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(
                gridViewCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
            txtboxId.Text = bookingId.ToString();

            string query = @"
        UPDATE BookingsSompod
        SET status = 'Approved'
        WHERE bookingId = @bookingId";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@bookingId",
                    bookingId
                );

                con.Open();

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Booking Approved Successfully!");

            // আবার GridView refresh হবে
            btnCustomerSerial_Click(null, null);
        }

        private void gridViewCustomerSerial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookingId = Convert.ToInt32(
               gridViewCustomerSerial
               .CurrentRow
               .Cells["bookingId"]
               .Value
           );
           txtboxId.Text = bookingId.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SompodCustomerReview sompodCustomerReview = new SompodCustomerReview();
            sompodCustomerReview.Show();
            this.Hide();
        }
    }
}
