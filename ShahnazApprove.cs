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
    public partial class ShahnazApprove : Form
    {
        string ConnectionString =
          "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ShahnazApprove()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShahnazOwnStore shahnazOwnStore = new ShahnazOwnStore();
            shahnazOwnStore.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShahnazCustomerReview shahnazCustomerReview = new ShahnazCustomerReview();
            shahnazCustomerReview.Show();
            this.Hide();
        }

        private void btnShahnazApprove_Click(object sender, EventArgs e)
        {
            if (gridViewShahnazCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(
                gridViewShahnazCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
            txtboxShahnazCustomerSerial.Text = bookingId.ToString();

            string query = @"
        UPDATE BookingsShahnaz
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
            btnShahnazCustomerSerial_Click(null, null);
        }

        private void btnShahnazCustomerSerial_Click(object sender, EventArgs e)
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

        FROM BookingsShahnaz BS

        INNER JOIN Users U
        ON BS.customerId = U.id
        INNER JOIN BookingDetailsShahnaz BDS
        ON BS.bookingId = BDS.bookingId
        INNER JOIN ShahnazStore S
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

                gridViewShahnazCustomerSerial.DataSource = table;
            }
            }

        private void gridViewShahnazCustomerSerial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookingId = Convert.ToInt32(
               gridViewShahnazCustomerSerial
               .CurrentRow
               .Cells["bookingId"]
               .Value
           );
            txtboxShahnazCustomerSerial.Text = bookingId.ToString();
        }
    }
    
}
