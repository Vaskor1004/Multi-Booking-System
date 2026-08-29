//namespace Multi_Booking_System
//{
//    partial class CustomerSerialDetails
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
//            this.btnCustomerSerialDetails = new Guna.UI2.WinForms.Guna2Button();
//            this.gridViewSerialDetails = new System.Windows.Forms.DataGridView();
//            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialDetails)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // btnCustomerSerialDetails
//            // 
//            this.btnCustomerSerialDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
//            this.btnCustomerSerialDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
//            this.btnCustomerSerialDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
//            this.btnCustomerSerialDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
//            this.btnCustomerSerialDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnCustomerSerialDetails.ForeColor = System.Drawing.Color.White;
//            this.btnCustomerSerialDetails.Location = new System.Drawing.Point(311, 282);
//            this.btnCustomerSerialDetails.Name = "btnCustomerSerialDetails";
//            this.btnCustomerSerialDetails.Size = new System.Drawing.Size(180, 45);
//            this.btnCustomerSerialDetails.TabIndex = 0;
//            this.btnCustomerSerialDetails.Text = "Details";
//            this.btnCustomerSerialDetails.Click += new System.EventHandler(this.btnCustomerSerialDetails_Click);
//            // 
//            // gridViewSerialDetails
//            // 
//            this.gridViewSerialDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.gridViewSerialDetails.Location = new System.Drawing.Point(45, 35);
//            this.gridViewSerialDetails.Name = "gridViewSerialDetails";
//            this.gridViewSerialDetails.RowHeadersWidth = 51;
//            this.gridViewSerialDetails.RowTemplate.Height = 24;
//            this.gridViewSerialDetails.Size = new System.Drawing.Size(701, 187);
//            this.gridViewSerialDetails.TabIndex = 1;
//            // 
//            // CustomerSerialDetails
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.gridViewSerialDetails);
//            this.Controls.Add(this.btnCustomerSerialDetails);
//            this.Name = "CustomerSerialDetails";
//            this.Text = "CustomerSerialDetails";
//            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialDetails)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private Guna.UI2.WinForms.Guna2Button btnCustomerSerialDetails;
//        private System.Windows.Forms.DataGridView gridViewSerialDetails;
//    }
//}

namespace Multi_Booking_System
{
    partial class CustomerSerialDetails
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
            this.gridViewSerialDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCustomerSerialDetails = new Guna.UI2.WinForms.Guna2GradientButton();

            this.panelGrid.SuspendLayout();
            this.headerGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialDetails)).BeginInit();
            this.SuspendLayout();

            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60))))); // Deep Navy
            this.labelMainTitle.Location = new System.Drawing.Point(30, 20);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(326, 50);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Booking Details";

            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.headerGrid);
            this.panelGrid.Controls.Add(this.gridViewSerialDetails);
            this.panelGrid.FillColor = System.Drawing.Color.White;
            this.panelGrid.Location = new System.Drawing.Point(30, 90);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Radius = 15;
            this.panelGrid.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(180))))); // Soft cool shadow
            this.panelGrid.ShadowDepth = 40;
            this.panelGrid.ShadowShift = 6;
            this.panelGrid.Size = new System.Drawing.Size(840, 360);
            this.panelGrid.TabIndex = 1;

            // 
            // headerGrid
            // 
            this.headerGrid.Controls.Add(this.labelGridTitle);
            this.headerGrid.Controls.Add(this.btnCustomerSerialDetails);
            this.headerGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerGrid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(172)))), ((int)(((byte)(254))))); // Bright Cyan
            this.headerGrid.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(254))))); // Aqua
            this.headerGrid.Location = new System.Drawing.Point(0, 0);
            this.headerGrid.Name = "headerGrid";
            this.headerGrid.Size = new System.Drawing.Size(840, 75);
            this.headerGrid.TabIndex = 2;
            this.headerGrid.BorderRadius = 15;
            this.headerGrid.CustomizableEdges.BottomLeft = false;
            this.headerGrid.CustomizableEdges.BottomRight = false;

            // 
            // labelGridTitle
            // 
            this.labelGridTitle.AutoSize = true;
            this.labelGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelGridTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGridTitle.ForeColor = System.Drawing.Color.White;
            this.labelGridTitle.Location = new System.Drawing.Point(20, 18);
            this.labelGridTitle.Name = "labelGridTitle";
            this.labelGridTitle.Size = new System.Drawing.Size(264, 38);
            this.labelGridTitle.TabIndex = 3;
            this.labelGridTitle.Text = "My Serial Records";

            // 
            // btnCustomerSerialDetails
            // 
            this.btnCustomerSerialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerSerialDetails.Animated = true;
            this.btnCustomerSerialDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerSerialDetails.BorderRadius = 8;
            this.btnCustomerSerialDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerSerialDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(8))))); // Vibrant Orange Gradient
            this.btnCustomerSerialDetails.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(55))))); // Warm Gold Gradient
            this.btnCustomerSerialDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustomerSerialDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSerialDetails.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(30)))));
            this.btnCustomerSerialDetails.Location = new System.Drawing.Point(590, 15);
            this.btnCustomerSerialDetails.Name = "btnCustomerSerialDetails";
            this.btnCustomerSerialDetails.Size = new System.Drawing.Size(220, 45);
            this.btnCustomerSerialDetails.TabIndex = 4;
            this.btnCustomerSerialDetails.Text = "Load Details";
            this.btnCustomerSerialDetails.Click += new System.EventHandler(this.btnCustomerSerialDetails_Click);

            // 
            // gridViewSerialDetails
            // 
            this.gridViewSerialDetails.AllowUserToAddRows = false;
            this.gridViewSerialDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(255))))); // Very light blue/periwinkle
            this.gridViewSerialDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewSerialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(176))))); // Solid Deep Blue Header
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSerialDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewSerialDetails.ColumnHeadersHeight = 50;
            this.gridViewSerialDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255))))); // Soft blue selection
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSerialDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewSerialDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.gridViewSerialDetails.Location = new System.Drawing.Point(26, 95);
            this.gridViewSerialDetails.Name = "gridViewSerialDetails";
            this.gridViewSerialDetails.ReadOnly = true;
            this.gridViewSerialDetails.RowHeadersVisible = false;
            this.gridViewSerialDetails.RowTemplate.Height = 45;
            this.gridViewSerialDetails.Size = new System.Drawing.Size(784, 235);
            this.gridViewSerialDetails.TabIndex = 5;
            this.gridViewSerialDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gridViewSerialDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewSerialDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewSerialDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewSerialDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewSerialDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewSerialDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.gridViewSerialDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(176)))));
            this.gridViewSerialDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewSerialDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridViewSerialDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewSerialDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewSerialDetails.ThemeStyle.HeaderStyle.Height = 50;
            this.gridViewSerialDetails.ThemeStyle.ReadOnly = true;
            this.gridViewSerialDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewSerialDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewSerialDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.gridViewSerialDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridViewSerialDetails.ThemeStyle.RowsStyle.Height = 45;
            this.gridViewSerialDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.gridViewSerialDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));

            // 
            // CustomerSerialDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))); // Very soft blue background
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "CustomerSerialDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Serial Details";

            this.panelGrid.ResumeLayout(false);
            this.headerGrid.ResumeLayout(false);
            this.headerGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelGrid;
        private Guna.UI2.WinForms.Guna2GradientPanel headerGrid;
        private System.Windows.Forms.Label labelGridTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnCustomerSerialDetails;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewSerialDetails;
    }
}