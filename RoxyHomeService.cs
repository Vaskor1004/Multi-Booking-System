using Guna.UI2.WinForms.Suite;
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
    public partial class RoxyHomeService : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int customerId;

        DataTable selectedServices = new DataTable();

        DataTable selectedWorkers = new DataTable();

        public RoxyHomeService()
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

            selectedWorkers.Columns.Add(
                "workerId",
                typeof(int)
            );

            selectedWorkers.Columns.Add(
                "workerName",
                typeof(string)
            );

            selectedWorkers.Columns.Add(
                "phone",
                typeof(string)
            );

            selectedWorkers.Columns.Add(
                "status",
                typeof(string)
            );

            gridViewSelectedWorker.DataSource =
                selectedWorkers;
        }

        private void btnShowServices_Click(object sender, EventArgs e)
        {
            string query =
                "SELECT * FROM RoxyStore";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewHomeService.DataSource =
                    table;
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (gridViewHomeService.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a service first!"
                );

                return;
            }

            int serviceId =
                Convert.ToInt32(
                    gridViewHomeService
                    .CurrentRow
                    .Cells["id"]
                    .Value
                );

            string serviceName =
                gridViewHomeService
                .CurrentRow
                .Cells["serviceName"]
                .Value
                .ToString();

            decimal price =
                Convert.ToDecimal(
                    gridViewHomeService
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

        private void btnAvailableWorker_Click(object sender, EventArgs e)
        {
            string query =
                "SELECT * FROM  RoxyWorkers";

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                gridViewAvailableWorkers.DataSource =
                    table;
            }
        }

        private void btnSelectWorker_Click(object sender, EventArgs e)
        {
            if (gridViewAvailableWorkers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a worker first!"
                );

                return;
            }
            // Get Worker ID
            int workerId =
                Convert.ToInt32(
                    gridViewAvailableWorkers
                    .CurrentRow
                    .Cells["workerId"]
                    .Value
                );
            // Get Worker Name
            string workerName =
                gridViewAvailableWorkers
                .CurrentRow
                .Cells["workerName"]
                .Value
                .ToString();
            // Get Phone
            string phone =
                gridViewAvailableWorkers
                .CurrentRow
                .Cells["phone"]
                .Value
                .ToString();
            // Get Status
            string status =
                gridViewAvailableWorkers
                .CurrentRow
                .Cells["status"]
                .Value
                .ToString();
            // Check if worker already selected
            foreach (DataRow row
                     in selectedWorkers.Rows)
            {
                if (Convert.ToInt32(row["workerId"])
                    == workerId)
                {
                    MessageBox.Show(
                        "This worker is already selected!"
                    );

                    return;
                }
            }
            // Add worker to Selected Worker table
            selectedWorkers.Rows.Add(
                workerId,
                workerName,
                phone,
                status
            );
            MessageBox.Show(
                "Worker Selected!"
            );
        }

        private void btnBookSerial_Click(object sender, EventArgs e)
        {
           
            // ==========================================
            // CHECK CUSTOMER
            // ==========================================

            if (customerId <= 0)
            {
                MessageBox.Show("Customer not found!");
                return;
            }


            // ==========================================
            // CHECK WORKER
            // ==========================================

            if (selectedWorkers.Rows.Count == 0)
            {
                MessageBox.Show("Please select a worker first!");
                return;
            }


            // ==========================================
            // CHECK SERVICE
            // ==========================================

            if (selectedServices.Rows.Count == 0)
            {
                MessageBox.Show("Please select at least one service!");
                return;
            }


            // ==========================================
            // GET SELECTED WORKER
            // ==========================================

            int workerId =
                Convert.ToInt32(
                    selectedWorkers.Rows[0]["workerId"]
                );


            // ==========================================
            // GET DATE AND TIME
            // ==========================================

            DateTime bookingDate =
                dateTimePicker2.Value.Date;

            TimeSpan bookingTime =
                dateTimePicker1.Value.TimeOfDay;


            // ==========================================
            // GET ADDRESS
            // ==========================================

            //string customerAddress =
            //    txtAddress.Text.Trim();


            //if (customerAddress == "")
            //{
            //    MessageBox.Show("Please enter your address!");
            //    return;
            //}


            // ==========================================
            // DATABASE OPERATION
            // ==========================================

            using (SqlConnection con =
                   new SqlConnection(ConnectionString))
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    // ==========================================
                    // STEP 1: INSERT INTO HomeBookingsRoxy
                    // ==========================================

                    string bookingQuery = @"
                INSERT INTO HomeBookingsRoxy
                (
                    customerId,
                    workerId,
                    bookingDate,
                    bookingTime,
                    status
                )
                VALUES
                (
                    @customerId,
                    @workerId,
                    @bookingDate,
                    @bookingTime,
                    'Pending'
                );

                SELECT SCOPE_IDENTITY();
            ";


                    int bookingId;


                    using (SqlCommand cmd =
                           new SqlCommand(
                               bookingQuery,
                               con,
                               transaction))
                    {
                        cmd.Parameters.AddWithValue(
                            "@customerId",
                            customerId
                        );

                        cmd.Parameters.AddWithValue(
                            "@workerId",
                            workerId
                        );

                        cmd.Parameters.AddWithValue(
                            "@bookingDate",
                            bookingDate
                        );

                        cmd.Parameters.AddWithValue(
                            "@bookingTime",
                            bookingTime
                        );


                        bookingId =
                            Convert.ToInt32(
                                cmd.ExecuteScalar()
                            );
                    }


                    // ==========================================
                    // STEP 2: INSERT SELECTED SERVICES
                    // ==========================================

                    string detailQuery = @"
                INSERT INTO HomeBookingDetailsRoxy
                (
                    bookingId,
                    serviceId
                )
                VALUES
                (
                    @bookingId,
                    @serviceId
                );
            ";


                    foreach (DataRow row
                             in selectedServices.Rows)
                    {
                        int serviceId =
                            Convert.ToInt32(
                                row["id"]
                            );
                        using (SqlCommand cmd =
                               new SqlCommand(
                                   detailQuery,
                                   con,
                                   transaction))
                        {
                            cmd.Parameters.AddWithValue(
                                "@bookingId",
                                bookingId
                            );

                            cmd.Parameters.AddWithValue(
                                "@serviceId",
                                serviceId
                            );
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    MessageBox.Show("Appointment booked successfully!");
              
                    // ==========================================
                    // CLEAR SELECTED DATA
                    // ==========================================

                    selectedServices.Clear();
                    selectedWorkers.Clear();
                }
                catch (Exception ex)
                {
                    // If anything goes wrong,
                    // undo all database changes

                    transaction.Rollback();

                    MessageBox.Show(
                        "Booking failed!\n\n" +
                        ex.Message
                    );
                }
            }
        
    }
    }
}
