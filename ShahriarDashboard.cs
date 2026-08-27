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
    public partial class ShahriarDashboard : Form
    {
        public ShahriarDashboard()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ShahriarSelun shahriarSelun = new ShahriarSelun();
            shahriarSelun.Show();
            this.Hide();
        }
    }
}
