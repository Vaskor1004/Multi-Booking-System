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
    public partial class TirthoDashboard : Form
    {
        string ConnectionString =
            "Data Source=LAPTOP-ETFSEMF8;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public TirthoDashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TirthoStore";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                gridViewTirthoStore.DataSource = table;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
