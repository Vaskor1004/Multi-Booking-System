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
    }
}
