//namespace Multi_Booking_System
//{
//    partial class AdminMainPage
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
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.gridViewUsers = new System.Windows.Forms.DataGridView();
//            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
//            this.label3 = new System.Windows.Forms.Label();
//            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
//            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
//            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.Location = new System.Drawing.Point(301, 9);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(213, 39);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Admin Page";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
//            this.label2.Location = new System.Drawing.Point(41, 108);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(156, 29);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "User Details";
//            // 
//            // gridViewUsers
//            // 
//            this.gridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.gridViewUsers.Location = new System.Drawing.Point(46, 156);
//            this.gridViewUsers.Name = "gridViewUsers";
//            this.gridViewUsers.RowHeadersWidth = 51;
//            this.gridViewUsers.RowTemplate.Height = 24;
//            this.gridViewUsers.Size = new System.Drawing.Size(591, 253);
//            this.gridViewUsers.TabIndex = 2;
//            // 
//            // btnShow
//            // 
//            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
//            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
//            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
//            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
//            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnShow.ForeColor = System.Drawing.Color.White;
//            this.btnShow.Location = new System.Drawing.Point(46, 451);
//            this.btnShow.Name = "btnShow";
//            this.btnShow.Size = new System.Drawing.Size(180, 45);
//            this.btnShow.TabIndex = 3;
//            this.btnShow.Text = "Show Details";
//            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.Location = new System.Drawing.Point(690, 94);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(144, 25);
//            this.label3.TabIndex = 4;
//            this.label3.Text = "Go    to   Next";
//            // 
//            // guna2Button1
//            // 
//            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
//            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
//            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
//            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
//            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.guna2Button1.ForeColor = System.Drawing.Color.White;
//            this.guna2Button1.Location = new System.Drawing.Point(663, 138);
//            this.guna2Button1.Name = "guna2Button1";
//            this.guna2Button1.Size = new System.Drawing.Size(196, 50);
//            this.guna2Button1.TabIndex = 5;
//            this.guna2Button1.Text = "See Shpokeepers";
//            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
//            // 
//            // btnLogOut
//            // 
//            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
//            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
//            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
//            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
//            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnLogOut.ForeColor = System.Drawing.Color.White;
//            this.btnLogOut.Location = new System.Drawing.Point(695, 521);
//            this.btnLogOut.Name = "btnLogOut";
//            this.btnLogOut.Size = new System.Drawing.Size(148, 45);
//            this.btnLogOut.TabIndex = 6;
//            this.btnLogOut.Text = "Log Out";
//            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
//            // 
//            // AdminMainPage
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(871, 595);
//            this.Controls.Add(this.btnLogOut);
//            this.Controls.Add(this.guna2Button1);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.btnShow);
//            this.Controls.Add(this.gridViewUsers);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Name = "AdminMainPage";
//            this.Text = "AdminMainPage";
//            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.DataGridView gridViewUsers;
//        private Guna.UI2.WinForms.Guna2Button btnShow;
//        private System.Windows.Forms.Label label3;
//        private Guna.UI2.WinForms.Guna2Button guna2Button1;
//        private Guna.UI2.WinForms.Guna2Button btnLogOut;
//    }
//}

namespace Multi_Booking_System
{
    partial class AdminMainPage
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

            this.tableLayoutPanelRoot = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.guna2PanelCard = new Guna.UI2.WinForms.Guna2Panel();

            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();

            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2GradientButton(); // Upgraded to Gradient
            this.gridViewUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnShow = new Guna.UI2.WinForms.Guna2GradientButton(); // Upgraded to Gradient

            this.tableLayoutPanelRoot.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.guna2PanelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            this.SuspendLayout();

            // 
            // tableLayoutPanelRoot (Main Responsive Framework)
            // 
            this.tableLayoutPanelRoot.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelRoot.ColumnCount = 1;
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRoot.Controls.Add(this.panelTopBar, 0, 0);
            this.tableLayoutPanelRoot.Controls.Add(this.guna2PanelCard, 0, 1);
            this.tableLayoutPanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRoot.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRoot.Name = "tableLayoutPanelRoot";
            this.tableLayoutPanelRoot.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.tableLayoutPanelRoot.RowCount = 2;
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRoot.Size = new System.Drawing.Size(1100, 700);
            this.tableLayoutPanelRoot.TabIndex = 0;

            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.label1);
            this.panelTopBar.Controls.Add(this.btnLogOut);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopBar.Location = new System.Drawing.Point(30, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1040, 90);
            this.panelTopBar.TabIndex = 0;

            // 
            // label1 (Admin Page Title)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White; // Crisp white for dark mode
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Control Panel";

            // 
            // btnLogOut (Dark Mode Danger Outline Button)
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Animated = true;
            this.btnLogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68))))); // Red 500
            this.btnLogOut.BorderRadius = 8;
            this.btnLogOut.BorderThickness = 2;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29))))); // Dark Red hover
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(890, 25);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 45);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);

            // 
            // guna2PanelCard (Elevated Dark Slate Card)
            // 
            this.guna2PanelCard.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard.BorderRadius = 16;
            this.guna2PanelCard.Controls.Add(this.label2);
            this.guna2PanelCard.Controls.Add(this.label3);
            this.guna2PanelCard.Controls.Add(this.guna2Button1);
            this.guna2PanelCard.Controls.Add(this.gridViewUsers);
            this.guna2PanelCard.Controls.Add(this.btnShow);
            this.guna2PanelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59))))); // Slate 800
            this.guna2PanelCard.Location = new System.Drawing.Point(30, 90);
            this.guna2PanelCard.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PanelCard.Name = "guna2PanelCard";
            this.guna2PanelCard.ShadowDecoration.BorderRadius = 16;
            this.guna2PanelCard.ShadowDecoration.Color = System.Drawing.Color.Black;
            this.guna2PanelCard.ShadowDecoration.Depth = 25;
            this.guna2PanelCard.ShadowDecoration.Enabled = true;
            this.guna2PanelCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.guna2PanelCard.Size = new System.Drawing.Size(1040, 580);
            this.guna2PanelCard.TabIndex = 1;

            // 
            // label2 (Card Subtitle)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "System Users";

            // 
            // label3 (Navigation Hint)
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184))))); // Slate 400
            this.label3.Location = new System.Drawing.Point(680, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Go to Next:";

            // 
            // guna2Button1 (Vibrant Purple to Pink Gradient Button)
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246))))); // Violet 500
            this.guna2Button1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(70)))), ((int)(((byte)(239))))); // Fuchsia 500
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(800, 25);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(210, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "See Shopkeepers";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            // 
            // btnShow (Vibrant Cyan to Blue Gradient Button)
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.Animated = true;
            this.btnShow.BorderRadius = 8;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212))))); // Cyan 500
            this.btnShow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246))))); // Blue 500
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(30, 505);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(200, 45);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Load User Details";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);

            // 
            // gridViewUsers (Fully Themed for Dark Mode)
            // 
            this.gridViewUsers.AllowUserToAddRows = false;
            this.gridViewUsers.AllowUserToDeleteRows = false;
            this.gridViewUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Slate 900 for alternating
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.gridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59))))); // Slate 800 background
            this.gridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235))))); // Blue 600 Header
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewUsers.ColumnHeadersHeight = 50;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240))))); // Slate 200 text
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248))))); // Sky 400 highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Dark text on highlight
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewUsers.DefaultCellStyle = dataGridViewCellStyle3;

            this.gridViewUsers.EnableHeadersVisualStyles = false;
            this.gridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85))))); // Slate 700 borders
            this.gridViewUsers.Location = new System.Drawing.Point(30, 90);
            this.gridViewUsers.MultiSelect = false;
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.ReadOnly = true;
            this.gridViewUsers.RowHeadersVisible = false;
            this.gridViewUsers.RowTemplate.Height = 45;
            this.gridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUsers.Size = new System.Drawing.Size(980, 395);
            this.gridViewUsers.TabIndex = 2;

            // Theme Style property resets to match dark mode
            this.gridViewUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.gridViewUsers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gridViewUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.gridViewUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.gridViewUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));

            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Slate 900 Root Background
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tableLayoutPanelRoot);
            this.MinimumSize = new System.Drawing.Size(900, 600); // Prevents layout crushing
            this.Name = "AdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Control Panel";

            this.tableLayoutPanelRoot.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.guna2PanelCard.ResumeLayout(false);
            this.guna2PanelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Layout controls
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoot;
        private System.Windows.Forms.Panel panelTopBar;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelCard;

        // Upgraded Controls
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewUsers;

        // Notice: Changed to Guna2GradientButton for vibrant accents
        private Guna.UI2.WinForms.Guna2GradientButton btnShow;
        private Guna.UI2.WinForms.Guna2GradientButton guna2Button1;

        private Guna.UI2.WinForms.Guna2Button btnLogOut;
    }
}