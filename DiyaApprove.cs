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
    public partial class DiyaApprove : Form
    {
        string ConnectionString =
          "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public DiyaApprove()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DiyaCustomerReview diyaCustomerReview = new DiyaCustomerReview();
            diyaCustomerReview.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DiyaOwnStore diyaOwnStore = new DiyaOwnStore();
            diyaOwnStore.Show();
            this.Hide();
        }

        private void btnDiyaCustomerSerial_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT
            BD.bookingId,

            U.name AS CustomerName,

            U.phone AS CustomerPhone,

            D.serviceName,

            D.price,

            BD.bookingDate,

            BD.status

        FROM BookingsDiya BD

        INNER JOIN Users U
        ON BD.customerId = U.id
        INNER JOIN BookingDetailsDiya BDD
        ON BD.bookingId = BDD.bookingId
        INNER JOIN DiyaStore D
        ON BDD.serviceId = D.id
        ORDER BY BD.bookingId ASC";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewDiyaCustomerSerial.DataSource = table;
            }
        }

        private void btnDiyaApprove_Click(object sender, EventArgs e)
        {
            if (gridViewDiyaCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(
                gridViewDiyaCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
            txtboxDiyaCustomerSerial.Text = bookingId.ToString();

            string query = @"
        UPDATE BookingsDiya
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
            btnDiyaCustomerSerial_Click(null, null);
        }

        private void gridViewDiyaCustomerSerial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookingId = Convert.ToInt32(
               gridViewDiyaCustomerSerial
               .CurrentRow
               .Cells["bookingId"]
               .Value
           );
            txtboxDiyaCustomerSerial.Text = bookingId.ToString();
        }

        private void btnHomeSerial_Click(object sender, EventArgs e)
        {
            DiyaHomeApprove diyaHomeApprove = new DiyaHomeApprove();
            diyaHomeApprove.Show();
            this.Hide();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (gridViewDiyaCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }
            int bookingId = Convert.ToInt32(
                gridViewDiyaCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );

            string checkQuery = @"
                SELECT status
                FROM BookingsDiya
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
                    DELETE FROM BookingDetailsDiya
                    WHERE bookingId = @bookingId";

            string deleteBookingQuery = @"
                    DELETE FROM BookingsDiya
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
                        btnDiyaCustomerSerial_Click(null, null);
                        txtboxDiyaCustomerSerial.Clear();
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
