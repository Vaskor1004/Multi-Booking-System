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
    public partial class RoxyParler : Form
    {
        public RoxyParler()
        {
            InitializeComponent();
        }

        private void BtnGetSerial_Click(object sender, EventArgs e)
        {
            RoxyDashBoard roxyDashBoard = new RoxyDashBoard();
            roxyDashBoard.Show();
            this.Hide();
        }

        private void btn4RoxyBack_Click(object sender, EventArgs e)
        {
            ParlarList parlarList = new ParlarList();
            parlarList.Show();
            this.Hide();
        }

        private void BtnReview_Click(object sender, EventArgs e)
        {
            RoxyReview roxyReview = new RoxyReview();
            roxyReview.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
