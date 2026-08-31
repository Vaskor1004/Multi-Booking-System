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
    public partial class RoxyApprove : Form
    {
        public RoxyApprove()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoxyOwnStore roxyOwnStore = new RoxyOwnStore();
            roxyOwnStore.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            RoxyCustomerReview roxyCustomerReview = new RoxyCustomerReview();
            roxyCustomerReview.Show();
            this.Hide();
        }
    }
}
