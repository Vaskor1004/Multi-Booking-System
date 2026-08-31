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
    public partial class ShahnazApprove : Form
    {
        public ShahnazApprove()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShahnazOwnStore shahnazOwnStore = new ShahnazOwnStore();
            shahnazOwnStore.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShahnazCustomerReview shahnazCustomerReview = new ShahnazCustomerReview();
            shahnazCustomerReview.Show();
            this.Hide();
        }
    }
}
