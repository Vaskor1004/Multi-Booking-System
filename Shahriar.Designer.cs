namespace Multi_Booking_System
{
    partial class Shahriar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateServiceName = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.btnShahriarAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnShahriarUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnShahriarDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShahriarNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnShahriarCustomerShow = new Guna.UI2.WinForms.Guna2Button();
            this.ShahriarGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShahriarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shahriar Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Service Name :";
            // 
            // txtaddService
            // 
            this.txtaddService.Location = new System.Drawing.Point(279, 127);
            this.txtaddService.Name = "txtaddService";
            this.txtaddService.Size = new System.Drawing.Size(242, 22);
            this.txtaddService.TabIndex = 2;
            this.txtaddService.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(291, 187);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(242, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(366, 290);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(242, 22);
            this.txtId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Service Name(Update) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price(Update) :";
            // 
            // txtUpdateServiceName
            // 
            this.txtUpdateServiceName.Location = new System.Drawing.Point(366, 365);
            this.txtUpdateServiceName.Name = "txtUpdateServiceName";
            this.txtUpdateServiceName.Size = new System.Drawing.Size(242, 22);
            this.txtUpdateServiceName.TabIndex = 9;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(366, 423);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(242, 22);
            this.txtUpdatePrice.TabIndex = 10;
            // 
            // btnShahriarAdd
            // 
            this.btnShahriarAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShahriarAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShahriarAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShahriarAdd.ForeColor = System.Drawing.Color.White;
            this.btnShahriarAdd.Location = new System.Drawing.Point(558, 198);
            this.btnShahriarAdd.Name = "btnShahriarAdd";
            this.btnShahriarAdd.Size = new System.Drawing.Size(144, 44);
            this.btnShahriarAdd.TabIndex = 11;
            this.btnShahriarAdd.Text = "Add";
            this.btnShahriarAdd.Click += new System.EventHandler(this.btnShahriarAdd_Click);
            // 
            // btnShahriarUpdate
            // 
            this.btnShahriarUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShahriarUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShahriarUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShahriarUpdate.ForeColor = System.Drawing.Color.White;
            this.btnShahriarUpdate.Location = new System.Drawing.Point(149, 497);
            this.btnShahriarUpdate.Name = "btnShahriarUpdate";
            this.btnShahriarUpdate.Size = new System.Drawing.Size(144, 44);
            this.btnShahriarUpdate.TabIndex = 12;
            this.btnShahriarUpdate.Text = "Update";
            this.btnShahriarUpdate.Click += new System.EventHandler(this.btnShahriarUpdate_Click);
            // 
            // btnShahriarDelete
            // 
            this.btnShahriarDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShahriarDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShahriarDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShahriarDelete.ForeColor = System.Drawing.Color.White;
            this.btnShahriarDelete.Location = new System.Drawing.Point(424, 497);
            this.btnShahriarDelete.Name = "btnShahriarDelete";
            this.btnShahriarDelete.Size = new System.Drawing.Size(144, 44);
            this.btnShahriarDelete.TabIndex = 13;
            this.btnShahriarDelete.Text = "Delete";
            this.btnShahriarDelete.Click += new System.EventHandler(this.btnShahriarDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Show Service :";
            // 
            // btnShahriarNext
            // 
            this.btnShahriarNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShahriarNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShahriarNext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShahriarNext.ForeColor = System.Drawing.Color.White;
            this.btnShahriarNext.Location = new System.Drawing.Point(1083, 512);
            this.btnShahriarNext.Name = "btnShahriarNext";
            this.btnShahriarNext.Size = new System.Drawing.Size(144, 44);
            this.btnShahriarNext.TabIndex = 16;
            this.btnShahriarNext.Text = "Next";
            this.btnShahriarNext.Click += new System.EventHandler(this.btnShahriarNext_Click);
            // 
            // btnShahriarCustomerShow
            // 
            this.btnShahriarCustomerShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarCustomerShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShahriarCustomerShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShahriarCustomerShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShahriarCustomerShow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShahriarCustomerShow.ForeColor = System.Drawing.Color.White;
            this.btnShahriarCustomerShow.Location = new System.Drawing.Point(764, 365);
            this.btnShahriarCustomerShow.Name = "btnShahriarCustomerShow";
            this.btnShahriarCustomerShow.Size = new System.Drawing.Size(144, 44);
            this.btnShahriarCustomerShow.TabIndex = 17;
            this.btnShahriarCustomerShow.Text = "Show";
            this.btnShahriarCustomerShow.Click += new System.EventHandler(this.btnShahriarCustomerShow_Click);
            // 
            // ShahriarGridView
            // 
            this.ShahriarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShahriarGridView.Location = new System.Drawing.Point(764, 150);
            this.ShahriarGridView.Name = "ShahriarGridView";
            this.ShahriarGridView.ReadOnly = true;
            this.ShahriarGridView.RowHeadersWidth = 51;
            this.ShahriarGridView.RowTemplate.Height = 24;
            this.ShahriarGridView.Size = new System.Drawing.Size(343, 187);
            this.ShahriarGridView.TabIndex = 18;
            this.ShahriarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShahriarGridView_CellContentClick_1);
            // 
            // Shahriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 592);
            this.Controls.Add(this.ShahriarGridView);
            this.Controls.Add(this.btnShahriarCustomerShow);
            this.Controls.Add(this.btnShahriarNext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnShahriarDelete);
            this.Controls.Add(this.btnShahriarUpdate);
            this.Controls.Add(this.btnShahriarAdd);
            this.Controls.Add(this.txtUpdatePrice);
            this.Controls.Add(this.txtUpdateServiceName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Shahriar";
            this.Text = "Shahriar";
            ((System.ComponentModel.ISupportInitialize)(this.ShahriarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateServiceName;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private Guna.UI2.WinForms.Guna2Button btnShahriarAdd;
        private Guna.UI2.WinForms.Guna2Button btnShahriarUpdate;
        private Guna.UI2.WinForms.Guna2Button btnShahriarDelete;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnShahriarNext;
        private Guna.UI2.WinForms.Guna2Button btnShahriarCustomerShow;
        private System.Windows.Forms.DataGridView ShahriarGridView;
    }
}