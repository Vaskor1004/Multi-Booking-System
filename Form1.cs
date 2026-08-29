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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnCustomer.Checked)
            {
                txtboxCType.Text = "Customer";
            }
        }


        private void radiobtnShopkeeper_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radiobtnShopkeeper.Checked)
            {
                txtboxCType.Text = "Shopkeeper";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             string ConnectionString = "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

             SqlConnection con = new SqlConnection(ConnectionString);
             con.Open();
             string Query = "INSERT INTO Users (name, phone, password, username, userType)\r\nVALUES\r\n('"+txtboxName.Text+"', '"+txtboxMob.Text+"', '"+txtboxPass.Text+"',  '"+txtboxUname.Text+"', '"+txtboxCType.Text +"');";
             SqlCommand cmd = new SqlCommand(Query, con);
             cmd.ExecuteNonQuery();
             con.Close();

             MessageBox.Show("Data has been Saved");

           /* string ConnectionString =
        "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string userQuery = @"
            INSERT INTO Users
            (name, phone, password, username, userType)
            OUTPUT INSERTED.id
            VALUES
            (@name, @phone, @password, @username, @userType)";

                SqlCommand userCmd = new SqlCommand(userQuery, con);

                userCmd.Parameters.AddWithValue("@name", txtboxName.Text);
                userCmd.Parameters.AddWithValue("@phone", txtboxMob.Text);
                userCmd.Parameters.AddWithValue("@password", txtboxPass.Text);
                userCmd.Parameters.AddWithValue("@username", txtboxUname.Text);
                userCmd.Parameters.AddWithValue("@userType", txtboxCType.Text);
                int userId = Convert.ToInt32(userCmd.ExecuteScalar());
                if (txtboxCType.Text == "Shopkeeper")
                {
                    string shopQuery = @"
                INSERT INTO Shops
                (shopkeeperId, shopName, shopAddress)
                VALUES
                (@shopkeeperId, @shopName, @shopAddress)";

                    SqlCommand shopCmd = new SqlCommand(shopQuery, con);

                    shopCmd.Parameters.AddWithValue("@shopkeeperId", userId);
                    shopCmd.Parameters.AddWithValue("@shopName", txtboxShopName.Text);

                    shopCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration Successful!");
            }*/
           Login loginForm = new Login();
           loginForm.Show();
           this.Hide();
        }
    }
}
