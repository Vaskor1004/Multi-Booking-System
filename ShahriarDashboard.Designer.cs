namespace Multi_Booking_System
{
    partial class ShahriarDashboard
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
            this.btnShahriarStoreService = new Guna.UI2.WinForms.Guna2Button();
            this.btnStoreAddService = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.gridviewShahriarService = new System.Windows.Forms.DataGridView();
            this.gridviewSelctedServices = new System.Windows.Forms.DataGridView();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewShahriarService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSelctedServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShahriarStoreService
            // 
            this.btnShahriarStoreService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarStoreService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarStoreService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShahriarStoreService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShahriarStoreService.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShahriarStoreService.ForeColor = System.Drawing.Color.White;
            this.btnShahriarStoreService.Location = new System.Drawing.Point(26, 86);
            this.btnShahriarStoreService.Name = "btnShahriarStoreService";
            this.btnShahriarStoreService.Size = new System.Drawing.Size(211, 46);
            this.btnShahriarStoreService.TabIndex = 0;
            this.btnShahriarStoreService.Text = "Show Service";
            this.btnShahriarStoreService.Click += new System.EventHandler(this.guna2Button1Shahriar_Click);
            // 
            // btnStoreAddService
            // 
            this.btnStoreAddService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreAddService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreAddService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStoreAddService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStoreAddService.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreAddService.ForeColor = System.Drawing.Color.White;
            this.btnStoreAddService.Location = new System.Drawing.Point(26, 175);
            this.btnStoreAddService.Name = "btnStoreAddService";
            this.btnStoreAddService.Size = new System.Drawing.Size(211, 46);
            this.btnStoreAddService.TabIndex = 1;
            this.btnStoreAddService.Text = "Add Service";
            this.btnStoreAddService.Click += new System.EventHandler(this.btnStoreAddService_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(26, 272);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(211, 46);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Book Serial";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gridviewShahriarService
            // 
            this.gridviewShahriarService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewShahriarService.Location = new System.Drawing.Point(354, 44);
            this.gridviewShahriarService.Name = "gridviewShahriarService";
            this.gridviewShahriarService.RowHeadersWidth = 51;
            this.gridviewShahriarService.RowTemplate.Height = 24;
            this.gridviewShahriarService.Size = new System.Drawing.Size(475, 157);
            this.gridviewShahriarService.TabIndex = 3;
            // 
            // gridviewSelctedServices
            // 
            this.gridviewSelctedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewSelctedServices.Location = new System.Drawing.Point(354, 250);
            this.gridviewSelctedServices.Name = "gridviewSelctedServices";
            this.gridviewSelctedServices.RowHeadersWidth = 51;
            this.gridviewSelctedServices.RowTemplate.Height = 24;
            this.gridviewSelctedServices.Size = new System.Drawing.Size(346, 206);
            this.gridviewSelctedServices.TabIndex = 4;
            this.gridviewSelctedServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSelctedServices_CellContentClick);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(26, 360);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(211, 46);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "Back";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // ShahriarDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 495);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.gridviewSelctedServices);
            this.Controls.Add(this.gridviewShahriarService);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnStoreAddService);
            this.Controls.Add(this.btnShahriarStoreService);
            this.Name = "ShahriarDashboard";
            this.Text = "ShahriarDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewShahriarService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSelctedServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShahriarStoreService;
        private Guna.UI2.WinForms.Guna2Button btnStoreAddService;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridView gridviewShahriarService;
        private System.Windows.Forms.DataGridView gridviewSelctedServices;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}