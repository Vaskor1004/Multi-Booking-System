using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Booking_System
{
    public partial class ShahriarSelun : Form
    {
        public ShahriarSelun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShahriarDashboard shahriarDashboard = new ShahriarDashboard(); 
            shahriarDashboard.Show();
            this.Hide();
        }

        private void btn4ShahriarBack_Click(object sender, EventArgs e)
        {
            SelunList selunList = new SelunList();
            selunList.Show();
            this.Hide();
        }

        private void btn3ShahriarLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn2ShahriarReview_Click(object sender, EventArgs e)
        {
            ShahriarReview shahriarReview = new ShahriarReview();
            shahriarReview.Show();
            this.Hide();
        }
    }
}
