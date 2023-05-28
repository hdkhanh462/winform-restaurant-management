namespace TripleX.v2.Table
{
    partial class Form_Table
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
            this.pnFilter = new System.Windows.Forms.Panel();
            this.btnAdd = new CustomControl.CButton();
            this.cGradientPanel2 = new CustomControl.CGradientPanel();
            this.rbBig = new CustomControl.CRadioButton();
            this.rbAvg = new CustomControl.CRadioButton();
            this.rbSmall = new CustomControl.CRadioButton();
            this.txtSearch = new CustomControl.CTextbox();
            this.cGradientPanel1 = new CustomControl.CGradientPanel();
            this.rbHasCustomer = new CustomControl.CRadioButton();
            this.rbOrdered = new CustomControl.CRadioButton();
            this.rbEmpty = new CustomControl.CRadioButton();
            this.pnSubFilter = new System.Windows.Forms.Panel();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.flpnTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnFilter.SuspendLayout();
            this.cGradientPanel2.SuspendLayout();
            this.cGradientPanel1.SuspendLayout();
            this.pnSubFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFilter
            // 
            this.pnFilter.Controls.Add(this.btnAdd);
            this.pnFilter.Controls.Add(this.cGradientPanel2);
            this.pnFilter.Controls.Add(this.txtSearch);
            this.pnFilter.Controls.Add(this.cGradientPanel1);
            this.pnFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFilter.Location = new System.Drawing.Point(894, 0);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(220, 571);
            this.pnFilter.TabIndex = 1;
            this.pnFilter.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomTag = "";
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnAdd.HoverColor = System.Drawing.Color.Empty;
            this.btnAdd.HoverImage = global::TripleX.v2.Properties.Resources.add_list_20px1;
            this.btnAdd.Image = global::TripleX.v2.Properties.Resources.add_list_20px;
            this.btnAdd.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnAdd.LeaveColor = System.Drawing.Color.White;
            this.btnAdd.LeaveImage = global::TripleX.v2.Properties.Resources.add_list_20px;
            this.btnAdd.Location = new System.Drawing.Point(160, 531);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(50, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // cGradientPanel2
            // 
            this.cGradientPanel2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cGradientPanel2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cGradientPanel2.BorderSize = 2;
            this.cGradientPanel2.Controls.Add(this.rbBig);
            this.cGradientPanel2.Controls.Add(this.rbAvg);
            this.cGradientPanel2.Controls.Add(this.rbSmall);
            this.cGradientPanel2.GradientAngle = 45F;
            this.cGradientPanel2.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.cGradientPanel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(75)))), ((int)(((byte)(213)))));
            this.cGradientPanel2.Location = new System.Drawing.Point(10, 190);
            this.cGradientPanel2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.cGradientPanel2.Name = "cGradientPanel2";
            this.cGradientPanel2.Radius = 10;
            this.cGradientPanel2.Size = new System.Drawing.Size(200, 129);
            this.cGradientPanel2.TabIndex = 2;
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbBig.Location = new System.Drawing.Point(30, 86);
            this.rbBig.Margin = new System.Windows.Forms.Padding(30, 0, 30, 20);
            this.rbBig.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbBig.Name = "rbBig";
            this.rbBig.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbBig.Size = new System.Drawing.Size(104, 23);
            this.rbBig.TabIndex = 2;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Bàn Lớn";
            this.rbBig.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.rbBig_CheckedChanged);
            // 
            // rbAvg
            // 
            this.rbAvg.AutoSize = true;
            this.rbAvg.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbAvg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAvg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbAvg.Location = new System.Drawing.Point(30, 53);
            this.rbAvg.Margin = new System.Windows.Forms.Padding(30, 0, 30, 10);
            this.rbAvg.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbAvg.Name = "rbAvg";
            this.rbAvg.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbAvg.Size = new System.Drawing.Size(105, 23);
            this.rbAvg.TabIndex = 1;
            this.rbAvg.TabStop = true;
            this.rbAvg.Text = "Bàn Vừa";
            this.rbAvg.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbAvg.UseVisualStyleBackColor = true;
            this.rbAvg.CheckedChanged += new System.EventHandler(this.rbAvg_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSmall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbSmall.Location = new System.Drawing.Point(30, 20);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.rbSmall.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbSmall.Size = new System.Drawing.Size(105, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Bàn Nhỏ";
            this.rbSmall.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.txtSearch.Location = new System.Drawing.Point(10, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(14, 7, 14, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Tên Bàn...";
            this.txtSearch.Size = new System.Drawing.Size(200, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // cGradientPanel1
            // 
            this.cGradientPanel1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cGradientPanel1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cGradientPanel1.BorderSize = 2;
            this.cGradientPanel1.Controls.Add(this.rbHasCustomer);
            this.cGradientPanel1.Controls.Add(this.rbOrdered);
            this.cGradientPanel1.Controls.Add(this.rbEmpty);
            this.cGradientPanel1.GradientAngle = 45F;
            this.cGradientPanel1.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.cGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(75)))), ((int)(((byte)(213)))));
            this.cGradientPanel1.Location = new System.Drawing.Point(10, 51);
            this.cGradientPanel1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.cGradientPanel1.Name = "cGradientPanel1";
            this.cGradientPanel1.Radius = 10;
            this.cGradientPanel1.Size = new System.Drawing.Size(200, 129);
            this.cGradientPanel1.TabIndex = 0;
            // 
            // rbHasCustomer
            // 
            this.rbHasCustomer.AutoSize = true;
            this.rbHasCustomer.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbHasCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHasCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHasCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbHasCustomer.Location = new System.Drawing.Point(30, 86);
            this.rbHasCustomer.Margin = new System.Windows.Forms.Padding(30, 0, 30, 20);
            this.rbHasCustomer.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbHasCustomer.Name = "rbHasCustomer";
            this.rbHasCustomer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbHasCustomer.Size = new System.Drawing.Size(139, 23);
            this.rbHasCustomer.TabIndex = 2;
            this.rbHasCustomer.Text = "Đã Có Khách";
            this.rbHasCustomer.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbHasCustomer.UseVisualStyleBackColor = true;
            this.rbHasCustomer.CheckedChanged += new System.EventHandler(this.rbHasCustomer_CheckedChanged);
            // 
            // rbOrdered
            // 
            this.rbOrdered.AutoSize = true;
            this.rbOrdered.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbOrdered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOrdered.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrdered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbOrdered.Location = new System.Drawing.Point(30, 53);
            this.rbOrdered.Margin = new System.Windows.Forms.Padding(30, 0, 30, 10);
            this.rbOrdered.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbOrdered.Name = "rbOrdered";
            this.rbOrdered.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbOrdered.Size = new System.Drawing.Size(137, 23);
            this.rbOrdered.TabIndex = 1;
            this.rbOrdered.Text = "Đã Được Đặt";
            this.rbOrdered.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbOrdered.UseVisualStyleBackColor = true;
            this.rbOrdered.CheckedChanged += new System.EventHandler(this.rbOrdered_CheckedChanged);
            // 
            // rbEmpty
            // 
            this.rbEmpty.AutoSize = true;
            this.rbEmpty.Checked = true;
            this.rbEmpty.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmpty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbEmpty.Location = new System.Drawing.Point(30, 20);
            this.rbEmpty.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.rbEmpty.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbEmpty.Name = "rbEmpty";
            this.rbEmpty.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbEmpty.Size = new System.Drawing.Size(118, 23);
            this.rbEmpty.TabIndex = 0;
            this.rbEmpty.TabStop = true;
            this.rbEmpty.Text = "Bàn Trống";
            this.rbEmpty.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbEmpty.UseVisualStyleBackColor = true;
            this.rbEmpty.CheckedChanged += new System.EventHandler(this.rbEmpty_CheckedChanged);
            // 
            // pnSubFilter
            // 
            this.pnSubFilter.Controls.Add(this.pbShow);
            this.pnSubFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSubFilter.Location = new System.Drawing.Point(854, 0);
            this.pnSubFilter.Name = "pnSubFilter";
            this.pnSubFilter.Size = new System.Drawing.Size(40, 571);
            this.pnSubFilter.TabIndex = 2;
            this.pnSubFilter.Visible = false;
            // 
            // pbShow
            // 
            this.pbShow.BackColor = System.Drawing.Color.Transparent;
            this.pbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbShow.Image = global::TripleX.v2.Properties.Resources.back_20px1;
            this.pbShow.Location = new System.Drawing.Point(0, 0);
            this.pbShow.Margin = new System.Windows.Forms.Padding(0);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(40, 571);
            this.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbShow.TabIndex = 0;
            this.pbShow.TabStop = false;
            this.pbShow.Click += new System.EventHandler(this.pbShow_Click);
            this.pbShow.MouseLeave += new System.EventHandler(this.pbShow_MouseLeave);
            // 
            // flpnTable
            // 
            this.flpnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnTable.Location = new System.Drawing.Point(0, 0);
            this.flpnTable.Name = "flpnTable";
            this.flpnTable.Size = new System.Drawing.Size(1114, 571);
            this.flpnTable.TabIndex = 3;
            this.flpnTable.MouseEnter += new System.EventHandler(this.flpnTable_MouseEnter);
            // 
            // Form_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 571);
            this.Controls.Add(this.pnSubFilter);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.flpnTable);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form_Table";
            this.Text = "Form_Table";
            this.pnFilter.ResumeLayout(false);
            this.cGradientPanel2.ResumeLayout(false);
            this.cGradientPanel2.PerformLayout();
            this.cGradientPanel1.ResumeLayout(false);
            this.cGradientPanel1.PerformLayout();
            this.pnSubFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.CTextbox txtSearch;
        private System.Windows.Forms.Panel pnFilter;
        private CustomControl.CGradientPanel cGradientPanel1;
        private System.Windows.Forms.Panel pnSubFilter;
        private CustomControl.CRadioButton rbEmpty;
        private CustomControl.CRadioButton rbOrdered;
        private CustomControl.CGradientPanel cGradientPanel2;
        private CustomControl.CRadioButton rbAvg;
        private CustomControl.CRadioButton rbSmall;
        private System.Windows.Forms.FlowLayoutPanel flpnTable;
        private System.Windows.Forms.PictureBox pbShow;
        private CustomControl.CRadioButton rbBig;
        private CustomControl.CButton btnAdd;
        private CustomControl.CRadioButton rbHasCustomer;
    }
}