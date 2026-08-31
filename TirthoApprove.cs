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
    public partial class TirthoApprove : Form
    {
        string ConnectionString =
           "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public TirthoApprove()
        {
            InitializeComponent();
        }

        private void btnTirthoCustomerSerial_Click(object sender, EventArgs e)
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

                gridViewTithoCustomerSerial.DataSource = table;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (gridViewTithoCustomerSerial.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(
                gridViewTithoCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
            txtboxTirthoCustomerSerial.Text = bookingId.ToString();

            string query = @"
        UPDATE Bookings
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
            btnTirthoCustomerSerial_Click(null, null);
        }

        private void gridViewTithoCustomerSerial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookingId = Convert.ToInt32(
                gridViewTithoCustomerSerial
                .CurrentRow
                .Cells["bookingId"]
                .Value
            );
            txtboxTirthoCustomerSerial.Text = bookingId.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TirthoCustomerSerial tirthoCustomerSerial = new TirthoCustomerSerial();
            tirthoCustomerSerial.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Tirtho tirtho = new Tirtho();
            tirtho.Show();
            this.Hide();
        }
    }
}
