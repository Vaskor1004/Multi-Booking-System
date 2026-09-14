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
    public partial class DiyaHomeService : Form
    {
        string ConnectionString =
           "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int customerId;

        DataTable selectedServices = new DataTable();

        DataTable selectedWorkers = new DataTable();

        public DiyaHomeService()
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

            gridViewSelectedServices.DataSource = selectedServices;

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

            gridViewSelectedWorker.DataSource = selectedWorkers;

        }

        private void btnShowServices_Click(object sender, EventArgs e)
        {
            string query =
                "SELECT * FROM DiyaStore";  

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridViewHomeService.DataSource = table;
            }
        }

        private void btnAvailableWorker_Click(object sender, EventArgs e)
        {
            string query =
               "SELECT * FROM  DiyaWorkers";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridViewAvailableWorkers.DataSource = table;
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
            foreach (DataRow row in selectedServices.Rows)
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
            selectedServices.Rows.Add(serviceId, serviceName, price);
            MessageBox.Show("Service Added!");
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
            int workerId =
                Convert.ToInt32(
                    gridViewAvailableWorkers
                    .CurrentRow
                    .Cells["workerId"]
                    .Value
                );
            string workerName =
                gridViewAvailableWorkers
                .CurrentRow
                .Cells["workerName"]
                .Value
                .ToString();
            string phone =
                gridViewAvailableWorkers
                .CurrentRow
                .Cells["phone"]
                .Value
                .ToString();
            string status =
                gridViewAvailableWorkers
                .CurrentRow
                .Cells["status"]
                .Value
                .ToString();
            foreach (DataRow row in selectedWorkers.Rows)
            {
                if (Convert.ToInt32(row["workerId"])
                    == workerId)
                {
                    MessageBox.Show("This worker is already selected!");
                    return;
                }
            }
            selectedWorkers.Rows.Add(workerId, workerName, phone, status);
            MessageBox.Show("Worker Selected!");
        }

        private void btnBookSerial_Click(object sender, EventArgs e)
        {
            if (customerId <= 0)
            {
                MessageBox.Show("Customer not found!");
                return;
            }
            if (selectedWorkers.Rows.Count == 0)
            {
                MessageBox.Show("Please select a worker first!");
                return;
            }
            if (selectedServices.Rows.Count == 0)
            {
                MessageBox.Show("Please select at least one service!");
                return;
            }
            int workerId = Convert.ToInt32(selectedWorkers.Rows[0]["workerId"]);
            DateTime bookingDate = dateTimePicker2.Value.Date;
            TimeSpan bookingTime = dateTimePicker1.Value.TimeOfDay;

            using (SqlConnection con = new SqlConnection(ConnectionString))

            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    string bookingQuery = @"
                INSERT INTO HomeBookingsDiya
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
                    using (SqlCommand cmd = new SqlCommand(bookingQuery, con, transaction))

                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@workerId", workerId);
                        cmd.Parameters.AddWithValue("@bookingDate", bookingDate);
                        cmd.Parameters.AddWithValue("@bookingTime", bookingTime);
                        bookingId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    string detailQuery = @"
                            INSERT INTO HomeBookingDetailsDiya
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
                    foreach (DataRow row in selectedServices.Rows)
                    {
                        int serviceId =
                            Convert.ToInt32(
                                row["id"]
                            );
                        using (SqlCommand cmd = new SqlCommand(detailQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@bookingId", bookingId);
                            cmd.Parameters.AddWithValue("@serviceId", serviceId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    MessageBox.Show("Appointment booked successfully!");
                    selectedServices.Clear();
                    selectedWorkers.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Booking failed!\n\n" +
                        ex.Message
                    );
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DiyaDashboard diyaDashboard = new DiyaDashboard();
            diyaDashboard.Show();
            this.Hide();
        }

        private void gridViewAvailableWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int WorkerId =
                Convert.ToInt32(
                    gridViewAvailableWorkers
                    .Rows[e.RowIndex]
                    .Cells["WorkerId"]
                    .Value
                );
            if (WorkerId == 1)
            {
                DiyaStoreArny diyaStoreArny = new DiyaStoreArny();
                diyaStoreArny.Show();
            }
            else if (WorkerId == 2)
            {
               DiyaStoreNody diyaStoreNody = new DiyaStoreNody();
                diyaStoreNody.Show();
            }
            else if (WorkerId == 3)
            {
                DiyaStorePayel diyaStorePayel = new DiyaStorePayel();
                diyaStorePayel.Show();
            }
        }
        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (gridViewSelectedServices.CurrentRow == null)
            {
                MessageBox.Show("Please select a service to remove!");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this service?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                int rowIndex = gridViewSelectedServices.CurrentRow.Index;
                selectedServices.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Service Removed Successfully!");
            }
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (gridViewSelectedWorker.CurrentRow == null)
            {
                MessageBox.Show("Please select a worker to remove!");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this worker?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                int rowIndex = gridViewSelectedWorker.CurrentRow.Index;
                selectedWorkers.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Service Removed Successfully!");
            }
        }
    }
}
