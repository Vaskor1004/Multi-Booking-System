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
    public partial class CustomerSerialDetails : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int customerId;
        public CustomerSerialDetails()
        {
            InitializeComponent();
        }

        private void btnCustomerSerialDetails_Click(object sender, EventArgs e)
        {
            customerId=Login.userId;

            string query = @"
        SELECT
            B.bookingId,
            T.serviceName,
            T.price,
            B.bookingDate,
            B.status

        FROM Bookings B

        INNER JOIN BookingDetails BD
        ON B.bookingId = BD.bookingId

        INNER JOIN TirthoStore T
        ON BD.serviceId = T.id

        WHERE B.customerId = @customerId

        ORDER BY B.bookingId ASC";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@customerId",
                    customerId
                );

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewSerialDetails.DataSource =
                    table;
            }
        }
    }
}
