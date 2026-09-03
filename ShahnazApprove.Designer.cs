//namespace Multi_Booking_System
//{
//    partial class ShahnazApprove
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
//            this.Text = "ShahnazApprove";
//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class ShahnazApprove
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
            this.panelGrid = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.headerGrid = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelGridTitle = new System.Windows.Forms.Label();
            this.btnShahnazCustomerSerial = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridViewShahnazCustomerSerial = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelAction = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.headerAction = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelActionTitle = new System.Windows.Forms.Label();
            this.CustomerSerialIdShahnaz = new System.Windows.Forms.Label();
            this.txtboxShahnazCustomerSerial = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShahnazApprove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelGrid.SuspendLayout();
            this.headerGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShahnazCustomerSerial)).BeginInit();
            this.panelAction.SuspendLayout();
            this.headerAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.labelMainTitle.Location = new System.Drawing.Point(30, 20);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(388, 54);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Approve Bookings";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.headerGrid);
            this.panelGrid.Controls.Add(this.gridViewShahnazCustomerSerial);
            this.panelGrid.FillColor = System.Drawing.Color.White;
            this.panelGrid.Location = new System.Drawing.Point(30, 90);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Radius = 15;
            this.panelGrid.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.panelGrid.ShadowDepth = 40;
            this.panelGrid.ShadowShift = 6;
            this.panelGrid.Size = new System.Drawing.Size(1066, 400);
            this.panelGrid.TabIndex = 1;
            // 
            // headerGrid
            // 
            this.headerGrid.BorderRadius = 15;
            this.headerGrid.Controls.Add(this.labelGridTitle);
            this.headerGrid.Controls.Add(this.btnShahnazCustomerSerial);
            this.headerGrid.CustomizableEdges.BottomLeft = false;
            this.headerGrid.CustomizableEdges.BottomRight = false;
            this.headerGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerGrid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.headerGrid.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.headerGrid.Location = new System.Drawing.Point(0, 0);
            this.headerGrid.Name = "headerGrid";
            this.headerGrid.Size = new System.Drawing.Size(1066, 75);
            this.headerGrid.TabIndex = 5;
            // 
            // labelGridTitle
            // 
            this.labelGridTitle.AutoSize = true;
            this.labelGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelGridTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGridTitle.ForeColor = System.Drawing.Color.White;
            this.labelGridTitle.Location = new System.Drawing.Point(20, 18);
            this.labelGridTitle.Name = "labelGridTitle";
            this.labelGridTitle.Size = new System.Drawing.Size(236, 38);
            this.labelGridTitle.TabIndex = 2;
            this.labelGridTitle.Text = "Customer Serials";
            // 
            // btnShahnazCustomerSerial
            // 
            this.btnShahnazCustomerSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShahnazCustomerSerial.Animated = true;
            this.btnShahnazCustomerSerial.BackColor = System.Drawing.Color.Transparent;
            this.btnShahnazCustomerSerial.BorderRadius = 8;
            this.btnShahnazCustomerSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShahnazCustomerSerial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.btnShahnazCustomerSerial.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnShahnazCustomerSerial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnShahnazCustomerSerial.ForeColor = System.Drawing.Color.White;
            this.btnShahnazCustomerSerial.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnShahnazCustomerSerial.Location = new System.Drawing.Point(806, 15);
            this.btnShahnazCustomerSerial.Name = "btnShahnazCustomerSerial";
            this.btnShahnazCustomerSerial.Size = new System.Drawing.Size(240, 45);
            this.btnShahnazCustomerSerial.TabIndex = 3;
            this.btnShahnazCustomerSerial.Text = "Load / Refresh Serials";
            this.btnShahnazCustomerSerial.Click += new System.EventHandler(this.btnShahnazCustomerSerial_Click);
            // 
            // gridViewShahnazCustomerSerial
            // 
            this.gridViewShahnazCustomerSerial.AllowUserToAddRows = false;
            this.gridViewShahnazCustomerSerial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gridViewShahnazCustomerSerial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewShahnazCustomerSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewShahnazCustomerSerial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewShahnazCustomerSerial.ColumnHeadersHeight = 50;
            this.gridViewShahnazCustomerSerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewShahnazCustomerSerial.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewShahnazCustomerSerial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.gridViewShahnazCustomerSerial.Location = new System.Drawing.Point(26, 95);
            this.gridViewShahnazCustomerSerial.Name = "gridViewShahnazCustomerSerial";
            this.gridViewShahnazCustomerSerial.ReadOnly = true;
            this.gridViewShahnazCustomerSerial.RowHeadersVisible = false;
            this.gridViewShahnazCustomerSerial.RowHeadersWidth = 51;
            this.gridViewShahnazCustomerSerial.RowTemplate.Height = 45;
            this.gridViewShahnazCustomerSerial.Size = new System.Drawing.Size(1020, 275);
            this.gridViewShahnazCustomerSerial.TabIndex = 4;
            this.gridViewShahnazCustomerSerial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gridViewShahnazCustomerSerial.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.gridViewShahnazCustomerSerial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.gridViewShahnazCustomerSerial.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gridViewShahnazCustomerSerial.ThemeStyle.HeaderStyle.Height = 50;
            this.gridViewShahnazCustomerSerial.ThemeStyle.ReadOnly = true;
            this.gridViewShahnazCustomerSerial.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.gridViewShahnazCustomerSerial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridViewShahnazCustomerSerial.ThemeStyle.RowsStyle.Height = 45;
            this.gridViewShahnazCustomerSerial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.gridViewShahnazCustomerSerial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gridViewShahnazCustomerSerial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewShahnazCustomerSerial_CellContentClick);
            // 
            // panelAction
            // 
            this.panelAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAction.BackColor = System.Drawing.Color.Transparent;
            this.panelAction.Controls.Add(this.headerAction);
            this.panelAction.Controls.Add(this.CustomerSerialIdShahnaz);
            this.panelAction.Controls.Add(this.txtboxShahnazCustomerSerial);
            this.panelAction.Controls.Add(this.btnShahnazApprove);
            this.panelAction.FillColor = System.Drawing.Color.White;
            this.panelAction.Location = new System.Drawing.Point(30, 510);
            this.panelAction.Name = "panelAction";
            this.panelAction.Radius = 15;
            this.panelAction.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.panelAction.ShadowDepth = 40;
            this.panelAction.ShadowShift = 6;
            this.panelAction.Size = new System.Drawing.Size(1066, 140);
            this.panelAction.TabIndex = 5;
            // 
            // headerAction
            // 
            this.headerAction.BorderRadius = 15;
            this.headerAction.Controls.Add(this.labelActionTitle);
            this.headerAction.CustomizableEdges.BottomLeft = false;
            this.headerAction.CustomizableEdges.BottomRight = false;
            this.headerAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerAction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.headerAction.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(176)))));
            this.headerAction.Location = new System.Drawing.Point(0, 0);
            this.headerAction.Name = "headerAction";
            this.headerAction.Size = new System.Drawing.Size(1066, 45);
            this.headerAction.TabIndex = 10;
            // 
            // labelActionTitle
            // 
            this.labelActionTitle.AutoSize = true;
            this.labelActionTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelActionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActionTitle.ForeColor = System.Drawing.Color.White;
            this.labelActionTitle.Location = new System.Drawing.Point(22, 8);
            this.labelActionTitle.Name = "labelActionTitle";
            this.labelActionTitle.Size = new System.Drawing.Size(123, 28);
            this.labelActionTitle.TabIndex = 6;
            this.labelActionTitle.Text = "Take Action";
            // 
            // CustomerSerialIdShahnaz
            // 
            this.CustomerSerialIdShahnaz.AutoSize = true;
            this.CustomerSerialIdShahnaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSerialIdShahnaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CustomerSerialIdShahnaz.Location = new System.Drawing.Point(22, 72);
            this.CustomerSerialIdShahnaz.Name = "CustomerSerialIdShahnaz";
            this.CustomerSerialIdShahnaz.Size = new System.Drawing.Size(153, 28);
            this.CustomerSerialIdShahnaz.TabIndex = 7;
            this.CustomerSerialIdShahnaz.Text = "Enter Serial ID:";
            // 
            // txtboxShahnazCustomerSerial
            // 
            this.txtboxShahnazCustomerSerial.BorderRadius = 8;
            this.txtboxShahnazCustomerSerial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxShahnazCustomerSerial.DefaultText = "";
            this.txtboxShahnazCustomerSerial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtboxShahnazCustomerSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtboxShahnazCustomerSerial.Location = new System.Drawing.Point(210, 64);
            this.txtboxShahnazCustomerSerial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtboxShahnazCustomerSerial.Name = "txtboxShahnazCustomerSerial";
            this.txtboxShahnazCustomerSerial.PlaceholderText = "e.g. 101";
            this.txtboxShahnazCustomerSerial.SelectedText = "";
            this.txtboxShahnazCustomerSerial.Size = new System.Drawing.Size(250, 45);
            this.txtboxShahnazCustomerSerial.TabIndex = 8;
            // 
            // btnShahnazApprove
            // 
            this.btnShahnazApprove.Animated = true;
            this.btnShahnazApprove.BorderRadius = 8;
            this.btnShahnazApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShahnazApprove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnShahnazApprove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.btnShahnazApprove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnShahnazApprove.ForeColor = System.Drawing.Color.White;
            this.btnShahnazApprove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.btnShahnazApprove.Location = new System.Drawing.Point(480, 64);
            this.btnShahnazApprove.Name = "btnShahnazApprove";
            this.btnShahnazApprove.Size = new System.Drawing.Size(180, 45);
            this.btnShahnazApprove.TabIndex = 9;
            this.btnShahnazApprove.Text = "Approve Serial";
            this.btnShahnazApprove.Click += new System.EventHandler(this.btnShahnazApprove_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(967, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(809, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 30);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ShahnazApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1126, 680);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "ShahnazApprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shahnaz - Approve Bookings";
            this.panelGrid.ResumeLayout(false);
            this.headerGrid.ResumeLayout(false);
            this.headerGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShahnazCustomerSerial)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.headerAction.ResumeLayout(false);
            this.headerAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelGrid;
        private Guna.UI2.WinForms.Guna2GradientPanel headerGrid;
        private System.Windows.Forms.Label labelGridTitle;

        private Guna.UI2.WinForms.Guna2GradientButton btnShahnazCustomerSerial;

        private Guna.UI2.WinForms.Guna2DataGridView gridViewShahnazCustomerSerial;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelAction;
        private Guna.UI2.WinForms.Guna2GradientPanel headerAction;

        private System.Windows.Forms.Label labelActionTitle;
        private System.Windows.Forms.Label CustomerSerialIdShahnaz;

        private Guna.UI2.WinForms.Guna2TextBox txtboxShahnazCustomerSerial;

        private Guna.UI2.WinForms.Guna2GradientButton btnShahnazApprove;

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}