
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Multi_Booking_System
{
    public partial class Login : Form
    {
        public static int userId;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ConnectionString =
                "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string query = @"SELECT id, userType,username
                             FROM users
                             WHERE username = @name
                             AND password = @password";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", txtboxUsernml.Text);
                cmd.Parameters.AddWithValue("@password", txtboxPassl.Text);

                con.Open();
                string username = txtboxUsernml.Text;
                string userType = null;
                var reader = cmd.ExecuteReader();
                

                while (reader.Read())
                {
                    userId = reader.GetInt32(0);
                    userType = reader.GetString(1);
                }

                if (userType != null)
                {

                    if (userType == "Customer")
                    {
                        MessageBox.Show("Customer Login Successful!");

                        UserDashboard ud = new UserDashboard();
                         ud.Show();

                        this.Hide();
                    }
                    else if (userType == "Shopkeeper")
                    {
                        MessageBox.Show("Shopkeeper Login Successful!");

                        if (username == "Shahriar123")
                        {
                            Shahriar shahriar = new Shahriar();
                            shahriar.Show();
                            this.Hide();
                        }
                        else if (username == "Sompod123")
                        {
                            Sompod sompod = new Sompod();
                            sompod.Show();
                            this.Hide();
                        }
                        else if (username == "Nusrat123")
                        {
                            RoxyOwnStore roxy = new RoxyOwnStore();
                            roxy.Show();
                            this.Hide();
                        }
                        else if (username == "Shahnaz123")
                        {
                           ShahnazOwnStore shahnaz = new ShahnazOwnStore();
                           shahnaz.Show();
                           this.Hide();
                        }
                        else if (username == "Diya123")
                        {
                            DiyaOwnStore diya = new DiyaOwnStore();
                            diya.Show();
                            this.Hide();
                        }
                        else
                        {
                            Tirtho t = new Tirtho();
                            t.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Name or Password!");
                }
            }

        } 


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

    } 

} 