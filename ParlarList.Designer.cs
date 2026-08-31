//namespace Multi_Booking_System
//{
//    partial class ParlarList
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
//            this.Text = "ParlarList";
//        }

//        #endregion
//    }
//}

namespace Multi_Booking_System
{
    partial class ParlarList
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnRoxyStore = new Guna.UI2.WinForms.Guna2Button();
            this.picboxRoxy = new System.Windows.Forms.PictureBox();
            this.labelRoxy = new System.Windows.Forms.Label();
            this.panel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnShahnazStore = new Guna.UI2.WinForms.Guna2Button();
            this.picboxShahnaz = new System.Windows.Forms.PictureBox();
            this.labelShahnaz = new System.Windows.Forms.Label();
            this.panel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnDiyaStore = new Guna.UI2.WinForms.Guna2Button();
            this.picboxDiya = new System.Windows.Forms.PictureBox();
            this.labelDiya = new System.Windows.Forms.Label();
            this.btnparlarlistBack = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRoxy)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShahnaz)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDiya)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.labelTitle.Location = new System.Drawing.Point(460, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(210, 54);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Parlar List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRoxyStore);
            this.panel1.Controls.Add(this.picboxRoxy);
            this.panel1.Controls.Add(this.labelRoxy);
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(60, 120);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 15;
            this.panel1.ShadowColor = System.Drawing.Color.Black;
            this.panel1.ShadowDepth = 30;
            this.panel1.ShadowShift = 8;
            this.panel1.Size = new System.Drawing.Size(300, 440);
            this.panel1.TabIndex = 1;
            // 
            // btnRoxyStore
            // 
            this.btnRoxyStore.Animated = true;
            this.btnRoxyStore.BorderRadius = 8;
            this.btnRoxyStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoxyStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnRoxyStore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRoxyStore.ForeColor = System.Drawing.Color.White;
            this.btnRoxyStore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btnRoxyStore.Location = new System.Drawing.Point(20, 375);
            this.btnRoxyStore.Name = "btnRoxyStore";
            this.btnRoxyStore.Size = new System.Drawing.Size(260, 45);
            this.btnRoxyStore.TabIndex = 2;
            this.btnRoxyStore.Text = "View Details";
            this.btnRoxyStore.Click += new System.EventHandler(this.btnRoxyStore_Click);
            // 
            // picboxRoxy
            // 
            this.picboxRoxy.Image = global::Multi_Booking_System.Properties.Resources.Parlar2;
            this.picboxRoxy.Location = new System.Drawing.Point(20, 65);
            this.picboxRoxy.Name = "picboxRoxy";
            this.picboxRoxy.Size = new System.Drawing.Size(260, 290);
            this.picboxRoxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxRoxy.TabIndex = 1;
            this.picboxRoxy.TabStop = false;
            // 
            // labelRoxy
            // 
            this.labelRoxy.AutoSize = true;
            this.labelRoxy.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoxy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelRoxy.Location = new System.Drawing.Point(15, 15);
            this.labelRoxy.Name = "labelRoxy";
            this.labelRoxy.Size = new System.Drawing.Size(157, 38);
            this.labelRoxy.TabIndex = 0;
            this.labelRoxy.Text = "Roxy Store";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnShahnazStore);
            this.panel2.Controls.Add(this.picboxShahnaz);
            this.panel2.Controls.Add(this.labelShahnaz);
            this.panel2.FillColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(415, 120);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 15;
            this.panel2.ShadowColor = System.Drawing.Color.Black;
            this.panel2.ShadowDepth = 30;
            this.panel2.ShadowShift = 8;
            this.panel2.Size = new System.Drawing.Size(300, 440);
            this.panel2.TabIndex = 2;
            // 
            // btnShahnazStore
            // 
            this.btnShahnazStore.Animated = true;
            this.btnShahnazStore.BorderRadius = 8;
            this.btnShahnazStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShahnazStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnShahnazStore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShahnazStore.ForeColor = System.Drawing.Color.White;
            this.btnShahnazStore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btnShahnazStore.Location = new System.Drawing.Point(20, 375);
            this.btnShahnazStore.Name = "btnShahnazStore";
            this.btnShahnazStore.Size = new System.Drawing.Size(260, 45);
            this.btnShahnazStore.TabIndex = 2;
            this.btnShahnazStore.Text = "View Details";
            this.btnShahnazStore.Click += new System.EventHandler(this.btnShahnazStore_Click);
            // 
            // picboxShahnaz
            // 
            this.picboxShahnaz.Image = global::Multi_Booking_System.Properties.Resources.Parlar1;
            this.picboxShahnaz.Location = new System.Drawing.Point(20, 65);
            this.picboxShahnaz.Name = "picboxShahnaz";
            this.picboxShahnaz.Size = new System.Drawing.Size(260, 290);
            this.picboxShahnaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxShahnaz.TabIndex = 1;
            this.picboxShahnaz.TabStop = false;
            // 
            // labelShahnaz
            // 
            this.labelShahnaz.AutoSize = true;
            this.labelShahnaz.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShahnaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelShahnaz.Location = new System.Drawing.Point(15, 15);
            this.labelShahnaz.Name = "labelShahnaz";
            this.labelShahnaz.Size = new System.Drawing.Size(204, 38);
            this.labelShahnaz.TabIndex = 0;
            this.labelShahnaz.Text = "Shahnaz Store";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnDiyaStore);
            this.panel3.Controls.Add(this.picboxDiya);
            this.panel3.Controls.Add(this.labelDiya);
            this.panel3.FillColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(770, 120);
            this.panel3.Name = "panel3";
            this.panel3.Radius = 15;
            this.panel3.ShadowColor = System.Drawing.Color.Black;
            this.panel3.ShadowDepth = 30;
            this.panel3.ShadowShift = 8;
            this.panel3.Size = new System.Drawing.Size(300, 440);
            this.panel3.TabIndex = 3;
            // 
            // btnDiyaStore
            // 
            this.btnDiyaStore.Animated = true;
            this.btnDiyaStore.BorderRadius = 8;
            this.btnDiyaStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiyaStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnDiyaStore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDiyaStore.ForeColor = System.Drawing.Color.White;
            this.btnDiyaStore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btnDiyaStore.Location = new System.Drawing.Point(20, 375);
            this.btnDiyaStore.Name = "btnDiyaStore";
            this.btnDiyaStore.Size = new System.Drawing.Size(260, 45);
            this.btnDiyaStore.TabIndex = 2;
            this.btnDiyaStore.Text = "View Details";
            this.btnDiyaStore.Click += new System.EventHandler(this.btnDiyaStore_Click);
            // 
            // picboxDiya
            // 
            this.picboxDiya.Image = global::Multi_Booking_System.Properties.Resources.Parlar3;
            this.picboxDiya.Location = new System.Drawing.Point(20, 65);
            this.picboxDiya.Name = "picboxDiya";
            this.picboxDiya.Size = new System.Drawing.Size(260, 290);
            this.picboxDiya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxDiya.TabIndex = 1;
            this.picboxDiya.TabStop = false;
            // 
            // labelDiya
            // 
            this.labelDiya.AutoSize = true;
            this.labelDiya.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDiya.Location = new System.Drawing.Point(15, 15);
            this.labelDiya.Name = "labelDiya";
            this.labelDiya.Size = new System.Drawing.Size(153, 38);
            this.labelDiya.TabIndex = 0;
            this.labelDiya.Text = "Diya Store";
            // 
            // btnparlarlistBack
            // 
            this.btnparlarlistBack.Animated = true;
            this.btnparlarlistBack.BorderRadius = 8;
            this.btnparlarlistBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnparlarlistBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnparlarlistBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnparlarlistBack.ForeColor = System.Drawing.Color.White;
            this.btnparlarlistBack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnparlarlistBack.Location = new System.Drawing.Point(990, 35);
            this.btnparlarlistBack.Name = "btnparlarlistBack";
            this.btnparlarlistBack.Size = new System.Drawing.Size(120, 45);
            this.btnparlarlistBack.TabIndex = 4;
            this.btnparlarlistBack.Text = "Back";
            this.btnparlarlistBack.Click += new System.EventHandler(this.btnparlarlistBack_Click);
            // 
            // ParlarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1130, 620);
            this.Controls.Add(this.btnparlarlistBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Name = "ParlarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parlar List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRoxy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShahnaz)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDiya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;

        private Guna.UI2.WinForms.Guna2ShadowPanel panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel3;

        private System.Windows.Forms.Label labelRoxy;
        private System.Windows.Forms.Label labelShahnaz;
        private System.Windows.Forms.Label labelDiya;

        private Guna.UI2.WinForms.Guna2Button btnRoxyStore;
        private System.Windows.Forms.PictureBox picboxRoxy;

        private Guna.UI2.WinForms.Guna2Button btnShahnazStore;
        private System.Windows.Forms.PictureBox picboxShahnaz;

        private Guna.UI2.WinForms.Guna2Button btnDiyaStore;
        private System.Windows.Forms.PictureBox picboxDiya;

        private Guna.UI2.WinForms.Guna2Button btnparlarlistBack;
    }
}
