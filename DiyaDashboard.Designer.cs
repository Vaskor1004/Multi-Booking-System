//namespace Multi_Booking_System
//{
//    partial class DiyaDashboard
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
//            this.Text = "DiyaDashboard";
//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class DiyaDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.BtnShowServiceDiya = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookSerial = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gridViewDiyaStore = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHeader1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gridViewSelectedServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHeader2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiyaStore)).BeginInit();
            this.panelHeader1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedServices)).BeginInit();
            this.panelHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Controls.Add(this.labelTitle);
            this.guna2Panel1.Controls.Add(this.BtnShowServiceDiya);
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
            this.labelTitle.Size = new System.Drawing.Size(165, 41);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Diya Dash";
            // 
            // BtnShowServiceDiya
            // 
            this.BtnShowServiceDiya.Animated = true;
            this.BtnShowServiceDiya.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowServiceDiya.BorderRadius = 15;
            this.BtnShowServiceDiya.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnShowServiceDiya.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnShowServiceDiya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowServiceDiya.FillColor = System.Drawing.Color.Transparent;
            this.BtnShowServiceDiya.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowServiceDiya.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnShowServiceDiya.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnShowServiceDiya.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnShowServiceDiya.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnShowServiceDiya.Location = new System.Drawing.Point(20, 150);
            this.BtnShowServiceDiya.Name = "BtnShowServiceDiya";
            this.BtnShowServiceDiya.Size = new System.Drawing.Size(220, 50);
            this.BtnShowServiceDiya.TabIndex = 0;
            this.BtnShowServiceDiya.Text = "Show Service";
            this.BtnShowServiceDiya.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnShowServiceDiya.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnShowServiceDiya.Click += new System.EventHandler(this.BtnShowServiceDiya_Click);
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
            this.btnAddService.Location = new System.Drawing.Point(484, 7);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(166, 31);
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
            this.btnBookSerial.Location = new System.Drawing.Point(484, 3);
            this.btnBookSerial.Name = "btnBookSerial";
            this.btnBookSerial.Size = new System.Drawing.Size(166, 35);
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
            this.btnLogOut.Text = "Back";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.gridViewDiyaStore);
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
            // gridViewDiyaStore
            // 
            this.gridViewDiyaStore.AllowUserToAddRows = false;
            this.gridViewDiyaStore.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridViewDiyaStore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewDiyaStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewDiyaStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewDiyaStore.ColumnHeadersHeight = 45;
            this.gridViewDiyaStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewDiyaStore.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewDiyaStore.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridViewDiyaStore.Location = new System.Drawing.Point(20, 60);
            this.gridViewDiyaStore.Name = "gridViewDiyaStore";
            this.gridViewDiyaStore.ReadOnly = true;
            this.gridViewDiyaStore.RowHeadersVisible = false;
            this.gridViewDiyaStore.RowHeadersWidth = 51;
            this.gridViewDiyaStore.RowTemplate.Height = 45;
            this.gridViewDiyaStore.Size = new System.Drawing.Size(630, 170);
            this.gridViewDiyaStore.TabIndex = 2;
            this.gridViewDiyaStore.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridViewDiyaStore.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridViewDiyaStore.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridViewDiyaStore.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.gridViewDiyaStore.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gridViewDiyaStore.ThemeStyle.HeaderStyle.Height = 45;
            this.gridViewDiyaStore.ThemeStyle.ReadOnly = true;
            this.gridViewDiyaStore.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gridViewDiyaStore.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridViewDiyaStore.ThemeStyle.RowsStyle.Height = 45;
            this.gridViewDiyaStore.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.gridViewDiyaStore.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            // 
            // panelHeader1
            // 
            this.panelHeader1.BorderRadius = 15;
            this.panelHeader1.Controls.Add(this.label1);
            this.panelHeader1.Controls.Add(this.btnAddService);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.gridViewSelectedServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewSelectedServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSelectedServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewSelectedServices.ColumnHeadersHeight = 45;
            this.gridViewSelectedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSelectedServices.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.panelHeader2.Controls.Add(this.btnBookSerial);
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
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Animated = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDelete.Location = new System.Drawing.Point(20, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 50);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Service";
            // 
            // DiyaDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DiyaDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diya Dashboard";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiyaStore)).EndInit();
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedServices)).EndInit();
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnShowServiceDiya;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Guna.UI2.WinForms.Guna2Button btnBookSerial;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;

        private Guna.UI2.WinForms.Guna2GradientPanel guna2Panel1;
        private System.Windows.Forms.Label labelTitle;

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewDiyaStore;

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewSelectedServices;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}