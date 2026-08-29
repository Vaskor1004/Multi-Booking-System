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
            this.WindowState = FormWindowState.Maximized;

            // Form load হলে position ঠিক করবে
            this.Load += UserDashboard_Load;

            // Window resize হলেও position ঠিক থাকবে
            this.Resize += UserDashboard_Resize;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            ArrangeControls();
        }

        private void UserDashboard_Resize(object sender, EventArgs e)
        {
            ArrangeControls();
        }

        private void ArrangeControls()
        {
            int gap = 60;

            // 3টা panel-এর total width
            int totalWidth =
                panelSelun.Width +
                panelBeuaty.Width +
                panel3.Width +
                (gap * 2);

            // পুরো group screen-এর center এ
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            // 3টা Panel position
            panelSelun.Location = new Point(startX, 120);

            panelBeuaty.Location = new Point(
                panelSelun.Right + gap,
                120
            );

            panel3.Location = new Point(
                panelBeuaty.Right + gap,
                120
            );

            // Dashboard title center
            guna2HtmlLabel1.Left =
                (this.ClientSize.Width - guna2HtmlLabel1.Width) / 2;

            // Serial Details button center
            btnSerialdetail.Left =
                (this.ClientSize.Width - btnSerialdetail.Width) / 2;

            btnSerialdetail.Top = panelSelun.Bottom + 40;
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
