//namespace Multi_Booking_System
//{
//    partial class TirthoReview
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
//            this.Text = "TirthoReview";
//        }

//        #endregion
//    }
//}

//namespace Multi_Booking_System
//{
//    partial class TirthoReview
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblRating;
//        private System.Windows.Forms.ComboBox TirthoRating;
//        private System.Windows.Forms.Label lblReview;
//        private System.Windows.Forms.TextBox txtReview;
//        private System.Windows.Forms.Button btnSubmitReview;

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
//            this.lblRating = new System.Windows.Forms.Label();
//            this.TirthoRating = new System.Windows.Forms.ComboBox();
//            this.lblReview = new System.Windows.Forms.Label();
//            this.txtReview = new System.Windows.Forms.TextBox();
//            this.btnSubmitReview = new System.Windows.Forms.Button();
//            this.button1 = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // lblTitle
//            // 
//            this.lblTitle.AutoSize = true;
//            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
//            this.lblTitle.Location = new System.Drawing.Point(309, 43);
//            this.lblTitle.Name = "lblTitle";
//            this.lblTitle.Size = new System.Drawing.Size(333, 46);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "Tirtho Store Review";
//            // 
//            // lblRating
//            // 
//            this.lblRating.AutoSize = true;
//            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.lblRating.Location = new System.Drawing.Point(206, 128);
//            this.lblRating.Name = "lblRating";
//            this.lblRating.Size = new System.Drawing.Size(75, 25);
//            this.lblRating.TabIndex = 1;
//            this.lblRating.Text = "Rating:";
//            // 
//            // TirthoRating
//            // 
//            this.TirthoRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.TirthoRating.Font = new System.Drawing.Font("Segoe UI", 11F);
//            this.TirthoRating.FormattingEnabled = true;
//            this.TirthoRating.Items.AddRange(new object[] {
//            "1",
//            "2",
//            "3",
//            "4",
//            "5"});
//            this.TirthoRating.Location = new System.Drawing.Point(320, 125);
//            this.TirthoRating.Name = "TirthoRating";
//            this.TirthoRating.Size = new System.Drawing.Size(342, 33);
//            this.TirthoRating.TabIndex = 2;
//            // 
//            // lblReview
//            // 
//            this.lblReview.AutoSize = true;
//            this.lblReview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.lblReview.Location = new System.Drawing.Point(206, 187);
//            this.lblReview.Name = "lblReview";
//            this.lblReview.Size = new System.Drawing.Size(126, 25);
//            this.lblReview.TabIndex = 3;
//            this.lblReview.Text = "Your Review:";
//            // 
//            // txtReview
//            // 
//            this.txtReview.Font = new System.Drawing.Font("Segoe UI", 11F);
//            this.txtReview.Location = new System.Drawing.Point(206, 224);
//            this.txtReview.Multiline = true;
//            this.txtReview.Name = "txtReview";
//            this.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//            this.txtReview.Size = new System.Drawing.Size(457, 106);
//            this.txtReview.TabIndex = 2;
//            // 
//            // btnSubmitReview
//            // 
//            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.btnSubmitReview.Location = new System.Drawing.Point(211, 363);
//            this.btnSubmitReview.Name = "btnSubmitReview";
//            this.btnSubmitReview.Size = new System.Drawing.Size(229, 48);
//            this.btnSubmitReview.TabIndex = 3;
//            this.btnSubmitReview.Text = "Submit Review";
//            this.btnSubmitReview.UseVisualStyleBackColor = true;
//            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
//            // 
//            // button1
//            // 
//            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.button1.Location = new System.Drawing.Point(496, 363);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(101, 48);
//            this.button1.TabIndex = 4;
//            this.button1.Text = "Close";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // TirthoReview
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(914, 480);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.lblTitle);
//            this.Controls.Add(this.lblRating);
//            this.Controls.Add(this.TirthoRating);
//            this.Controls.Add(this.lblReview);
//            this.Controls.Add(this.txtReview);
//            this.Controls.Add(this.btnSubmitReview);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
//            this.MaximizeBox = false;
//            this.Name = "TirthoReview";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Tirtho Review";
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Button button1;
//    }
//}

namespace Multi_Booking_System
{
    partial class TirthoReview
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelLeftBrand = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelRightContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.TirthoRating = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.txtReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmitReview = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelLeftBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelRightContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelLeftBrand;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelLeftBrand
            // 
            this.panelLeftBrand.Controls.Add(this.lblBrandSubtitle);
            this.panelLeftBrand.Controls.Add(this.lblBrandTitle);
            this.panelLeftBrand.Controls.Add(this.guna2PictureBox1);
            this.panelLeftBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.panelLeftBrand.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelLeftBrand.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelLeftBrand.Location = new System.Drawing.Point(0, 0);
            this.panelLeftBrand.Name = "panelLeftBrand";
            this.panelLeftBrand.Size = new System.Drawing.Size(350, 600);
            this.panelLeftBrand.TabIndex = 0;
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblBrandSubtitle.Location = new System.Drawing.Point(45, 300);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(260, 100);
            this.lblBrandSubtitle.TabIndex = 2;
            this.lblBrandSubtitle.Text = "Your feedback helps us grow and provide better services at Tirtho Store.";
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(40, 180);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(270, 110);
            this.lblBrandTitle.TabIndex = 1;
            this.lblBrandTitle.Text = "Rate Your Experience";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(50, 80);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panelRightContent;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // panelRightContent
            // 
            this.panelRightContent.BackColor = System.Drawing.Color.White;
            this.panelRightContent.Controls.Add(this.guna2ControlBox3);
            this.panelRightContent.Controls.Add(this.guna2ControlBox2);
            this.panelRightContent.Controls.Add(this.guna2ControlBox1);
            this.panelRightContent.Controls.Add(this.lblTitle);
            this.panelRightContent.Controls.Add(this.lblRating);
            this.panelRightContent.Controls.Add(this.TirthoRating);
            this.panelRightContent.Controls.Add(this.lblReview);
            this.panelRightContent.Controls.Add(this.txtReview);
            this.panelRightContent.Controls.Add(this.btnSubmitReview);
            this.panelRightContent.Controls.Add(this.button1);
            this.panelRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightContent.Location = new System.Drawing.Point(350, 0);
            this.panelRightContent.Name = "panelRightContent";
            this.panelRightContent.Size = new System.Drawing.Size(650, 600);
            this.panelRightContent.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.guna2ControlBox3.Location = new System.Drawing.Point(490, 15);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 22;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(540, 15);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 21;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(590, 15);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(70, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Leave a Review";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRating.Location = new System.Drawing.Point(70, 160);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(197, 23);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "How would you rate us?";
            // 
            // TirthoRating
            // 
            this.TirthoRating.BackColor = System.Drawing.Color.Transparent;
            this.TirthoRating.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.TirthoRating.BorderRadius = 8;
            this.TirthoRating.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TirthoRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TirthoRating.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.TirthoRating.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.TirthoRating.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TirthoRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.TirthoRating.ItemHeight = 35;
            this.TirthoRating.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.TirthoRating.Location = new System.Drawing.Point(70, 190);
            this.TirthoRating.Name = "TirthoRating";
            this.TirthoRating.Size = new System.Drawing.Size(500, 41);
            this.TirthoRating.StartIndex = 0;
            this.TirthoRating.TabIndex = 2;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblReview.Location = new System.Drawing.Point(70, 260);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(279, 23);
            this.lblReview.TabIndex = 3;
            this.lblReview.Text = "Tell us more about your experience";
            // 
            // txtReview
            // 
            this.txtReview.Animated = true;
            this.txtReview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtReview.BorderRadius = 8;
            this.txtReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReview.DefaultText = "";
            this.txtReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.txtReview.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.txtReview.Location = new System.Drawing.Point(70, 290);
            this.txtReview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtReview.PlaceholderText = "Write your detailed feedback here...";
            this.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReview.SelectedText = "";
            this.txtReview.Size = new System.Drawing.Size(500, 140);
            this.txtReview.TabIndex = 4;
            this.txtReview.TextOffset = new System.Drawing.Point(5, 5);
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Animated = true;
            this.btnSubmitReview.BorderRadius = 10;
            this.btnSubmitReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitReview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnSubmitReview.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSubmitReview.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSubmitReview.Location = new System.Drawing.Point(70, 460);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(350, 50);
            this.btnSubmitReview.TabIndex = 5;
            this.btnSubmitReview.Text = "Submit Feedback";
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // button1
            // 
            this.button1.Animated = true;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.button1.BorderRadius = 10;
            this.button1.BorderThickness = 1;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FillColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.button1.Location = new System.Drawing.Point(440, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TirthoReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelRightContent);
            this.Controls.Add(this.panelLeftBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TirthoReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tirtho Review";
            this.panelLeftBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelRightContent.ResumeLayout(false);
            this.panelRightContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Added Layout Components
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelLeftBrand;
        private Guna.UI2.WinForms.Guna2Panel panelRightContent;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;

        // Brand Elements
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

        // Original Elements (Now mapped to Guna controls where appropriate)
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRating;
        private Guna.UI2.WinForms.Guna2ComboBox TirthoRating;
        private System.Windows.Forms.Label lblReview;
        private Guna.UI2.WinForms.Guna2TextBox txtReview;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmitReview;
        private Guna.UI2.WinForms.Guna2Button button1; // Cancel button
    }
}