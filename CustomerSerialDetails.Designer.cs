namespace Multi_Booking_System
{
    partial class CustomerSerialDetails
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
            this.btnCustomerSerialDetails = new Guna.UI2.WinForms.Guna2Button();
            this.gridViewSerialDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerSerialDetails
            // 
            this.btnCustomerSerialDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerSerialDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerSerialDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerSerialDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerSerialDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSerialDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSerialDetails.Location = new System.Drawing.Point(311, 282);
            this.btnCustomerSerialDetails.Name = "btnCustomerSerialDetails";
            this.btnCustomerSerialDetails.Size = new System.Drawing.Size(180, 45);
            this.btnCustomerSerialDetails.TabIndex = 0;
            this.btnCustomerSerialDetails.Text = "Details";
            this.btnCustomerSerialDetails.Click += new System.EventHandler(this.btnCustomerSerialDetails_Click);
            // 
            // gridViewSerialDetails
            // 
            this.gridViewSerialDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSerialDetails.Location = new System.Drawing.Point(45, 35);
            this.gridViewSerialDetails.Name = "gridViewSerialDetails";
            this.gridViewSerialDetails.RowHeadersWidth = 51;
            this.gridViewSerialDetails.RowTemplate.Height = 24;
            this.gridViewSerialDetails.Size = new System.Drawing.Size(701, 187);
            this.gridViewSerialDetails.TabIndex = 1;
            // 
            // CustomerSerialDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewSerialDetails);
            this.Controls.Add(this.btnCustomerSerialDetails);
            this.Name = "CustomerSerialDetails";
            this.Text = "CustomerSerialDetails";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCustomerSerialDetails;
        private System.Windows.Forms.DataGridView gridViewSerialDetails;
    }
}