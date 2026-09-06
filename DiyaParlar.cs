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
    public partial class DiyaParlar : Form
    {
        public DiyaParlar()
        {
            InitializeComponent();
        }

        private void BtnGetSerial_Click(object sender, EventArgs e)
        {
            DiyaDashboard diyaDashboard = new DiyaDashboard();
            diyaDashboard.Show();
            this.Hide();
        }

        private void btn4DiyaBack_Click(object sender, EventArgs e)
        {
            ParlarList parlarList = new ParlarList();
            parlarList.Show();
            this.Hide();
        }

        private void BtnReview_Click(object sender, EventArgs e)
        {
            DiyaReview diyaReview = new DiyaReview();
            diyaReview.Show();
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
