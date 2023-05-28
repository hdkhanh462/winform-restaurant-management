namespace TripleX.v2.Customer
{
    partial class Form_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.btnAdd = new CustomControl.CButton();
            this.txtSearch = new CustomControl.CTextbox();
            this.cGradientPanel1 = new CustomControl.CGradientPanel();
            this.rbHasCustomer = new CustomControl.CRadioButton();
            this.rbOrdered = new CustomControl.CRadioButton();
            this.rbAllSex = new CustomControl.CRadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new CustomControl.CButton();
            this.pnFilter.SuspendLayout();
            this.cGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFilter
            // 
            this.pnFilter.Controls.Add(this.btnAdd);
            this.pnFilter.Controls.Add(this.txtSearch);
            this.pnFilter.Controls.Add(this.cGradientPanel1);
            this.pnFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFilter.Location = new System.Drawing.Point(894, 0);
            this.pnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(220, 571);
            this.pnFilter.TabIndex = 3;
            this.pnFilter.Visible = false;
            this.pnFilter.MouseEnter += new System.EventHandler(this.pnFilter_MouseEnter);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.txtSearch.PlaceholderText = "Tìm kiếm...";
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
            this.cGradientPanel1.Controls.Add(this.rbAllSex);
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
            this.rbHasCustomer.Size = new System.Drawing.Size(95, 23);
            this.rbHasCustomer.TabIndex = 2;
            this.rbHasCustomer.Text = "Nữ giới";
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
            this.rbOrdered.Size = new System.Drawing.Size(106, 23);
            this.rbOrdered.TabIndex = 1;
            this.rbOrdered.Text = "Nam giới";
            this.rbOrdered.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbOrdered.UseVisualStyleBackColor = true;
            this.rbOrdered.CheckedChanged += new System.EventHandler(this.rbOrdered_CheckedChanged);
            // 
            // rbAllSex
            // 
            this.rbAllSex.AutoSize = true;
            this.rbAllSex.Checked = true;
            this.rbAllSex.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbAllSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAllSex.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbAllSex.Location = new System.Drawing.Point(30, 20);
            this.rbAllSex.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.rbAllSex.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbAllSex.Name = "rbAllSex";
            this.rbAllSex.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbAllSex.Size = new System.Drawing.Size(161, 23);
            this.rbAllSex.TabIndex = 0;
            this.rbAllSex.TabStop = true;
            this.rbAllSex.Text = "Giới tính(Tất Cả)";
            this.rbAllSex.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbAllSex.UseVisualStyleBackColor = true;
            this.rbAllSex.CheckedChanged += new System.EventHandler(this.rbAllSex_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(211, 59);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvCustomer.ColumnHeadersHeight = 30;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(10);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 50;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1114, 571);
            this.dgvCustomer.TabIndex = 5;
            this.dgvCustomer.MouseEnter += new System.EventHandler(this.flpnTable_MouseEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsMale";
            this.Column5.HeaderText = "IsMale";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Image = global::TripleX.v2.Properties.Resources.female_26px;
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "CName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CCCD";
            this.Column3.HeaderText = "CCCD";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CPhone";
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.BackgroundColor = System.Drawing.Color.White;
            this.btnShow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShow.BorderRadius = 10;
            this.btnShow.BorderSize = 0;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.CustomTag = "";
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnShow.HoverColor = System.Drawing.Color.Empty;
            this.btnShow.HoverImage = null;
            this.btnShow.Image = global::TripleX.v2.Properties.Resources.back_20px1;
            this.btnShow.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnShow.LeaveColor = System.Drawing.Color.White;
            this.btnShow.LeaveImage = null;
            this.btnShow.Location = new System.Drawing.Point(854, 255);
            this.btnShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnShow.Size = new System.Drawing.Size(40, 60);
            this.btnShow.TabIndex = 7;
            this.btnShow.TextColor = System.Drawing.Color.White;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.pbShow_Click);
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 571);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvCustomer);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Customer";
            this.Text = "Form_Customer";
            this.pnFilter.ResumeLayout(false);
            this.cGradientPanel1.ResumeLayout(false);
            this.cGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnFilter;
        private CustomControl.CButton btnAdd;
        private CustomControl.CTextbox txtSearch;
        private CustomControl.CGradientPanel cGradientPanel1;
        private CustomControl.CRadioButton rbHasCustomer;
        private CustomControl.CRadioButton rbOrdered;
        private CustomControl.CRadioButton rbAllSex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private CustomControl.CButton btnShow;
    }
}