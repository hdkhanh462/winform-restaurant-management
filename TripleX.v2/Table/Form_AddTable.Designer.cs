namespace TripleX.v2.Table
{
    partial class Form_AddTable
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
            this.pnContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new CustomControl.CTextbox();
            this.txtChair = new CustomControl.CTextbox();
            this.btnSave = new CustomControl.CButton();
            this.btnClose = new CustomControl.CButton();
            this.pnContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.btnSave);
            this.pnContainer.Controls.Add(this.btnClose);
            this.pnContainer.Controls.Add(this.txtChair);
            this.pnContainer.Controls.Add(this.txtName);
            this.pnContainer.Controls.Add(this.panel2);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(384, 192);
            this.pnContainer.TabIndex = 0;
            this.pnContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContainer_Paint);
            this.pnContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 40);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.txtName.BorderRadius = 10;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.txtName.Location = new System.Drawing.Point(10, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "Tên Bàn...";
            this.txtName.Size = new System.Drawing.Size(364, 31);
            this.txtName.TabIndex = 17;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtChair
            // 
            this.txtChair.BackColor = System.Drawing.Color.White;
            this.txtChair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.txtChair.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.txtChair.BorderRadius = 10;
            this.txtChair.BorderSize = 2;
            this.txtChair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.txtChair.Location = new System.Drawing.Point(10, 111);
            this.txtChair.Margin = new System.Windows.Forms.Padding(10);
            this.txtChair.Multiline = false;
            this.txtChair.Name = "txtChair";
            this.txtChair.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtChair.PasswordChar = false;
            this.txtChair.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChair.PlaceholderText = "Số Ghế...";
            this.txtChair.Size = new System.Drawing.Size(364, 31);
            this.txtChair.TabIndex = 18;
            this.txtChair.Texts = "";
            this.txtChair.UnderlinedStyle = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomTag = "";
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnSave.HoverColor = System.Drawing.Color.Empty;
            this.btnSave.HoverImage = global::TripleX.v2.Properties.Resources.save_close_20px1;
            this.btnSave.Image = global::TripleX.v2.Properties.Resources.save_close_20px;
            this.btnSave.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnSave.LeaveColor = System.Drawing.Color.White;
            this.btnSave.LeaveImage = global::TripleX.v2.Properties.Resources.save_close_20px;
            this.btnSave.Location = new System.Drawing.Point(284, 152);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(40, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomTag = "";
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnClose.HoverColor = System.Drawing.Color.Empty;
            this.btnClose.HoverImage = global::TripleX.v2.Properties.Resources.right_2_20px1;
            this.btnClose.Image = global::TripleX.v2.Properties.Resources.right_2_20px;
            this.btnClose.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnClose.LeaveColor = System.Drawing.Color.White;
            this.btnClose.LeaveImage = global::TripleX.v2.Properties.Resources.right_2_20px;
            this.btnClose.Location = new System.Drawing.Point(334, 152);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.Controls.Add(this.pnContainer);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddTable";
            this.Activated += new System.EventHandler(this.Form_RoundExample_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form_RoundExample_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form_RoundExample_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_RoundExample_Paint);
            this.pnContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private CustomControl.CTextbox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomControl.CTextbox txtChair;
        private CustomControl.CButton btnClose;
        private CustomControl.CButton btnSave;
    }
}