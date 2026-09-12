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
    public partial class AdminShopkeeper : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public AdminShopkeeper()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTirtho_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TirthoStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridViewServices.DataSource = table;
            }
        }

        private void btnSompod_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SompodStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridViewServices.DataSource = table;
            }
        }

        private void btnShahriar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ShahriarStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);
                gridViewServices.DataSource = table;
            }
        }

        private void btnTirthoReview_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    R.ReviewID,

                    U.id AS CustomerID,

                    U.name AS CustomerName,

                    R.Rating,

                    R.ReviewText

                FROM ReviewsTirtho R

                INNER JOIN Users U
                ON R.CustomerID = U.id

                ORDER BY R.ReviewID ASC";

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

                        gridViewReviews.DataSource = dt;
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

        private void btnSompodReview_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    RS.ReviewID,

                    U.id AS CustomerID,

                    U.name AS CustomerName,

                    RS.Rating,

                    RS.ReviewText

                FROM ReviewsSompod RS

                INNER JOIN Users U
                ON RS.CustomerID = U.id

                ORDER BY RS.ReviewID ASC";

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

                        gridViewReviews.DataSource = dt;
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

        private void btnShahriarReview_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    RS.ReviewID,

                    U.id AS CustomerID,

                    U.name AS CustomerName,

                    RS.Rating,

                    RS.ReviewText

                FROM ReviewsShahriar RS

                INNER JOIN Users U
                ON RS.CustomerID = U.id

                ORDER BY RS.ReviewID ASC";

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

                        gridViewReviews.DataSource = dt;
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

        private void btnDiya_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DiyaStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridViewServices.DataSource = table;
            }
        }

        private void btnShahnaz_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ShahnazStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridViewServices.DataSource = table;
            }
        }

        private void btnRoxy_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM RoxyStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridViewServices.DataSource = table;
            }
        }

        private void btnRoxyReview_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    RR.ReviewID,

                    U.id AS CustomerID,

                    U.name AS CustomerName,

                    RR.Rating,

                    RR.ReviewText

                FROM ReviewsRoxy RR

                INNER JOIN Users U
                ON RR.CustomerID = U.id

                ORDER BY RR.ReviewID ASC";

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

                        gridViewReviews.DataSource = dt;
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

        private void btnShahnazReview_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    RS.ReviewID,

                    U.id AS CustomerID,

                    U.name AS CustomerName,

                    RS.Rating,

                    RS.ReviewText

                FROM ReviewsShahnaz RS

                INNER JOIN Users U
                ON RS.CustomerID = U.id

                ORDER BY RS.ReviewID ASC";

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

                        gridViewReviews.DataSource = dt;
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

        private void btnDiyaReview_Click(object sender, EventArgs e)
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

                        gridViewReviews.DataSource = dt;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Hide();
        }
    }
    
}
