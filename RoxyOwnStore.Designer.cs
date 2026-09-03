//namespace Multi_Booking_System
//{
//    partial class RoxyOwnStore
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
//            this.Text = "RoxyOwnStore";
//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class RoxyOwnStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdd = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxServiceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.panelUpdateDelete = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelUpdateTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxUD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxUName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxUService = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panelGrid = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.gridviewShowService = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnShow = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.panelAdd.SuspendLayout();
            this.panelUpdateDelete.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewShowService)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roxy Store Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Transparent;
            this.panelAdd.Controls.Add(this.labelAddTitle);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.txtboxServiceName);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.txtboxPrice);
            this.panelAdd.Controls.Add(this.btnAddService);
            this.panelAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panelAdd.Location = new System.Drawing.Point(30, 520);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Radius = 15;
            this.panelAdd.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelAdd.ShadowDepth = 20;
            this.panelAdd.ShadowShift = 6;
            this.panelAdd.Size = new System.Drawing.Size(500, 240);
            this.panelAdd.TabIndex = 1;
            // 
            // labelAddTitle
            // 
            this.labelAddTitle.AutoSize = true;
            this.labelAddTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelAddTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddTitle.Location = new System.Drawing.Point(20, 20);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.Size = new System.Drawing.Size(240, 38);
            this.labelAddTitle.TabIndex = 2;
            this.labelAddTitle.Text = "Add New Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service Name";
            // 
            // txtboxServiceName
            // 
            this.txtboxServiceName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.txtboxServiceName.BorderRadius = 8;
            this.txtboxServiceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxServiceName.DefaultText = "";
            this.txtboxServiceName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.txtboxServiceName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtboxServiceName.ForeColor = System.Drawing.Color.White;
            this.txtboxServiceName.Location = new System.Drawing.Point(26, 97);
            this.txtboxServiceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxServiceName.Name = "txtboxServiceName";
            this.txtboxServiceName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.txtboxServiceName.PlaceholderText = "Enter Service Name";
            this.txtboxServiceName.SelectedText = "";
            this.txtboxServiceName.Size = new System.Drawing.Size(448, 45);
            this.txtboxServiceName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(22, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.txtboxPrice.BorderRadius = 8;
            this.txtboxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPrice.DefaultText = "";
            this.txtboxPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.txtboxPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtboxPrice.ForeColor = System.Drawing.Color.White;
            this.txtboxPrice.Location = new System.Drawing.Point(26, 177);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.txtboxPrice.PlaceholderText = "0.00";
            this.txtboxPrice.SelectedText = "";
            this.txtboxPrice.Size = new System.Drawing.Size(260, 45);
            this.txtboxPrice.TabIndex = 6;
            // 
            // btnAddService
            // 
            this.btnAddService.Animated = true;
            this.btnAddService.BorderRadius = 8;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddService.ForeColor = System.Drawing.Color.Black;
            this.btnAddService.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnAddService.Location = new System.Drawing.Point(314, 177);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(160, 45);
            this.btnAddService.TabIndex = 7;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // panelUpdateDelete
            // 
            this.panelUpdateDelete.BackColor = System.Drawing.Color.Transparent;
            this.panelUpdateDelete.Controls.Add(this.labelUpdateTitle);
            this.panelUpdateDelete.Controls.Add(this.label5);
            this.panelUpdateDelete.Controls.Add(this.txtboxUD);
            this.panelUpdateDelete.Controls.Add(this.label6);
            this.panelUpdateDelete.Controls.Add(this.txtboxUName);
            this.panelUpdateDelete.Controls.Add(this.label7);
            this.panelUpdateDelete.Controls.Add(this.txtboxUService);
            this.panelUpdateDelete.Controls.Add(this.btnUpdate);
            this.panelUpdateDelete.Controls.Add(this.btnDelete);
            this.panelUpdateDelete.FillColor = System.Drawing.Color.White;
            this.panelUpdateDelete.Location = new System.Drawing.Point(560, 520);
            this.panelUpdateDelete.Name = "panelUpdateDelete";
            this.panelUpdateDelete.Radius = 15;
            this.panelUpdateDelete.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelUpdateDelete.ShadowDepth = 20;
            this.panelUpdateDelete.ShadowShift = 6;
            this.panelUpdateDelete.Size = new System.Drawing.Size(700, 240);
            this.panelUpdateDelete.TabIndex = 8;
            // 
            // labelUpdateTitle
            // 
            this.labelUpdateTitle.AutoSize = true;
            this.labelUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.labelUpdateTitle.Location = new System.Drawing.Point(20, 20);
            this.labelUpdateTitle.Name = "labelUpdateTitle";
            this.labelUpdateTitle.Size = new System.Drawing.Size(327, 38);
            this.labelUpdateTitle.TabIndex = 9;
            this.labelUpdateTitle.Text = "Update / Delete Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(22, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Service ID";
            // 
            // txtboxUD
            // 
            this.txtboxUD.BorderRadius = 8;
            this.txtboxUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUD.DefaultText = "";
            this.txtboxUD.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtboxUD.Location = new System.Drawing.Point(26, 97);
            this.txtboxUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxUD.Name = "txtboxUD";
            this.txtboxUD.PlaceholderText = "ID";
            this.txtboxUD.SelectedText = "";
            this.txtboxUD.Size = new System.Drawing.Size(150, 45);
            this.txtboxUD.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(192, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "New Service Name";
            // 
            // txtboxUName
            // 
            this.txtboxUName.BorderRadius = 8;
            this.txtboxUName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUName.DefaultText = "";
            this.txtboxUName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtboxUName.Location = new System.Drawing.Point(196, 97);
            this.txtboxUName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxUName.Name = "txtboxUName";
            this.txtboxUName.PlaceholderText = "Enter Name";
            this.txtboxUName.SelectedText = "";
            this.txtboxUName.Size = new System.Drawing.Size(250, 45);
            this.txtboxUName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(462, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "New Price";
            // 
            // txtboxUService
            // 
            this.txtboxUService.BorderRadius = 8;
            this.txtboxUService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUService.DefaultText = "";
            this.txtboxUService.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtboxUService.Location = new System.Drawing.Point(466, 97);
            this.txtboxUService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxUService.Name = "txtboxUService";
            this.txtboxUService.PlaceholderText = "0.00";
            this.txtboxUService.SelectedText = "";
            this.txtboxUService.Size = new System.Drawing.Size(208, 45);
            this.txtboxUService.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnUpdate.Location = new System.Drawing.Point(344, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 45);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Location = new System.Drawing.Point(514, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 45);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.label4);
            this.panelGrid.Controls.Add(this.gridviewShowService);
            this.panelGrid.Controls.Add(this.BtnShow);
            this.panelGrid.FillColor = System.Drawing.Color.White;
            this.panelGrid.Location = new System.Drawing.Point(30, 85);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Radius = 15;
            this.panelGrid.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelGrid.ShadowDepth = 30;
            this.panelGrid.ShadowShift = 6;
            this.panelGrid.Size = new System.Drawing.Size(1230, 420);
            this.panelGrid.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 38);
            this.label4.TabIndex = 19;
            this.label4.Text = "Available Services";
            // 
            // gridviewShowService
            // 
            this.gridviewShowService.AllowUserToAddRows = false;
            this.gridviewShowService.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridviewShowService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewShowService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewShowService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewShowService.ColumnHeadersHeight = 50;
            this.gridviewShowService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewShowService.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewShowService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridviewShowService.Location = new System.Drawing.Point(26, 61);
            this.gridviewShowService.Name = "gridviewShowService";
            this.gridviewShowService.ReadOnly = true;
            this.gridviewShowService.RowHeadersVisible = false;
            this.gridviewShowService.RowHeadersWidth = 51;
            this.gridviewShowService.RowTemplate.Height = 45;
            this.gridviewShowService.Size = new System.Drawing.Size(1178, 283);
            this.gridviewShowService.TabIndex = 20;
            this.gridviewShowService.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridviewShowService.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.gridviewShowService.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.gridviewShowService.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gridviewShowService.ThemeStyle.HeaderStyle.Height = 50;
            this.gridviewShowService.ThemeStyle.ReadOnly = true;
            this.gridviewShowService.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.gridviewShowService.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridviewShowService.ThemeStyle.RowsStyle.Height = 45;
            this.gridviewShowService.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.gridviewShowService.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridviewShowService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewShowService_CellContentClick);
            // 
            // BtnShow
            // 
            this.BtnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnShow.Animated = true;
            this.BtnShow.BorderRadius = 8;
            this.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.BtnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnShow.ForeColor = System.Drawing.Color.White;
            this.BtnShow.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.BtnShow.Location = new System.Drawing.Point(26, 350);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(220, 45);
            this.BtnShow.TabIndex = 21;
            this.BtnShow.Text = "Show Service";
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Animated = true;
            this.btnNext.BorderRadius = 8;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(1137, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 45);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Animated = true;
            this.btnLogOut.BorderRadius = 8;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(944, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 45);
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // RoxyOwnStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1290, 800);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelUpdateDelete);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Name = "RoxyOwnStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roxy Own Store";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelUpdateDelete.ResumeLayout(false);
            this.panelUpdateDelete.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewShowService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelAdd;
        private System.Windows.Forms.Label labelAddTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private Guna.UI2.WinForms.Guna2TextBox txtboxServiceName;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPrice;

        private Guna.UI2.WinForms.Guna2Button btnAddService;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelUpdateDelete;
        private System.Windows.Forms.Label labelUpdateTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private Guna.UI2.WinForms.Guna2TextBox txtboxUD;
        private Guna.UI2.WinForms.Guna2TextBox txtboxUName;
        private Guna.UI2.WinForms.Guna2TextBox txtboxUService;

        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelGrid;
        private System.Windows.Forms.Label label4;

        private Guna.UI2.WinForms.Guna2DataGridView gridviewShowService;

        private Guna.UI2.WinForms.Guna2Button BtnShow;

        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
    }
}