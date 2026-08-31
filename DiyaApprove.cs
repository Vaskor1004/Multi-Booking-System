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
    public partial class DiyaApprove : Form
    {
        public DiyaApprove()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DiyaCustomerReview diyaCustomerReview = new DiyaCustomerReview();
            diyaCustomerReview.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DiyaOwnStore diyaOwnStore = new DiyaOwnStore();
            diyaOwnStore.Show();
            this.Hide();
        }
    }
}
