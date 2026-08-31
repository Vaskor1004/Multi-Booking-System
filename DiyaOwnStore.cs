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
    public partial class DiyaOwnStore : Form
    {
        public DiyaOwnStore()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DiyaApprove diyaApprove = new DiyaApprove();
            diyaApprove.Show();
            this.Hide();
        }
    }
}
