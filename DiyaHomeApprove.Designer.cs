//namespace Multi_Booking_System
//{
//    partial class DiyaHomeApprove
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "DiyaHomeApprove";
//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class DiyaHomeApprove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.panelBookings = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.headerBookings = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelBookingsTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridViewDiyaHomeBooking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelAction = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.headerAction = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelActionTitle = new System.Windows.Forms.Label();
            this.labelBookingId = new System.Windows.Forms.Label();
            this.txtBookingId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnApprove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelBookings.SuspendLayout();
            this.headerBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiyaHomeBooking)).BeginInit();
            this.panelAction.SuspendLayout();
            this.headerAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153))))); // Pink Accent
            this.labelMainTitle.Location = new System.Drawing.Point(35, 25);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(548, 57);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Approve Home Bookings";
            // 
            // panelBookings
            // 
            this.panelBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookings.BackColor = System.Drawing.Color.Transparent;
            this.panelBookings.Controls.Add(this.headerBookings);
            this.panelBookings.Controls.Add(this.gridViewDiyaHomeBooking);
            this.panelBookings.FillColor = System.Drawing.Color.White;
            this.panelBookings.Location = new System.Drawing.Point(35, 105);
            this.panelBookings.Name = "panelBookings";
            this.panelBookings.Radius = 18;
            this.panelBookings.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.panelBookings.ShadowDepth = 35;
            this.panelBookings.ShadowShift = 6;
            this.panelBookings.Size = new System.Drawing.Size(1110, 405);
            this.panelBookings.TabIndex = 1;
            // 
            // headerBookings
            // 
            this.headerBookings.BorderRadius = 18;
            this.headerBookings.Controls.Add(this.labelBookingsTitle);
            this.headerBookings.Controls.Add(this.btnRefresh);
            this.headerBookings.CustomizableEdges.BottomLeft = false;
            this.headerBookings.CustomizableEdges.BottomRight = false;
            this.headerBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBookings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153))))); // Pink Accent
            this.headerBookings.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(182)))));
            this.headerBookings.Location = new System.Drawing.Point(0, 0);
            this.headerBookings.Name = "headerBookings";
            this.headerBookings.Size = new System.Drawing.Size(1110, 72);
            this.headerBookings.TabIndex = 2;
            // 
            // labelBookingsTitle
            // 
            this.labelBookingsTitle.AutoSize = true;
            this.labelBookingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelBookingsTitle.ForeColor = System.Drawing.Color.White;
            this.labelBookingsTitle.Location = new System.Drawing.Point(22, 17);
            this.labelBookingsTitle.Name = "labelBookingsTitle";
            this.labelBookingsTitle.Size = new System.Drawing.Size(221, 37);
            this.labelBookingsTitle.TabIndex = 0;
            this.labelBookingsTitle.Text = "Home Bookings";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 9;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247))))); // Purple Accent
            this.btnRefresh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(875, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(210, 45);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "↻ Serial Details";
            // 
            // gridViewDiyaHomeBooking
            // 
            this.gridViewDiyaHomeBooking.AllowUserToAddRows = false;
            this.gridViewDiyaHomeBooking.AllowUserToDeleteRows = false;
            this.gridViewDiyaHomeBooking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(248))))); // Very light pink
            this.gridViewDiyaHomeBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewDiyaHomeBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153))))); // Pink header
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewDiyaHomeBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewDiyaHomeBooking.ColumnHeadersHeight = 52;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewDiyaHomeBooking.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewDiyaHomeBooking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.gridViewDiyaHomeBooking.Location = new System.Drawing.Point(25, 92);
            this.gridViewDiyaHomeBooking.Name = "gridViewDiyaHomeBooking";
            this.gridViewDiyaHomeBooking.ReadOnly = true;
            this.gridViewDiyaHomeBooking.RowHeadersVisible = false;
            this.gridViewDiyaHomeBooking.RowHeadersWidth = 51;
            this.gridViewDiyaHomeBooking.RowTemplate.Height = 45;
            this.gridViewDiyaHomeBooking.Size = new System.Drawing.Size(1060, 285);
            this.gridViewDiyaHomeBooking.TabIndex = 3;
            this.gridViewDiyaHomeBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.gridViewDiyaHomeBooking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.gridViewDiyaHomeBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.gridViewDiyaHomeBooking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gridViewDiyaHomeBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewDiyaHomeBooking.ThemeStyle.HeaderStyle.Height = 52;
            this.gridViewDiyaHomeBooking.ThemeStyle.ReadOnly = true;
            this.gridViewDiyaHomeBooking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViewDiyaHomeBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gridViewDiyaHomeBooking.ThemeStyle.RowsStyle.Height = 45;
            this.gridViewDiyaHomeBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.gridViewDiyaHomeBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // panelAction
            // 
            this.panelAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAction.BackColor = System.Drawing.Color.Transparent;
            this.panelAction.Controls.Add(this.headerAction);
            this.panelAction.Controls.Add(this.labelBookingId);
            this.panelAction.Controls.Add(this.txtBookingId);
            this.panelAction.Controls.Add(this.btnApprove);
            this.panelAction.FillColor = System.Drawing.Color.White;
            this.panelAction.Location = new System.Drawing.Point(35, 530);
            this.panelAction.Name = "panelAction";
            this.panelAction.Radius = 18;
            this.panelAction.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.panelAction.ShadowDepth = 35;
            this.panelAction.ShadowShift = 6;
            this.panelAction.Size = new System.Drawing.Size(1110, 145);
            this.panelAction.TabIndex = 4;
            // 
            // headerAction
            // 
            this.headerAction.BorderRadius = 18;
            this.headerAction.Controls.Add(this.labelActionTitle);
            this.headerAction.CustomizableEdges.BottomLeft = false;
            this.headerAction.CustomizableEdges.BottomRight = false;
            this.headerAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerAction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233))))); // Sky Blue
            this.headerAction.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.headerAction.Location = new System.Drawing.Point(0, 0);
            this.headerAction.Name = "headerAction";
            this.headerAction.Size = new System.Drawing.Size(1110, 48);
            this.headerAction.TabIndex = 5;
            // 
            // labelActionTitle
            // 
            this.labelActionTitle.AutoSize = true;
            this.labelActionTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelActionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelActionTitle.ForeColor = System.Drawing.Color.White;
            this.labelActionTitle.Location = new System.Drawing.Point(22, 9);
            this.labelActionTitle.Name = "labelActionTitle";
            this.labelActionTitle.Size = new System.Drawing.Size(158, 28);
            this.labelActionTitle.TabIndex = 0;
            this.labelActionTitle.Text = "Booking Action";
            // 
            // labelBookingId
            // 
            this.labelBookingId.AutoSize = true;
            this.labelBookingId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelBookingId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.labelBookingId.Location = new System.Drawing.Point(25, 82);
            this.labelBookingId.Name = "labelBookingId";
            this.labelBookingId.Size = new System.Drawing.Size(119, 28);
            this.labelBookingId.TabIndex = 6;
            this.labelBookingId.Text = "Booking ID:";
            // 
            // txtBookingId
            // 
            this.txtBookingId.BorderRadius = 9;
            this.txtBookingId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingId.DefaultText = "";
            this.txtBookingId.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.txtBookingId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtBookingId.Location = new System.Drawing.Point(175, 70);
            this.txtBookingId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.PlaceholderText = "Select a booking from the table";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.SelectedText = "";
            this.txtBookingId.Size = new System.Drawing.Size(290, 45);
            this.txtBookingId.TabIndex = 7;
            // 
            // btnApprove
            // 
            this.btnApprove.Animated = true;
            this.btnApprove.BorderRadius = 9;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))); // Emerald Green
            this.btnApprove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnApprove.Location = new System.Drawing.Point(490, 70);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(190, 45);
            this.btnApprove.TabIndex = 8;
            this.btnApprove.Text = "✓  Approve Booking";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 8;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(950, 700);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "← Back";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Animated = true;
            this.btnNext.BorderRadius = 8;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153))))); // Pink Accent
            this.btnNext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(182)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1050, 700);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 40);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next →";
            // 
            // DiyaHomeApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252))))); // Soft Grayish Blue
            this.ClientSize = new System.Drawing.Size(1180, 760);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelBookings);
            this.Controls.Add(this.labelMainTitle);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "DiyaHomeApprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diya Home Service - Approve Bookings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBookings.ResumeLayout(false);
            this.headerBookings.ResumeLayout(false);
            this.headerBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiyaHomeBooking)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.headerAction.ResumeLayout(false);
            this.headerAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelBookings;
        private Guna.UI2.WinForms.Guna2GradientPanel headerBookings;
        private System.Windows.Forms.Label labelBookingsTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefresh;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewDiyaHomeBooking;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelAction;
        private Guna.UI2.WinForms.Guna2GradientPanel headerAction;
        private System.Windows.Forms.Label labelActionTitle;
        private System.Windows.Forms.Label labelBookingId;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingId;
        private Guna.UI2.WinForms.Guna2GradientButton btnApprove;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
    }
}