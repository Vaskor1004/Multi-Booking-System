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
    public partial class ShahnazParlar : Form
    {
        public ShahnazParlar()
        {
            InitializeComponent();
        }

        private void BtnGetSerial_Click(object sender, EventArgs e)
        {
            ShahnazDashboard shahnazDashboard = new ShahnazDashboard();
            shahnazDashboard.Show();
            this.Hide();
        }

        private void btn4ShahnazBack_Click(object sender, EventArgs e)
        {
            ParlarList parlarList = new ParlarList();
            parlarList.Show();
            this.Hide();
        }

        private void BtnReview_Click(object sender, EventArgs e)
        {
            ShahnazReview shahnazReview = new ShahnazReview();
            shahnazReview.Show();
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
