//namespace Multi_Booking_System
//{
//    partial class RoxyHomeApprove
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
//            this.SuspendLayout();
//            // 
//            // RoxyHomeApprove
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1285, 605);
//            this.Name = "RoxyHomeApprove";
//            this.Text = "RoxyHomeApprove";
//            this.ResumeLayout(false);

//        }

//        #endregion
//    }
//}


namespace Multi_Booking_System
{
    partial class RoxyHomeApprove
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.panelBookings = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.headerBookings = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelBookingsTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridViewRoxyHomeBooking = new Guna.UI2.WinForms.Guna2DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoxyHomeBooking)).BeginInit();
            this.panelAction.SuspendLayout();
            this.headerAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
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
            this.panelBookings.Controls.Add(this.gridViewRoxyHomeBooking);
            this.panelBookings.FillColor = System.Drawing.Color.White;
            this.panelBookings.Location = new System.Drawing.Point(35, 105);
            this.panelBookings.Name = "panelBookings";
            this.panelBookings.Radius = 18;
            this.panelBookings.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
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
            this.headerBookings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.headerBookings.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
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
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.btnRefresh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(875, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(210, 45);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "↻  Refresh Bookings";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridViewRoxyHomeBooking
            // 
            this.gridViewRoxyHomeBooking.AllowUserToAddRows = false;
            this.gridViewRoxyHomeBooking.AllowUserToDeleteRows = false;
            this.gridViewRoxyHomeBooking.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.gridViewRoxyHomeBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewRoxyHomeBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewRoxyHomeBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewRoxyHomeBooking.ColumnHeadersHeight = 52;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewRoxyHomeBooking.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewRoxyHomeBooking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.gridViewRoxyHomeBooking.Location = new System.Drawing.Point(25, 92);
            this.gridViewRoxyHomeBooking.Name = "gridViewRoxyHomeBooking";
            this.gridViewRoxyHomeBooking.ReadOnly = true;
            this.gridViewRoxyHomeBooking.RowHeadersVisible = false;
            this.gridViewRoxyHomeBooking.RowHeadersWidth = 51;
            this.gridViewRoxyHomeBooking.RowTemplate.Height = 45;
            this.gridViewRoxyHomeBooking.Size = new System.Drawing.Size(1060, 285);
            this.gridViewRoxyHomeBooking.TabIndex = 3;
            this.gridViewRoxyHomeBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.gridViewRoxyHomeBooking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.gridViewRoxyHomeBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.gridViewRoxyHomeBooking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gridViewRoxyHomeBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewRoxyHomeBooking.ThemeStyle.HeaderStyle.Height = 52;
            this.gridViewRoxyHomeBooking.ThemeStyle.ReadOnly = true;
            this.gridViewRoxyHomeBooking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViewRoxyHomeBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gridViewRoxyHomeBooking.ThemeStyle.RowsStyle.Height = 45;
            this.gridViewRoxyHomeBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(250)))));
            this.gridViewRoxyHomeBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gridViewRoxyHomeBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRoxyHomeBooking_CellContentClick);
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
            this.panelAction.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
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
            this.headerAction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.headerAction.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(176)))));
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
            this.btnApprove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnApprove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.btnApprove.Location = new System.Drawing.Point(490, 70);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(190, 45);
            this.btnApprove.TabIndex = 8;
            this.btnApprove.Text = "✓  Approve Booking";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
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
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.btnNext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1050, 700);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 40);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next →";
            // 
            // RoxyHomeApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1180, 760);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelBookings);
            this.Controls.Add(this.labelMainTitle);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "RoxyHomeApprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roxy Home Service - Approve Bookings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBookings.ResumeLayout(false);
            this.headerBookings.ResumeLayout(false);
            this.headerBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoxyHomeBooking)).EndInit();
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

        private Guna.UI2.WinForms.Guna2DataGridView gridViewRoxyHomeBooking;

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
