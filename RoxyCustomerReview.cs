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
    public partial class RoxyCustomerReview : Form
    {
        public RoxyCustomerReview()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            RoxyOwnStore roxyOwnStore = new RoxyOwnStore();
            roxyOwnStore.Show();
            this.Hide();
        }
    }
}
