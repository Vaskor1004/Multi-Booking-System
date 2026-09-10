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
    public partial class RoxyApprove : Form
    {
        string ConnectionString =
          "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public RoxyApprove()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoxyOwnStore roxyOwnStore = new RoxyOwnStore();
            roxyOwnStore.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            RoxyCustomerReview roxyCustomerReview = new RoxyCustomerReview();
            roxyCustomerReview.Show();
            this.Hide();
        }

        private void btnRoxyCustomerSerial_Click(object sender, EventArgs e)
        {
            string query = @"
           SELECT
            BR.bookingId,

            U.name AS CustomerName,

            U.phone AS CustomerPhone,

            R.serviceName,

            R.price,

            BR.bookingDate,

            BR.status

        FROM BookingsRoxy BR

        INNER JOIN Users U
        ON BR.customerId = U.id
        INNER JOIN BookingDetailsRoxy BDR
        ON BR.bookingId = BDR.bookingId
        INNER JOIN RoxyStore R
        ON BDR.serviceId = R.id
        ORDER BY BR.bookingId ASC";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewRoxyCustomerSerial.DataSource = table;
            }
        }

        private void btnRoxyApprove_Click(object sender, EventArgs e)
        {
            if (gridViewRoxyCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(
                gridViewRoxyCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
            txtboxRoxyCustomerSerial.Text = bookingId.ToString();

            string query = @"
        UPDATE BookingsRoxy
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
            btnRoxyCustomerSerial_Click(null, null);
        }

        private void gridViewRoxyCustomerSerial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookingId = Convert.ToInt32(
               gridViewRoxyCustomerSerial
               .CurrentRow
               .Cells["bookingId"]
               .Value
           );
            txtboxRoxyCustomerSerial.Text = bookingId.ToString();
        }

        private void btnHomeSerial_Click(object sender, EventArgs e)
        {
            RoxyHomeApprove roxyHomeApprove = new RoxyHomeApprove();
            roxyHomeApprove.Show();
            this.Hide();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (gridViewRoxyCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }
            int bookingId = Convert.ToInt32(
                gridViewRoxyCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );

            string checkQuery = @"
                SELECT status
                FROM BookingsRoxy
                WHERE bookingId = @bookingId";

            string status = "";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(checkQuery, con);

                cmd.Parameters.AddWithValue("@bookingId", bookingId);

                con.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    status = result.ToString();
                }
            }
            if (status != "Approved")
            {
                MessageBox.Show(
                    "This booking is Not Approved yet!",
                    "Cannot Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            string deleteDetailsQuery = @"
                    DELETE FROM BookingDetailsRoxy
                    WHERE bookingId = @bookingId";

            string deleteBookingQuery = @"
                    DELETE FROM BookingsRoxy
                    WHERE bookingId = @bookingId
                    AND status = 'Approved'";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {

                    SqlCommand cmdDetails = new SqlCommand(
                        deleteDetailsQuery,
                        con,
                        transaction
                    );
                    cmdDetails.Parameters.AddWithValue(
                        "@bookingId",
                        bookingId
                    );
                    cmdDetails.ExecuteNonQuery();
                    SqlCommand cmdBooking = new SqlCommand(
                        deleteBookingQuery,
                        con,
                        transaction
                    );

                    cmdBooking.Parameters.AddWithValue(
                        "@bookingId",
                        bookingId
                    );

                    int rowsAffected = cmdBooking.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        transaction.Commit();

                        MessageBox.Show(
                            "Booking Completed Successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        btnRoxyCustomerSerial_Click(null, null);
                        txtboxRoxyCustomerSerial.Clear();
                    }
                    else
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Booking could not be completed.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "Error: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
