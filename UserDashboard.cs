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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void BtnSelun_Click(object sender, EventArgs e)
        {
            SelunList selunList = new SelunList();
            selunList.Show();
            this.Hide();
        }

        private void btnSerialdetail_Click(object sender, EventArgs e)
        {
            CustomerSerialDetails customerSerialDetails = new CustomerSerialDetails();
            customerSerialDetails.Show();
            this.Hide();
        }
    }
}
