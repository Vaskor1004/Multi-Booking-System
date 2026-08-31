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
    public partial class ParlarList : Form
    {
        public ParlarList()
        {
            InitializeComponent();
        }

        private void btnRoxyStore_Click(object sender, EventArgs e)
        {
            RoxyParler roxyParler = new RoxyParler();
            roxyParler.Show();
            this.Hide();
        }

        private void btnShahnazStore_Click(object sender, EventArgs e)
        {
            ShahnazParlar shahnazParlar = new ShahnazParlar();
            shahnazParlar.Show();
            this.Hide();
        }

        private void btnDiyaStore_Click(object sender, EventArgs e)
        {
            DiyaParlar diyaParlar = new DiyaParlar();
            diyaParlar.Show();
            this.Hide();
        }

        private void btnparlarlistBack_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
