namespace Multi_Booking_System
{
    partial class TirthoDashboard
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
            this.BtnShowServiceTirtho = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.gridViewTirthoStore = new System.Windows.Forms.DataGridView();
            this.gridViewSelectedServices = new System.Windows.Forms.DataGridView();
            this.btnBookSerial = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTirthoStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedServices)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowServiceTirtho
            // 
            this.BtnShowServiceTirtho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowServiceTirtho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowServiceTirtho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShowServiceTirtho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShowServiceTirtho.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowServiceTirtho.ForeColor = System.Drawing.Color.White;
            this.BtnShowServiceTirtho.Location = new System.Drawing.Point(100, 84);
            this.BtnShowServiceTirtho.Name = "BtnShowServiceTirtho";
            this.BtnShowServiceTirtho.Size = new System.Drawing.Size(213, 45);
            this.BtnShowServiceTirtho.TabIndex = 0;
            this.BtnShowServiceTirtho.Text = "Show Service";
            this.BtnShowServiceTirtho.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(100, 308);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(213, 45);
            this.btnAddService.TabIndex = 1;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gridViewTirthoStore
            // 
            this.gridViewTirthoStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTirthoStore.Location = new System.Drawing.Point(518, 60);
            this.gridViewTirthoStore.Name = "gridViewTirthoStore";
            this.gridViewTirthoStore.RowHeadersWidth = 51;
            this.gridViewTirthoStore.RowTemplate.Height = 24;
            this.gridViewTirthoStore.Size = new System.Drawing.Size(341, 176);
            this.gridViewTirthoStore.TabIndex = 2;
            // 
            // gridViewSelectedServices
            // 
            this.gridViewSelectedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSelectedServices.Location = new System.Drawing.Point(518, 285);
            this.gridViewSelectedServices.Name = "gridViewSelectedServices";
            this.gridViewSelectedServices.RowHeadersWidth = 51;
            this.gridViewSelectedServices.RowTemplate.Height = 24;
            this.gridViewSelectedServices.Size = new System.Drawing.Size(341, 206);
            this.gridViewSelectedServices.TabIndex = 3;
            this.gridViewSelectedServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSelectedServices_CellContentClick);
            // 
            // btnBookSerial
            // 
            this.btnBookSerial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookSerial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookSerial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookSerial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookSerial.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSerial.ForeColor = System.Drawing.Color.White;
            this.btnBookSerial.Location = new System.Drawing.Point(100, 430);
            this.btnBookSerial.Name = "btnBookSerial";
            this.btnBookSerial.Size = new System.Drawing.Size(213, 45);
            this.btnBookSerial.TabIndex = 4;
            this.btnBookSerial.Text = "Book Serial";
            this.btnBookSerial.Click += new System.EventHandler(this.btnBookSerial_Click_1);
            // 
            // TirthoDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 525);
            this.Controls.Add(this.btnBookSerial);
            this.Controls.Add(this.gridViewSelectedServices);
            this.Controls.Add(this.gridViewTirthoStore);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.BtnShowServiceTirtho);
            this.Name = "TirthoDashboard";
            this.Text = "TirthoDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTirthoStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnShowServiceTirtho;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private System.Windows.Forms.DataGridView gridViewTirthoStore;
        private System.Windows.Forms.DataGridView gridViewSelectedServices;
        private Guna.UI2.WinForms.Guna2Button btnBookSerial;
    }
}