namespace Multi_Booking_System
{
    partial class TirthoApprove
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
            this.btnTirthoCustomerSerial = new Guna.UI2.WinForms.Guna2Button();
            this.gridViewTithoCustomerSerial = new System.Windows.Forms.DataGridView();
            this.btnTirthoApprove = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerSerialIdTirtho = new System.Windows.Forms.Label();
            this.txtboxTirthoCustomerSerial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTithoCustomerSerial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTirthoCustomerSerial
            // 
            this.btnTirthoCustomerSerial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTirthoCustomerSerial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTirthoCustomerSerial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTirthoCustomerSerial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTirthoCustomerSerial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTirthoCustomerSerial.ForeColor = System.Drawing.Color.White;
            this.btnTirthoCustomerSerial.Location = new System.Drawing.Point(24, 78);
            this.btnTirthoCustomerSerial.Name = "btnTirthoCustomerSerial";
            this.btnTirthoCustomerSerial.Size = new System.Drawing.Size(252, 45);
            this.btnTirthoCustomerSerial.TabIndex = 0;
            this.btnTirthoCustomerSerial.Text = "Customer Serial";
            this.btnTirthoCustomerSerial.Click += new System.EventHandler(this.btnTirthoCustomerSerial_Click);
            // 
            // gridViewTithoCustomerSerial
            // 
            this.gridViewTithoCustomerSerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTithoCustomerSerial.Location = new System.Drawing.Point(373, 78);
            this.gridViewTithoCustomerSerial.Name = "gridViewTithoCustomerSerial";
            this.gridViewTithoCustomerSerial.RowHeadersWidth = 51;
            this.gridViewTithoCustomerSerial.RowTemplate.Height = 24;
            this.gridViewTithoCustomerSerial.Size = new System.Drawing.Size(636, 217);
            this.gridViewTithoCustomerSerial.TabIndex = 1;
            this.gridViewTithoCustomerSerial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTithoCustomerSerial_CellContentClick);
            // 
            // btnTirthoApprove
            // 
            this.btnTirthoApprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTirthoApprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTirthoApprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTirthoApprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTirthoApprove.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTirthoApprove.ForeColor = System.Drawing.Color.White;
            this.btnTirthoApprove.Location = new System.Drawing.Point(829, 331);
            this.btnTirthoApprove.Name = "btnTirthoApprove";
            this.btnTirthoApprove.Size = new System.Drawing.Size(180, 45);
            this.btnTirthoApprove.TabIndex = 2;
            this.btnTirthoApprove.Text = "Approve";
            this.btnTirthoApprove.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // CustomerSerialIdTirtho
            // 
            this.CustomerSerialIdTirtho.AutoSize = true;
            this.CustomerSerialIdTirtho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSerialIdTirtho.Location = new System.Drawing.Point(18, 377);
            this.CustomerSerialIdTirtho.Name = "CustomerSerialIdTirtho";
            this.CustomerSerialIdTirtho.Size = new System.Drawing.Size(48, 32);
            this.CustomerSerialIdTirtho.TabIndex = 3;
            this.CustomerSerialIdTirtho.Text = "Id:";
            // 
            // txtboxTirthoCustomerSerial
            // 
            this.txtboxTirthoCustomerSerial.Location = new System.Drawing.Point(90, 377);
            this.txtboxTirthoCustomerSerial.Multiline = true;
            this.txtboxTirthoCustomerSerial.Name = "txtboxTirthoCustomerSerial";
            this.txtboxTirthoCustomerSerial.Size = new System.Drawing.Size(218, 32);
            this.txtboxTirthoCustomerSerial.TabIndex = 4;
            // 
            // TirthoApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 541);
            this.Controls.Add(this.txtboxTirthoCustomerSerial);
            this.Controls.Add(this.CustomerSerialIdTirtho);
            this.Controls.Add(this.btnTirthoApprove);
            this.Controls.Add(this.gridViewTithoCustomerSerial);
            this.Controls.Add(this.btnTirthoCustomerSerial);
            this.Name = "TirthoApprove";
            this.Text = "TirthoApprove";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTithoCustomerSerial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTirthoCustomerSerial;
        private System.Windows.Forms.DataGridView gridViewTithoCustomerSerial;
        private Guna.UI2.WinForms.Guna2Button btnTirthoApprove;
        private System.Windows.Forms.Label CustomerSerialIdTirtho;
        private System.Windows.Forms.TextBox txtboxTirthoCustomerSerial;
    }
}