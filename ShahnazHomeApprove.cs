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
    public partial class ShahnazHomeApprove : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ShahnazHomeApprove()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    HB.bookingId,
                    U.name AS CustomerName,
                    U.phone AS CustomerPhone,
                    W.workerName AS WorkerName,
                    W.phone AS WorkerPhone,
                    S.serviceName,
                    S.price,
                    HB.bookingDate,
                    HB.bookingTime,
                    HB.status

                    FROM HomeBookingsShahnaz HB
                    INNER JOIN Users U
                    ON HB.customerId = U.id
                    INNER JOIN ShahnazWorkers W
                    ON HB.workerId = W.workerId
                    INNER JOIN HomeBookingDetailsShahnaz HBD
                    ON HB.bookingId = HBD.bookingId
                    INNER JOIN ShahnazStore S
                    ON HBD.serviceId = S.id
                    ORDER BY HB.bookingId ASC";


            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, con);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    gridViewShahnazHomeBooking.DataSource =
                        table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading bookings!\n\n" +
                        ex.Message
                    );
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (gridViewShahnazHomeBooking.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a booking first."
                );

                return;
            }
            int bookingId =
                Convert.ToInt32(
                    gridViewShahnazHomeBooking
                    .CurrentRow
                    .Cells["bookingId"]
                    .Value
                );
            txtBookingId.Text =
                bookingId.ToString();
            // ==========================================
            // UPDATE BOOKING STATUS
            // ==========================================

            string query = @"
                UPDATE HomeBookingsShahnaz
                SET status = 'Approved'
                WHERE bookingId = @bookingId";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            con
                        );
                    cmd.Parameters.AddWithValue(
                        "@bookingId",
                        bookingId
                    );
                    con.Open();
                    int rows =
                        cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Home Service Booking Approved Successfully!"
                        );
                    }

                    // Refresh GridView
                    btnRefresh_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Approval failed!\n\n" +
                        ex.Message
                    );
                }
            }
        }

        private void gridViewShahnazHomeBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int bookingId =
                Convert.ToInt32(
                    gridViewShahnazHomeBooking
                    .Rows[e.RowIndex]
                    .Cells["bookingId"]
                    .Value
                );
            txtBookingId.Text = bookingId.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShahnazApprove shahnazApprove = new ShahnazApprove();
            shahnazApprove.Show();
            this.Hide();
        }
    }
}
