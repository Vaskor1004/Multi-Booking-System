namespace Multi_Booking_System
{
    partial class TirthoSelun
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
            this.BtnGetSerial = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReview = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetSerial
            // 
            this.BtnGetSerial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGetSerial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGetSerial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGetSerial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGetSerial.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetSerial.ForeColor = System.Drawing.Color.White;
            this.BtnGetSerial.Location = new System.Drawing.Point(57, 206);
            this.BtnGetSerial.Name = "BtnGetSerial";
            this.BtnGetSerial.Size = new System.Drawing.Size(180, 45);
            this.BtnGetSerial.TabIndex = 0;
            this.BtnGetSerial.Text = "Get Serial";
            this.BtnGetSerial.Click += new System.EventHandler(this.BtnGetSerial_Click);
            // 
            // BtnReview
            // 
            this.BtnReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReview.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReview.ForeColor = System.Drawing.Color.White;
            this.BtnReview.Location = new System.Drawing.Point(57, 312);
            this.BtnReview.Name = "BtnReview";
            this.BtnReview.Size = new System.Drawing.Size(180, 45);
            this.BtnReview.TabIndex = 1;
            this.BtnReview.Text = "Review";
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogOut.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.Location = new System.Drawing.Point(57, 422);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(180, 45);
            this.BtnLogOut.TabIndex = 2;
            this.BtnLogOut.Text = "Log Out";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(349, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(209, 44);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Tirtho Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Multi_Booking_System.Properties.Resources.barber_cutting_hair_in_modern_salon_with_round_mirrors_and_shelves_of_hair_products_free_photo;
            this.pictureBox1.Location = new System.Drawing.Point(278, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TirthoSelun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 541);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnReview);
            this.Controls.Add(this.BtnGetSerial);
            this.Name = "TirthoSelun";
            this.Text = "TirthoSelun";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnGetSerial;
        private Guna.UI2.WinForms.Guna2Button BtnReview;
        private Guna.UI2.WinForms.Guna2Button BtnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}