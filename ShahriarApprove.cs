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
    
    public partial class ShahriarApprove : Form
    {
        string ConnectionString =
          "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ShahriarApprove()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        FROM BookingsShahriar BS

        INNER JOIN Users U
        ON BS.customerId = U.id
        INNER JOIN BookingDetailsShahriar BDS
        ON BS.bookingId = BDS.bookingId
        INNER JOIN ShahriarStore S
        ON BDS.serviceId = S.id
        ORDER BY BS.bookingId ASC";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridviewCustomerSerial.DataSource = table;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (gridviewCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(
                 gridviewCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
           gridviewCustomerSerial.Text = bookingId.ToString();

            string query = @"
        UPDATE BookingsShahriar
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
            txtboxid.Clear();
            guna2Button1_Click(null, null);
        }

        private void gridviewCustomerSerial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookingId = Convert.ToInt32(
                gridviewCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
            txtboxid.Text = bookingId.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ShahriarCustomerReview reviewForm = new ShahriarCustomerReview();
            reviewForm.Show();
            this.Hide();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (gridviewCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }
            int bookingId = Convert.ToInt32(
                gridviewCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );

            string checkQuery = @"
                SELECT status
                FROM BookingsShahriar
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
                    DELETE FROM BookingDetailsShahriar
                    WHERE bookingId = @bookingId";

            string deleteBookingQuery = @"
                    DELETE FROM BookingsShahriar
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
                        guna2Button1_Click(null, null);
                        txtboxid.Clear();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Shahriar shahriar = new Shahriar();
            shahriar.Show();
            this.Hide();
        }
    }
}
