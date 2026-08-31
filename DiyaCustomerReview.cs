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
    public partial class DiyaCustomerReview : Form
    {
        public DiyaCustomerReview()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DiyaOwnStore diyaOwnStore = new DiyaOwnStore();
            diyaOwnStore.Show();
            this.Hide();
        }
    }
}
