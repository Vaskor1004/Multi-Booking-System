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
    public partial class SompodReview : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int customerId;
        public SompodReview()
        {
            InitializeComponent();
            customerId = Login.userId;
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            // Check Rating
            if (SompodRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rating.");
                return;
            }

            // Check Review
            if (string.IsNullOrWhiteSpace(txtReview.Text))
            {
                MessageBox.Show("Please write your review.");
                return;
            }

            // Get values
            int rating = Convert.ToInt32(SompodRating.SelectedItem);
            string reviewText = txtReview.Text.Trim();

            // SQL Query
            string query = @"
                INSERT INTO ReviewsSompod
                (
                    CustomerID,
                    Rating,
                    ReviewText
                )
                VALUES
                (
                    @CustomerID,
                    @Rating,
                    @ReviewText
                )";

            try
            {
                using (SqlConnection con =
                    new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@CustomerID",
                            customerId
                        );

                        cmd.Parameters.AddWithValue(
                            "@Rating",
                            rating
                        );

                        cmd.Parameters.AddWithValue(
                            "@ReviewText",
                            reviewText
                        );

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Review submitted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear form
                SompodRating.SelectedIndex = -1;
                txtReview.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
