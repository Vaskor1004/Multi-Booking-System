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
    public partial class SeeShahnazReview : Form
    {
        string ConnectionString =
           "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public SeeShahnazReview()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShahnazParlar shahnazParlar = new ShahnazParlar();
            shahnazParlar.Show();
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
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
    }
}
