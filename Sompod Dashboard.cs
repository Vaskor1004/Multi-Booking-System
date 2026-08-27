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
    public partial class Sompod_Dashboard : Form
    {
        public Sompod_Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SompodSelun sompodSelun = new SompodSelun();
            sompodSelun.Show();
            this.Hide();
        }
    }
}
