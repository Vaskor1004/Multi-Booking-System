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
    public partial class CustomerSerial : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int customerId;
        public CustomerSerial()
        {
            InitializeComponent();
        }

        private void btnTirtho_Click(object sender, EventArgs e)
        {
            customerId = Login.userId;

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

                if (table.Rows.Count == 0)
                {
                    gridViewSerial.DataSource = null;

                    MessageBox.Show(
                        "You don't have any appointment.",
                        "No Appointment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                gridViewSerial.DataSource =
                    table;
            }
        }

        private void btnShahriar_Click(object sender, EventArgs e)
        {
            customerId = Login.userId;

            string query = @"
        SELECT
            B.bookingId,
            S.serviceName,
            S.price,
            B.bookingDate,
            B.status

        FROM BookingsShahriar B

        INNER JOIN BookingDetailsShahriar BD
        ON B.bookingId = BD.bookingId

        INNER JOIN ShahriarStore S
        ON BD.serviceId = S.id

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

                if (table.Rows.Count == 0)
                {
                    gridViewSerial.DataSource = null;

                    MessageBox.Show(
                        "You don't have any appointment.",
                        "No Appointment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                gridViewSerial.DataSource =
                    table;
            }
        }

        private void btnSompod_Click(object sender, EventArgs e)
        {
            customerId = Login.userId;

            string query = @"
        SELECT
            B.bookingId,
            S.serviceName,
            S.price,
            B.bookingDate,
            B.status

        FROM BookingsSompod B

        INNER JOIN BookingDetailsSompod BD
        ON B.bookingId = BD.bookingId

        INNER JOIN SompodStore S
        ON BD.serviceId = S.id

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

                if (table.Rows.Count == 0)
                {
                    gridViewSerial.DataSource = null;

                    MessageBox.Show(
                        "You don't have any appointment.",
                        "No Appointment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                gridViewSerial.DataSource =
                    table;
            }
        }

        private void btnRoxy_Click(object sender, EventArgs e)
        {
            customerId = Login.userId;

            string query = @"
        SELECT
            B.bookingId,
            R.serviceName,
            R.price,
            B.bookingDate,
            B.status

        FROM BookingsRoxy B

        INNER JOIN BookingDetailsRoxy BD
        ON B.bookingId = BD.bookingId

        INNER JOIN RoxyStore R
        ON BD.serviceId = R.id

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

                if (table.Rows.Count == 0)
                {
                    gridViewSerial.DataSource = null;

                    MessageBox.Show(
                        "You don't have any appointment.",
                        "No Appointment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                gridViewSerial.DataSource =
                    table;
            }
        }

        private void btnShahnaz_Click(object sender, EventArgs e)
        {
            customerId = Login.userId;

            string query = @"
        SELECT
            B.bookingId,
            S.serviceName,
            S.price,
            B.bookingDate,
            B.status

        FROM BookingsShahnaz B

        INNER JOIN BookingDetailsShahnaz BD
        ON B.bookingId = BD.bookingId

        INNER JOIN ShahnazStore S
        ON BD.serviceId = S.id

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

                if (table.Rows.Count == 0)
                {
                    gridViewSerial.DataSource = null;

                    MessageBox.Show(
                        "You don't have any appointment.",
                        "No Appointment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                gridViewSerial.DataSource =
                    table;
            }
        }

        private void btnDiya_Click(object sender, EventArgs e)
        {
            customerId = Login.userId;

            string query = @"
        SELECT
            B.bookingId,
            D.serviceName,
            D.price,
            B.bookingDate,
            B.status

        FROM BookingsDiya B

        INNER JOIN BookingDetailsDiya BD
        ON B.bookingId = BD.bookingId

        INNER JOIN DiyaStore D
        ON BD.serviceId = D.id

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

                if (table.Rows.Count == 0)
                {
                    gridViewSerial.DataSource = null;
                    MessageBox.Show(
                        "You don't have any appointment.",
                        "No Appointment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                gridViewSerial.DataSource =
                    table;
            }
        }
    }
}
