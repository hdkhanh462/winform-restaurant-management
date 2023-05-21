namespace TripleX.v2.Customer
{
    partial class AddCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtCCCD = new MaterialSkin.Controls.MaterialTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 280);
            this.panel1.TabIndex = 16;
            // 
            // rbFemale
            // 
            this.rbFemale.Depth = 0;
            this.rbFemale.Location = new System.Drawing.Point(100, 230);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Ripple = true;
            this.rbFemale.Size = new System.Drawing.Size(80, 40);
            this.rbFemale.TabIndex = 25;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Depth = 0;
            this.rbMale.Location = new System.Drawing.Point(10, 230);
            this.rbMale.Margin = new System.Windows.Forms.Padding(0);
            this.rbMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMale.Name = "rbMale";
            this.rbMale.Ripple = true;
            this.rbMale.Size = new System.Drawing.Size(80, 40);
            this.rbMale.TabIndex = 24;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // txtCCCD
            // 
            this.txtCCCD.AnimateReadOnly = false;
            this.txtCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Depth = 0;
            this.txtCCCD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCCCD.Hint = "CCCD";
            this.txtCCCD.LeadingIcon = null;
            this.txtCCCD.Location = new System.Drawing.Point(10, 110);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.txtCCCD.MaxLength = 50;
            this.txtCCCD.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCCCD.Multiline = false;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(400, 50);
            this.txtCCCD.TabIndex = 20;
            this.txtCCCD.Text = "";
            this.txtCCCD.TrailingIcon = null;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Hint = "Tên Khách Hàng";
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(10, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(10);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 50);
            this.txtName.TabIndex = 16;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 40);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.Hint = "Số Điện Thoại";
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(10, 170);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(400, 50);
            this.txtPhone.TabIndex = 22;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel10.Controls.Add(this.btnSave);
            this.panel10.Controls.Add(this.btnClose);
            this.panel10.Location = new System.Drawing.Point(19, 309);
            this.panel10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(420, 40);
            this.panel10.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnSave.IconSize = 32;
            this.btnSave.Location = new System.Drawing.Point(320, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(50, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(370, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(458, 368);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtCCCD;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRadioButton rbFemale;
        private MaterialSkin.Controls.MaterialRadioButton rbMale;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}