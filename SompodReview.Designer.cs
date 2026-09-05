//namespace Multi_Booking_System
//{
//    partial class SompodReview
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
//            this.Text = "SompodReview";
//        }

//        #endregion
//    }
//}


namespace Multi_Booking_System
{
    partial class SompodReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox SompodRating;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Button btnSubmitReview;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.SompodRating = new System.Windows.Forms.ComboBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(309, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(368, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sompod Store Review";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRating.Location = new System.Drawing.Point(206, 128);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(75, 25);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating:";
            // 
            // SompodRating
            // 
            this.SompodRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SompodRating.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SompodRating.FormattingEnabled = true;
            this.SompodRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.SompodRating.Location = new System.Drawing.Point(320, 125);
            this.SompodRating.Name = "SompodRating";
            this.SompodRating.Size = new System.Drawing.Size(342, 33);
            this.SompodRating.TabIndex = 2;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReview.Location = new System.Drawing.Point(206, 187);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(126, 25);
            this.lblReview.TabIndex = 3;
            this.lblReview.Text = "Your Review:";
            // 
            // txtReview
            // 
            this.txtReview.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtReview.Location = new System.Drawing.Point(206, 224);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReview.Size = new System.Drawing.Size(457, 106);
            this.txtReview.TabIndex = 4;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmitReview.Location = new System.Drawing.Point(320, 363);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(229, 48);
            this.btnSubmitReview.TabIndex = 5;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // SompodReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.SompodRating);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.btnSubmitReview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SompodReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sompod Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}