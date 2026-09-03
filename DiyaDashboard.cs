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
    public partial class DiyaDashboard : Form
    {
        string ConnectionString =
           "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int customerId;

        DataTable selectedServices =
            new DataTable();
        public DiyaDashboard()
        {
            InitializeComponent();
            customerId = Login.userId;

            selectedServices.Columns.Add(
               "id",
               typeof(int)
           );

            selectedServices.Columns.Add(
                "serviceName",
                typeof(string)
            );

            selectedServices.Columns.Add(
                "price",
                typeof(decimal)
            );

            gridViewSelectedServices.DataSource =
                selectedServices;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ParlarList parlarList = new ParlarList();
            parlarList.Show();
            this.Hide();
        }

        private void BtnShowServiceDiya_Click(object sender, EventArgs e)
        {
            string query =
               "SELECT * FROM DiyaStore";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewDiyaStore.DataSource =
                    table;
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (gridViewDiyaStore.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a service first!"
                );

                return;
            }

            int serviceId =
                Convert.ToInt32(
                    gridViewDiyaStore
                    .CurrentRow
                    .Cells["id"]
                    .Value
                );

            string serviceName =
                gridViewDiyaStore
                .CurrentRow
                .Cells["serviceName"]
                .Value
                .ToString();

            decimal price =
                Convert.ToDecimal(
                    gridViewDiyaStore
                    .CurrentRow
                    .Cells["price"]
                    .Value
                );
            foreach (DataRow row
                     in selectedServices.Rows)
            {
                if (Convert.ToInt32(row["id"])
                    == serviceId)
                {
                    MessageBox.Show(
                        "This service is already selected!"
                    );

                    return;
                }
            }


            selectedServices.Rows.Add(
                serviceId,
                serviceName,
                price
            );

            //gridViewSelectedServices.DataSource = selectedServices;

            MessageBox.Show(
                "Service Added!"
            );
        }

        private void btnBookSerial_Click(object sender, EventArgs e)
        {
            if (selectedServices.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one service!"
                );

                return;
            }

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    string bookingQuery = @"
                        INSERT INTO BookingsDiya
                        (customerId, status)

                        OUTPUT INSERTED.bookingId

                        VALUES
                        (@customerId, 'Pending')";

                    SqlCommand bookingCmd =
                        new SqlCommand(
                            bookingQuery,
                            con,
                            transaction
                        );

                    bookingCmd.Parameters.AddWithValue(
                        "@customerId",
                        customerId
                    );

                    int bookingId =
                        Convert.ToInt32(
                            bookingCmd.ExecuteScalar()
                        );
                    foreach (DataRow row
                             in selectedServices.Rows)
                    {
                        string detailQuery = @"
                            INSERT INTO BookingDetailsDiya
                            (bookingId, serviceId)

                            VALUES
                            (@bookingId, @serviceId)";

                        SqlCommand detailCmd =
                            new SqlCommand(
                                detailQuery,
                                con,
                                transaction
                            );

                        detailCmd.Parameters.AddWithValue(
                            "@bookingId",
                            bookingId
                        );

                        detailCmd.Parameters.AddWithValue(
                            "@serviceId",
                            Convert.ToInt32(
                                row["id"]
                            )
                        );

                        detailCmd.ExecuteNonQuery();
                    }
                    transaction.Commit();

                    MessageBox.Show(
                        "Serial Booked Successfully!"
                    );

                    selectedServices.Rows.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "Booking Failed: "
                        + ex.Message
                    );
                }
            }
        }
    }
}
