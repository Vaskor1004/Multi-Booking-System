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
    public partial class DiyaCustomerReview : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public DiyaCustomerReview()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DiyaOwnStore diyaOwnStore = new DiyaOwnStore();
            diyaOwnStore.Show();
            this.Hide();
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    RD.ReviewID,

                    U.id AS CustomerID,

                    U.name AS CustomerName,

                    RD.Rating,

                    RD.ReviewText

                FROM ReviewsDiya RD

                INNER JOIN Users U
                ON RD.CustomerID = U.id

                ORDER BY RD.ReviewID ASC";

            try
            {
                using (SqlConnection con =
                    new SqlConnection(ConnectionString))
                {
                    using (SqlDataAdapter da =
                        new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dataGridViewReviews.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading reviews: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
