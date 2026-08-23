using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Multi_Booking_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             string ConnectionString = "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

             string query = @"SELECT COUNT(*)
                      FROM users
                      WHERE username = @name
                      AND password = @password";

             using (SqlConnection con = new SqlConnection(ConnectionString))
             {
                 SqlCommand cmd = new SqlCommand(query, con);

                 cmd.Parameters.AddWithValue("@name", txtboxUsernml.Text);
                 cmd.Parameters.AddWithValue("@password", txtboxPassl.Text);

                 con.Open();

                 int result = (int)cmd.ExecuteScalar();

                 if (result > 0)
                 {
                     MessageBox.Show("Login Successful!");
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
