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
    public partial class DiyaHomeApprove : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public DiyaHomeApprove()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    HBD.bookingId,
                    U.name AS CustomerName,
                    U.phone AS CustomerPhone,
                    DW.workerName AS WorkerName,
                    DW.phone AS WorkerPhone,
                    D.serviceName,
                    D.price,
                    HBD.bookingDate,
                    HBD.bookingTime,
                    HBD.status

                    FROM HomeBookingsDiya HBD
                    INNER JOIN Users U
                    ON HBD.customerId = U.id
                    INNER JOIN DiyaWorkers DW
                    ON HBD.workerId = DW.workerId
                    INNER JOIN HomeBookingDetailsDiya HBDD
                    ON HBD.bookingId = HBDD.bookingId
                    INNER JOIN DiyaStore D
                    ON HBDD.serviceId = D.id
                    ORDER BY HBD.bookingId ASC";


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

                    gridViewDiyaHomeBooking.DataSource =
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
            if (gridViewDiyaHomeBooking.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a booking first."
                );

                return;
            }


            int bookingId =
                Convert.ToInt32(
                     gridViewDiyaHomeBooking
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
                UPDATE HomeBookingsDiya

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

        private void gridViewDiyaHomeBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int bookingId =
                Convert.ToInt32(
                    gridViewDiyaHomeBooking
                    .Rows[e.RowIndex]
                    .Cells["bookingId"]
                    .Value
                );
            txtBookingId.Text =
                bookingId.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DiyaApprove diyaApprove = new DiyaApprove();
            diyaApprove.Show();
            this.Hide();
        }
    }
}
