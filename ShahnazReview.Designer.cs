//namespace Multi_Booking_System
//{
//    partial class ShahnazReview
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
//            this.Text = "ShahnazReview";
//        }

//        #endregion
//    }
//}

//namespace Multi_Booking_System
//{
//    partial class ShahnazReview
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblRating;
//        private System.Windows.Forms.ComboBox ShahnazRating;
//        private System.Windows.Forms.Label lblReview;
//        private System.Windows.Forms.TextBox txtReview;
//        private System.Windows.Forms.Button btnSubmitReview;
//        private System.Windows.Forms.Button button1;

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
//            this.ShahnazRating = new System.Windows.Forms.ComboBox();
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
//            this.lblTitle.Size = new System.Drawing.Size(366, 46);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "Shahnaz Store Review";
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
//            // ShahnazRating
//            // 
//            this.ShahnazRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.ShahnazRating.Font = new System.Drawing.Font("Segoe UI", 11F);
//            this.ShahnazRating.FormattingEnabled = true;
//            this.ShahnazRating.Items.AddRange(new object[] {
//            "1",
//            "2",
//            "3",
//            "4",
//            "5"});
//            this.ShahnazRating.Location = new System.Drawing.Point(320, 125);
//            this.ShahnazRating.Name = "ShahnazRating";
//            this.ShahnazRating.Size = new System.Drawing.Size(342, 33);
//            this.ShahnazRating.TabIndex = 2;
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
//            this.txtReview.TabIndex = 4;
//            // 
//            // btnSubmitReview
//            // 
//            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.btnSubmitReview.Location = new System.Drawing.Point(211, 363);
//            this.btnSubmitReview.Name = "btnSubmitReview";
//            this.btnSubmitReview.Size = new System.Drawing.Size(229, 48);
//            this.btnSubmitReview.TabIndex = 5;
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
//            this.button1.TabIndex = 6;
//            this.button1.Text = "Close";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // ShahnazReview
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(914, 480);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.lblTitle);
//            this.Controls.Add(this.lblRating);
//            this.Controls.Add(this.ShahnazRating);
//            this.Controls.Add(this.lblReview);
//            this.Controls.Add(this.txtReview);
//            this.Controls.Add(this.btnSubmitReview);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
//            this.MaximizeBox = false;
//            this.Name = "ShahnazReview";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Shahnaz Review";
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class ShahnazReview
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.ShahnazRating = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.txtReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmitReview = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanelBg.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanelBg;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2GradientPanelBg
            // 
            this.guna2GradientPanelBg.Controls.Add(this.guna2ControlBox3);
            this.guna2GradientPanelBg.Controls.Add(this.guna2ControlBox2);
            this.guna2GradientPanelBg.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanelBg.Controls.Add(this.panelCard);
            this.guna2GradientPanelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(39)))), ((int)(((byte)(119)))));
            this.guna2GradientPanelBg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.guna2GradientPanelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanelBg.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanelBg.Name = "guna2GradientPanelBg";
            this.guna2GradientPanelBg.Size = new System.Drawing.Size(900, 600);
            this.guna2GradientPanelBg.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(740, 15);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 22;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(790, 15);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 21;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(840, 15);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 20;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.Transparent;
            this.panelCard.BorderRadius = 24;
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Controls.Add(this.lblRating);
            this.panelCard.Controls.Add(this.ShahnazRating);
            this.panelCard.Controls.Add(this.lblReview);
            this.panelCard.Controls.Add(this.txtReview);
            this.panelCard.Controls.Add(this.btnSubmitReview);
            this.panelCard.Controls.Add(this.button1);
            this.panelCard.FillColor = System.Drawing.Color.White;
            this.panelCard.Location = new System.Drawing.Point(150, 60);
            this.panelCard.Name = "panelCard";
            this.panelCard.ShadowDecoration.BorderRadius = 24;
            this.panelCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(84)))));
            this.panelCard.ShadowDecoration.Depth = 20;
            this.panelCard.ShadowDecoration.Enabled = true;
            this.panelCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 8, 15, 15);
            this.panelCard.Size = new System.Drawing.Size(600, 480);
            this.panelCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(50, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(403, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Shahnaz Store Review";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRating.Location = new System.Drawing.Point(50, 115);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(110, 23);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Select Rating";
            // 
            // ShahnazRating
            // 
            this.ShahnazRating.BackColor = System.Drawing.Color.Transparent;
            this.ShahnazRating.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ShahnazRating.BorderRadius = 8;
            this.ShahnazRating.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ShahnazRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShahnazRating.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.ShahnazRating.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.ShahnazRating.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ShahnazRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ShahnazRating.ItemHeight = 35;
            this.ShahnazRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ShahnazRating.Location = new System.Drawing.Point(50, 145);
            this.ShahnazRating.Name = "ShahnazRating";
            this.ShahnazRating.Size = new System.Drawing.Size(500, 41);
            this.ShahnazRating.StartIndex = 0;
            this.ShahnazRating.TabIndex = 2;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblReview.Location = new System.Drawing.Point(50, 210);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(179, 23);
            this.lblReview.TabIndex = 3;
            this.lblReview.Text = "Write your experience";
            // 
            // txtReview
            // 
            this.txtReview.Animated = true;
            this.txtReview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtReview.BorderRadius = 8;
            this.txtReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReview.DefaultText = "";
            this.txtReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.txtReview.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.txtReview.Location = new System.Drawing.Point(50, 240);
            this.txtReview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtReview.PlaceholderText = "Tell us what you loved (or what we can improve)...";
            this.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReview.SelectedText = "";
            this.txtReview.Size = new System.Drawing.Size(500, 130);
            this.txtReview.TabIndex = 4;
            this.txtReview.TextOffset = new System.Drawing.Point(5, 5);
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Animated = true;
            this.btnSubmitReview.BorderRadius = 10;
            this.btnSubmitReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitReview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnSubmitReview.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnSubmitReview.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnSubmitReview.Location = new System.Drawing.Point(50, 400);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(370, 50);
            this.btnSubmitReview.TabIndex = 5;
            this.btnSubmitReview.Text = "Submit Review";
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
            this.button1.Location = new System.Drawing.Point(435, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShahnazReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.guna2GradientPanelBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShahnazReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shahnaz Review";
            this.guna2GradientPanelBg.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Added Modern Elements
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanelBg;
        private Guna.UI2.WinForms.Guna2Panel panelCard;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;

        // Original Elements (Now mapped to Guna controls where appropriate)
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRating;
        private Guna.UI2.WinForms.Guna2ComboBox ShahnazRating;
        private System.Windows.Forms.Label lblReview;
        private Guna.UI2.WinForms.Guna2TextBox txtReview;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmitReview;
        private Guna.UI2.WinForms.Guna2Button button1;
    }
}