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
    public partial class SelunList : Form
    {
        public SelunList()
        {
            InitializeComponent();
        }

        private void btnTirthoStore_Click(object sender, EventArgs e)
        {
            TirthoSelun tirthoSelun = new TirthoSelun();
            tirthoSelun.Show();
            this.Hide();
        }

        private void btnShahriarStore_Click(object sender, EventArgs e)
        {
            ShahriarSelun shahriarSelun = new ShahriarSelun();
            shahriarSelun.Show();
            this.Hide();
        }

        private void btnSompodStore_Click(object sender, EventArgs e)
        {
            SompodSelun sompodSelun = new SompodSelun();
            sompodSelun.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnselunlistBack_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
