namespace Multi_Booking_System
{
    partial class SompodApprove
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
            this.btnCustomerSerial = new Guna.UI2.WinForms.Guna2Button();
            this.gridViewCustomerSerial = new System.Windows.Forms.DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerSerial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerSerial
            // 
            this.btnCustomerSerial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerSerial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerSerial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerSerial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerSerial.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSerial.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSerial.Location = new System.Drawing.Point(38, 61);
            this.btnCustomerSerial.Name = "btnCustomerSerial";
            this.btnCustomerSerial.Size = new System.Drawing.Size(245, 45);
            this.btnCustomerSerial.TabIndex = 0;
            this.btnCustomerSerial.Text = "Customer Serial";
            this.btnCustomerSerial.Click += new System.EventHandler(this.btnCustomerSerial_Click);
            // 
            // gridViewCustomerSerial
            // 
            this.gridViewCustomerSerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCustomerSerial.Location = new System.Drawing.Point(401, 61);
            this.gridViewCustomerSerial.Name = "gridViewCustomerSerial";
            this.gridViewCustomerSerial.RowHeadersWidth = 51;
            this.gridViewCustomerSerial.RowTemplate.Height = 24;
            this.gridViewCustomerSerial.Size = new System.Drawing.Size(668, 237);
            this.gridViewCustomerSerial.TabIndex = 1;
            this.gridViewCustomerSerial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCustomerSerial_CellContentClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(760, 355);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(153, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Approve";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(144, 319);
            this.txtboxId.Multiline = true;
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(218, 38);
            this.txtboxId.TabIndex = 4;
            // 
            // SompodApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.gridViewCustomerSerial);
            this.Controls.Add(this.btnCustomerSerial);
            this.Name = "SompodApprove";
            this.Text = "SompodApprove";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerSerial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCustomerSerial;
        private System.Windows.Forms.DataGridView gridViewCustomerSerial;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxId;
    }
}