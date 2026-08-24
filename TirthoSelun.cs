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
    public partial class TirthoSelun : Form
    {
        public TirthoSelun()
        {
            InitializeComponent();
        }

        private void BtnGetSerial_Click(object sender, EventArgs e)
        {
            TirthoDashboard tirthoDashboard = new TirthoDashboard();
            tirthoDashboard.Show();
            this.Hide();
        }
    }
}
