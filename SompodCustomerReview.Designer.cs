//namespace Multi_Booking_System
//{
//    partial class SompodCustomerReview
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
//            this.Text = "SompodCustomerReview";
//        }

//        #endregion
//    }
//}

//namespace Multi_Booking_System
//{
//    partial class SompodCustomerReview
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblSubtitle;
//        private System.Windows.Forms.DataGridView dataGridViewReviews;
//        private System.Windows.Forms.Button btnShowService;
//        private System.Windows.Forms.Button btnClose;

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
//        /// Required method for Designer support.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.lblTitle = new System.Windows.Forms.Label();
//            this.lblSubtitle = new System.Windows.Forms.Label();
//            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
//            this.btnShowService = new System.Windows.Forms.Button();
//            this.btnClose = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // lblTitle
//            // 
//            this.lblTitle.AutoSize = true;
//            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
//            this.lblTitle.Location = new System.Drawing.Point(400, 27);
//            this.lblTitle.Name = "lblTitle";
//            this.lblTitle.Size = new System.Drawing.Size(310, 46);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "Customer Reviews";
//            // 
//            // lblSubtitle
//            // 
//            this.lblSubtitle.AutoSize = true;
//            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.lblSubtitle.Location = new System.Drawing.Point(417, 75);
//            this.lblSubtitle.Name = "lblSubtitle";
//            this.lblSubtitle.Size = new System.Drawing.Size(285, 23);
//            this.lblSubtitle.TabIndex = 1;
//            this.lblSubtitle.Text = "Sompod Store - Customer Feedback";
//            // 
//            // dataGridViewReviews
//            // 
//            this.dataGridViewReviews.AllowUserToAddRows = false;
//            this.dataGridViewReviews.AllowUserToDeleteRows = false;
//            this.dataGridViewReviews.AllowUserToResizeRows = false;
//            this.dataGridViewReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dataGridViewReviews.BackgroundColor = System.Drawing.SystemColors.Window;
//            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridViewReviews.Location = new System.Drawing.Point(57, 123);
//            this.dataGridViewReviews.MultiSelect = false;
//            this.dataGridViewReviews.Name = "dataGridViewReviews";
//            this.dataGridViewReviews.ReadOnly = true;
//            this.dataGridViewReviews.RowHeadersVisible = false;
//            this.dataGridViewReviews.RowHeadersWidth = 51;
//            this.dataGridViewReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dataGridViewReviews.Size = new System.Drawing.Size(1029, 373);
//            this.dataGridViewReviews.TabIndex = 0;
//            // 
//            // btnShowService
//            // 
//            this.btnShowService.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.btnShowService.Location = new System.Drawing.Point(343, 533);
//            this.btnShowService.Name = "btnShowService";
//            this.btnShowService.Size = new System.Drawing.Size(171, 43);
//            this.btnShowService.TabIndex = 1;
//            this.btnShowService.Text = "Show Reviews";
//            this.btnShowService.UseVisualStyleBackColor = true;
//            this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);
//            // 
//            // btnClose
//            // 
//            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.btnClose.Location = new System.Drawing.Point(629, 533);
//            this.btnClose.Name = "btnClose";
//            this.btnClose.Size = new System.Drawing.Size(171, 43);
//            this.btnClose.TabIndex = 2;
//            this.btnClose.Text = "Close";
//            this.btnClose.UseVisualStyleBackColor = true;
//            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
//            // 
//            // SompodCustomerReview
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1143, 640);
//            this.Controls.Add(this.lblTitle);
//            this.Controls.Add(this.lblSubtitle);
//            this.Controls.Add(this.dataGridViewReviews);
//            this.Controls.Add(this.btnShowService);
//            this.Controls.Add(this.btnClose);
//            this.Name = "SompodCustomerReview";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Sompod Store - Customer Reviews";
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class SompodCustomerReview
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
            this.guna2GradientPanelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2PanelGridContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewReviews = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowService = new Guna.UI2.WinForms.Guna2GradientButton();

            this.guna2GradientPanelBg.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.guna2PanelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // guna2GradientPanelBg (Vibrant Colorful Background)
            // 
            this.guna2GradientPanelBg.Controls.Add(this.tableLayoutPanelMain);
            this.guna2GradientPanelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246))))); // Violet 500
            this.guna2GradientPanelBg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(70)))), ((int)(((byte)(239))))); // Fuchsia 500
            this.guna2GradientPanelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanelBg.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanelBg.Name = "guna2GradientPanelBg";
            this.guna2GradientPanelBg.Size = new System.Drawing.Size(1143, 640);
            this.guna2GradientPanelBg.TabIndex = 0;

            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.guna2PanelGridContainer, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelButtons, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1143, 640);
            this.tableLayoutPanelMain.TabIndex = 0;

            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(30, 30);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1083, 100);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Reviews";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(255))))); // Soft pale pink/fuchsia
            this.lblSubtitle.Location = new System.Drawing.Point(5, 72);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 27);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Sompod Store - Customer Feedback";

            // 
            // guna2PanelGridContainer
            // 
            this.guna2PanelGridContainer.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelGridContainer.BorderRadius = 24;
            this.guna2PanelGridContainer.Controls.Add(this.dataGridViewReviews);
            this.guna2PanelGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelGridContainer.FillColor = System.Drawing.Color.White;
            this.guna2PanelGridContainer.Location = new System.Drawing.Point(33, 133);
            this.guna2PanelGridContainer.Name = "guna2PanelGridContainer";
            this.guna2PanelGridContainer.Padding = new System.Windows.Forms.Padding(25);
            this.guna2PanelGridContainer.ShadowDecoration.BorderRadius = 24;
            this.guna2PanelGridContainer.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(33)))), ((int)(((byte)(168))))); // Dark purple shadow
            this.guna2PanelGridContainer.ShadowDecoration.Depth = 15;
            this.guna2PanelGridContainer.ShadowDecoration.Enabled = true;
            this.guna2PanelGridContainer.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.guna2PanelGridContainer.Size = new System.Drawing.Size(1077, 394);
            this.guna2PanelGridContainer.TabIndex = 1;

            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.AllowUserToAddRows = false;
            this.dataGridViewReviews.AllowUserToDeleteRows = false;
            this.dataGridViewReviews.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255))))); // Very soft lilac alternating rows
            this.dataGridViewReviews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReviews.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReviews.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReviews.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246))))); // Violet Header
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReviews.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(70)))), ((int)(((byte)(239))))); // Fuchsia Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReviews.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReviews.EnableHeadersVisualStyles = false;
            this.dataGridViewReviews.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255))))); // Soft lilac borders
            this.dataGridViewReviews.Location = new System.Drawing.Point(25, 25);
            this.dataGridViewReviews.MultiSelect = false;
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.ReadOnly = true;
            this.dataGridViewReviews.RowHeadersVisible = false;
            this.dataGridViewReviews.RowTemplate.Height = 45;
            this.dataGridViewReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReviews.Size = new System.Drawing.Size(1027, 344);
            this.dataGridViewReviews.TabIndex = 0;
            this.dataGridViewReviews.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dataGridViewReviews.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReviews.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewReviews.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.dataGridViewReviews.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;

            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnShowService);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(30, 530);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1083, 80);
            this.panelButtons.TabIndex = 2;

            // 
            // btnShowService (Vibrant Gradient Button)
            // 
            this.btnShowService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowService.Animated = true;
            this.btnShowService.BorderRadius = 12;
            this.btnShowService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(70)))), ((int)(((byte)(239))))); // Fuchsia 500
            this.btnShowService.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22))))); // Orange 500
            this.btnShowService.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnShowService.ForeColor = System.Drawing.Color.White;
            this.btnShowService.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(38)))), ((int)(((byte)(211))))); // Fuchsia 600
            this.btnShowService.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12))))); // Orange 600
            this.btnShowService.Location = new System.Drawing.Point(740, 15);
            this.btnShowService.Name = "btnShowService";
            this.btnShowService.Size = new System.Drawing.Size(180, 50);
            this.btnShowService.TabIndex = 1;
            this.btnShowService.Text = "Load Reviews";
            this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);

            // 
            // btnClose (Minimalist White Ghost Button)
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Animated = true;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 12;
            this.btnClose.BorderThickness = 2;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246))))); // Violet text on hover
            this.btnClose.Location = new System.Drawing.Point(933, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Back";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // SompodCustomerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1143, 640);
            this.Controls.Add(this.guna2GradientPanelBg); // Apply Gradient Background to root
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "SompodCustomerReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sompod Store - Customer Reviews";

            this.guna2GradientPanelBg.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.guna2PanelGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Added Layout Containers
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanelBg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelGridContainer;
        private System.Windows.Forms.Panel panelButtons;

        // Original & Upgraded Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewReviews; // Upgraded for premium aesthetic
        private Guna.UI2.WinForms.Guna2GradientButton btnShowService; // Upgraded to gradient
        private Guna.UI2.WinForms.Guna2Button btnClose; // Upgraded
    }
}