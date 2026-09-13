//namespace Multi_Booking_System
//{
//    partial class SeeDiyaReview
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
//            this.Text = "SeeDiyaReview";
//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class SeeDiyaReview
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
            this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.reviewCard = new Guna.UI2.WinForms.Guna2Panel();
            this.gridViewReviews = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bottomPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadReviews = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mainPanel.SuspendLayout();
            this.contentLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.reviewCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReviews)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.contentLayout);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(8)))), ((int)(((byte)(22)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.mainPanel.Size = new System.Drawing.Size(1306, 683);
            this.mainPanel.TabIndex = 0;
            // 
            // contentLayout
            // 
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayout.Controls.Add(this.headerPanel, 0, 0);
            this.contentLayout.Controls.Add(this.reviewCard, 0, 1);
            this.contentLayout.Controls.Add(this.bottomPanel, 0, 2);
            this.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayout.Location = new System.Drawing.Point(40, 37);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.RowCount = 3;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.contentLayout.Size = new System.Drawing.Size(1226, 609);
            this.contentLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BorderRadius = 24;
            this.headerPanel.Controls.Add(this.lblIcon);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 11);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1220, 98);
            this.headerPanel.TabIndex = 0;
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 30F, System.Drawing.FontStyle.Bold);
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(182)))));
            this.lblIcon.Location = new System.Drawing.Point(29, 19);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(74, 64);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "★";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(120, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Diya Customer Reviews";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.lblSubtitle.Location = new System.Drawing.Point(123, 64);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(326, 23);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Diya Beauty Parlour • Customer Feedback";
            // 
            // reviewCard
            // 
            this.reviewCard.BorderRadius = 28;
            this.reviewCard.Controls.Add(this.gridViewReviews);
            this.reviewCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.reviewCard.Location = new System.Drawing.Point(3, 115);
            this.reviewCard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.reviewCard.Name = "reviewCard";
            this.reviewCard.Padding = new System.Windows.Forms.Padding(23, 21, 23, 21);
            this.reviewCard.Size = new System.Drawing.Size(1220, 405);
            this.reviewCard.TabIndex = 1;
            // 
            // gridViewReviews
            // 
            this.gridViewReviews.AllowUserToAddRows = false;
            this.gridViewReviews.AllowUserToDeleteRows = false;
            this.gridViewReviews.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(23)))), ((int)(((byte)(77)))));
            this.gridViewReviews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewReviews.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(24)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(24)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridViewReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewReviews.ColumnHeadersHeight = 48;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewReviews.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewReviews.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridViewReviews.Location = new System.Drawing.Point(23, 21);
            this.gridViewReviews.Name = "gridViewReviews";
            this.gridViewReviews.RowHeadersVisible = false;
            this.gridViewReviews.RowHeadersWidth = 51;
            this.gridViewReviews.RowTemplate.Height = 44;
            this.gridViewReviews.Size = new System.Drawing.Size(1174, 363);
            this.gridViewReviews.TabIndex = 0;
            this.gridViewReviews.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.gridViewReviews.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.gridViewReviews.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.gridViewReviews.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(23)))), ((int)(((byte)(77)))));
            this.gridViewReviews.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.gridViewReviews.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridViewReviews.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(24)))), ((int)(((byte)(93)))));
            this.gridViewReviews.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gridViewReviews.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewReviews.ThemeStyle.HeaderStyle.Height = 48;
            this.gridViewReviews.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.Window;
            this.gridViewReviews.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewReviews.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridViewReviews.ThemeStyle.RowsStyle.Height = 44;
            this.gridViewReviews.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.gridViewReviews.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnClose);
            this.bottomPanel.Controls.Add(this.btnLoadReviews);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.FillColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Location = new System.Drawing.Point(3, 532);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1220, 74);
            this.bottomPanel.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(182)))));
            this.btnClose.BorderRadius = 16;
            this.btnClose.BorderThickness = 1;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.btnClose.Location = new System.Drawing.Point(920, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 53);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕  Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadReviews
            // 
            this.btnLoadReviews.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLoadReviews.BorderRadius = 16;
            this.btnLoadReviews.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(24)))), ((int)(((byte)(93)))));
            this.btnLoadReviews.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.btnLoadReviews.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadReviews.ForeColor = System.Drawing.Color.White;
            this.btnLoadReviews.Location = new System.Drawing.Point(745, 12);
            this.btnLoadReviews.Name = "btnLoadReviews";
            this.btnLoadReviews.Size = new System.Drawing.Size(165, 50);
            this.btnLoadReviews.TabIndex = 0;
            this.btnLoadReviews.Text = "★  Load Reviews";
            this.btnLoadReviews.Click += new System.EventHandler(this.btnLoadReviews_Click);
            // 
            // SeeDiyaReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(8)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1306, 683);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(969, 552);
            this.Name = "SeeDiyaReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diya Customer Reviews";
            this.mainPanel.ResumeLayout(false);
            this.contentLayout.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.reviewCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReviews)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;

        private System.Windows.Forms.TableLayoutPanel contentLayout;

        private Guna.UI2.WinForms.Guna2Panel headerPanel;

        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private Guna.UI2.WinForms.Guna2Panel reviewCard;

        private Guna.UI2.WinForms.Guna2DataGridView gridViewReviews;

        private Guna.UI2.WinForms.Guna2Panel bottomPanel;

        private Guna.UI2.WinForms.Guna2GradientButton btnLoadReviews;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}