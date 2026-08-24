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
            this.BtnAddServiceTirtho = new Guna.UI2.WinForms.Guna2Button();
            this.gridViewTirthoStore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTirthoStore)).BeginInit();
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
            // BtnAddServiceTirtho
            // 
            this.BtnAddServiceTirtho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddServiceTirtho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddServiceTirtho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddServiceTirtho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddServiceTirtho.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddServiceTirtho.ForeColor = System.Drawing.Color.White;
            this.BtnAddServiceTirtho.Location = new System.Drawing.Point(100, 316);
            this.BtnAddServiceTirtho.Name = "BtnAddServiceTirtho";
            this.BtnAddServiceTirtho.Size = new System.Drawing.Size(213, 45);
            this.BtnAddServiceTirtho.TabIndex = 1;
            this.BtnAddServiceTirtho.Text = "Add Service";
            this.BtnAddServiceTirtho.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gridViewTirthoStore
            // 
            this.gridViewTirthoStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTirthoStore.Location = new System.Drawing.Point(459, 56);
            this.gridViewTirthoStore.Name = "gridViewTirthoStore";
            this.gridViewTirthoStore.RowHeadersWidth = 51;
            this.gridViewTirthoStore.RowTemplate.Height = 24;
            this.gridViewTirthoStore.Size = new System.Drawing.Size(341, 176);
            this.gridViewTirthoStore.TabIndex = 2;
            // 
            // TirthoDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewTirthoStore);
            this.Controls.Add(this.BtnAddServiceTirtho);
            this.Controls.Add(this.BtnShowServiceTirtho);
            this.Name = "TirthoDashboard";
            this.Text = "TirthoDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTirthoStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnShowServiceTirtho;
        private Guna.UI2.WinForms.Guna2Button BtnAddServiceTirtho;
        private System.Windows.Forms.DataGridView gridViewTirthoStore;
    }
}