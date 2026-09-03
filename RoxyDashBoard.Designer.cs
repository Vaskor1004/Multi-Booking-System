//namespace Multi_Booking_System
//{
//    partial class RoxyDashBoard
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
//            this.Text = "RoxyDashBoard";
//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class RoxyDashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.BtnShowServiceRoxy = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookSerial = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gridViewRoxyStore = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHeader1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gridViewSelectedServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHeader2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoxyStore)).BeginInit();
            this.panelHeader1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedServices)).BeginInit();
            this.panelHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.labelTitle);
            this.guna2Panel1.Controls.Add(this.BtnShowServiceRoxy);
            this.guna2Panel1.Controls.Add(this.btnAddService);
            this.guna2Panel1.Controls.Add(this.btnBookSerial);
            this.guna2Panel1.Controls.Add(this.btnLogOut);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.guna2Panel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.guna2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(260, 600);
            this.guna2Panel1.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(21, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(174, 41);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Roxy Dash";
            // 
            // BtnShowServiceRoxy
            // 
            this.BtnShowServiceRoxy.Animated = true;
            this.BtnShowServiceRoxy.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowServiceRoxy.BorderRadius = 15;
            this.BtnShowServiceRoxy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnShowServiceRoxy.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnShowServiceRoxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowServiceRoxy.FillColor = System.Drawing.Color.Transparent;
            this.BtnShowServiceRoxy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnShowServiceRoxy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnShowServiceRoxy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnShowServiceRoxy.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnShowServiceRoxy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnShowServiceRoxy.Location = new System.Drawing.Point(20, 110);
            this.BtnShowServiceRoxy.Name = "BtnShowServiceRoxy";
            this.BtnShowServiceRoxy.Size = new System.Drawing.Size(220, 50);
            this.BtnShowServiceRoxy.TabIndex = 0;
            this.BtnShowServiceRoxy.Text = "Show Service";
            this.BtnShowServiceRoxy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnShowServiceRoxy.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnShowServiceRoxy.Click += new System.EventHandler(this.BtnShowServiceRoxy_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Animated = true;
            this.btnAddService.BackColor = System.Drawing.Color.Transparent;
            this.btnAddService.BorderRadius = 15;
            this.btnAddService.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddService.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.FillColor = System.Drawing.Color.Transparent;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddService.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddService.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddService.Location = new System.Drawing.Point(20, 175);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(220, 50);
            this.btnAddService.TabIndex = 1;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddService.TextOffset = new System.Drawing.Point(10, 0);
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnBookSerial
            // 
            this.btnBookSerial.Animated = true;
            this.btnBookSerial.BackColor = System.Drawing.Color.Transparent;
            this.btnBookSerial.BorderRadius = 15;
            this.btnBookSerial.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBookSerial.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBookSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookSerial.FillColor = System.Drawing.Color.Transparent;
            this.btnBookSerial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBookSerial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookSerial.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBookSerial.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBookSerial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookSerial.Location = new System.Drawing.Point(20, 240);
            this.btnBookSerial.Name = "btnBookSerial";
            this.btnBookSerial.Size = new System.Drawing.Size(220, 50);
            this.btnBookSerial.TabIndex = 4;
            this.btnBookSerial.Text = "Book Serial";
            this.btnBookSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookSerial.TextOffset = new System.Drawing.Point(10, 0);
            this.btnBookSerial.Click += new System.EventHandler(this.btnBookSerial_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.Animated = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderRadius = 15;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLogOut.Location = new System.Drawing.Point(20, 520);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 50);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.gridViewRoxyStore);
            this.guna2ShadowPanel1.Controls.Add(this.panelHeader1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(290, 30);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.guna2ShadowPanel1.ShadowDepth = 60;
            this.guna2ShadowPanel1.ShadowShift = 6;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(670, 250);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // gridViewRoxyStore
            // 
            this.gridViewRoxyStore.AllowUserToAddRows = false;
            this.gridViewRoxyStore.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridViewRoxyStore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gridViewRoxyStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewRoxyStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridViewRoxyStore.ColumnHeadersHeight = 45;
            this.gridViewRoxyStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewRoxyStore.DefaultCellStyle = dataGridViewCellStyle15;
            this.gridViewRoxyStore.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridViewRoxyStore.Location = new System.Drawing.Point(20, 60);
            this.gridViewRoxyStore.Name = "gridViewRoxyStore";
            this.gridViewRoxyStore.ReadOnly = true;
            this.gridViewRoxyStore.RowHeadersVisible = false;
            this.gridViewRoxyStore.RowHeadersWidth = 51;
            this.gridViewRoxyStore.RowTemplate.Height = 45;
            this.gridViewRoxyStore.Size = new System.Drawing.Size(630, 170);
            this.gridViewRoxyStore.TabIndex = 2;
            this.gridViewRoxyStore.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridViewRoxyStore.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridViewRoxyStore.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridViewRoxyStore.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.gridViewRoxyStore.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gridViewRoxyStore.ThemeStyle.HeaderStyle.Height = 45;
            this.gridViewRoxyStore.ThemeStyle.ReadOnly = true;
            this.gridViewRoxyStore.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gridViewRoxyStore.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridViewRoxyStore.ThemeStyle.RowsStyle.Height = 45;
            this.gridViewRoxyStore.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.gridViewRoxyStore.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            // 
            // panelHeader1
            // 
            this.panelHeader1.BorderRadius = 15;
            this.panelHeader1.Controls.Add(this.label1);
            this.panelHeader1.CustomizableEdges.BottomLeft = false;
            this.panelHeader1.CustomizableEdges.BottomRight = false;
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.panelHeader1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.panelHeader1.Location = new System.Drawing.Point(0, 0);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(670, 45);
            this.panelHeader1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available Services";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.gridViewSelectedServices);
            this.guna2ShadowPanel2.Controls.Add(this.panelHeader2);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(290, 300);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 15;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.guna2ShadowPanel2.ShadowDepth = 60;
            this.guna2ShadowPanel2.ShadowShift = 6;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(670, 270);
            this.guna2ShadowPanel2.TabIndex = 8;
            // 
            // gridViewSelectedServices
            // 
            this.gridViewSelectedServices.AllowUserToAddRows = false;
            this.gridViewSelectedServices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.gridViewSelectedServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gridViewSelectedServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSelectedServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gridViewSelectedServices.ColumnHeadersHeight = 45;
            this.gridViewSelectedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSelectedServices.DefaultCellStyle = dataGridViewCellStyle18;
            this.gridViewSelectedServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.gridViewSelectedServices.Location = new System.Drawing.Point(20, 60);
            this.gridViewSelectedServices.Name = "gridViewSelectedServices";
            this.gridViewSelectedServices.ReadOnly = true;
            this.gridViewSelectedServices.RowHeadersVisible = false;
            this.gridViewSelectedServices.RowHeadersWidth = 51;
            this.gridViewSelectedServices.RowTemplate.Height = 45;
            this.gridViewSelectedServices.Size = new System.Drawing.Size(630, 190);
            this.gridViewSelectedServices.TabIndex = 3;
            this.gridViewSelectedServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.gridViewSelectedServices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.gridViewSelectedServices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.gridViewSelectedServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.gridViewSelectedServices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gridViewSelectedServices.ThemeStyle.HeaderStyle.Height = 45;
            this.gridViewSelectedServices.ThemeStyle.ReadOnly = true;
            this.gridViewSelectedServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gridViewSelectedServices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridViewSelectedServices.ThemeStyle.RowsStyle.Height = 45;
            this.gridViewSelectedServices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.gridViewSelectedServices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            // 
            // panelHeader2
            // 
            this.panelHeader2.BorderRadius = 15;
            this.panelHeader2.Controls.Add(this.label2);
            this.panelHeader2.CustomizableEdges.BottomLeft = false;
            this.panelHeader2.CustomizableEdges.BottomRight = false;
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.panelHeader2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.panelHeader2.Location = new System.Drawing.Point(0, 0);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(670, 45);
            this.panelHeader2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Services";
            // 
            // RoxyDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "RoxyDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roxy Dashboard";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoxyStore)).EndInit();
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedServices)).EndInit();
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnShowServiceRoxy;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Guna.UI2.WinForms.Guna2Button btnBookSerial;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;

        private Guna.UI2.WinForms.Guna2GradientPanel guna2Panel1;
        private System.Windows.Forms.Label labelTitle;

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewRoxyStore;

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewSelectedServices;
    }
}


