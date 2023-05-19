namespace TripleX.v2.Customer
{
    partial class CCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnSex = new CustomControl.CButton();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbName.Size = new System.Drawing.Size(198, 40);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Hoang Duong Khanh";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbCCCD
            // 
            this.lbCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lbCCCD.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.lbCCCD.Location = new System.Drawing.Point(198, 0);
            this.lbCCCD.Margin = new System.Windows.Forms.Padding(0);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbCCCD.Size = new System.Drawing.Size(130, 40);
            this.lbCCCD.TabIndex = 1;
            this.lbCCCD.Text = "1234567890123";
            this.lbCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCCCD.Click += new System.EventHandler(this.lbCCCD_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lbPhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.lbPhone.Location = new System.Drawing.Point(328, 0);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbPhone.Size = new System.Drawing.Size(100, 40);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "0123456789";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPhone.Click += new System.EventHandler(this.lbPhone_Click);
            // 
            // btnSex
            // 
            this.btnSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSex.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSex.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSex.BorderRadius = 0;
            this.btnSex.BorderSize = 0;
            this.btnSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSex.CustomTag = "";
            this.btnSex.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSex.FlatAppearance.BorderSize = 0;
            this.btnSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSex.ForeColor = System.Drawing.Color.White;
            this.btnSex.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnSex.HoverColor = System.Drawing.Color.Empty;
            this.btnSex.HoverImage = null;
            this.btnSex.Image = global::TripleX.v2.Properties.Resources.female_26px;
            this.btnSex.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnSex.LeaveColor = System.Drawing.Color.Empty;
            this.btnSex.LeaveImage = null;
            this.btnSex.Location = new System.Drawing.Point(428, 0);
            this.btnSex.Name = "btnSex";
            this.btnSex.Size = new System.Drawing.Size(40, 40);
            this.btnSex.TabIndex = 3;
            this.btnSex.TextColor = System.Drawing.Color.White;
            this.btnSex.UseVisualStyleBackColor = false;
            // 
            // CCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCCCD);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.btnSex);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CCustomer";
            this.Size = new System.Drawing.Size(468, 40);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label lbCCCD;
        public System.Windows.Forms.Label lbPhone;
        public CustomControl.CButton btnSex;
    }
}
