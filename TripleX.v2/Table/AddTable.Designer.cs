namespace TripleX.v2.Table
{
    partial class AddTable
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
            this.txtChair = new MaterialSkin.Controls.MaterialTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSave = new CustomControl.CButton();
            this.btnClose = new CustomControl.CButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.txtChair);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 170);
            this.panel1.TabIndex = 12;
            // 
            // txtChair
            // 
            this.txtChair.AnimateReadOnly = false;
            this.txtChair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtChair.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChair.Depth = 0;
            this.txtChair.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtChair.Hint = "Số Ghế";
            this.txtChair.LeadingIcon = null;
            this.txtChair.Location = new System.Drawing.Point(10, 110);
            this.txtChair.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.txtChair.MaxLength = 50;
            this.txtChair.MouseState = MaterialSkin.MouseState.OUT;
            this.txtChair.Multiline = false;
            this.txtChair.Name = "txtChair";
            this.txtChair.Size = new System.Drawing.Size(386, 50);
            this.txtChair.TabIndex = 20;
            this.txtChair.Text = "";
            this.txtChair.TrailingIcon = null;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Hint = "Tên Bàn";
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(10, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(10);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(386, 50);
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
            this.panel2.Size = new System.Drawing.Size(406, 40);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.Controls.Add(this.btnSave);
            this.panel10.Controls.Add(this.btnClose);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Location = new System.Drawing.Point(19, 199);
            this.panel10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(406, 40);
            this.panel10.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomTag = "";
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSave.HoverImage = null;
            this.btnSave.Image = global::TripleX.v2.Properties.Resources.downloading_updates_26px;
            this.btnSave.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnSave.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.LeaveImage = null;
            this.btnSave.Location = new System.Drawing.Point(296, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomTag = "";
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnClose.HoverImage = null;
            this.btnClose.Image = global::TripleX.v2.Properties.Resources.reply_arrow_26px;
            this.btnClose.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnClose.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClose.LeaveImage = null;
            this.btnClose.Location = new System.Drawing.Point(346, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gainsboro;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(396, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 40);
            this.panel12.TabIndex = 15;
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(444, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTable";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtChair;
        private System.Windows.Forms.Panel panel10;
        private CustomControl.CButton btnSave;
        private CustomControl.CButton btnClose;
        private System.Windows.Forms.Panel panel12;
    }
}