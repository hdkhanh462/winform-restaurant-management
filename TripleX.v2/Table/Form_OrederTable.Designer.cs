namespace TripleX.v2.Table
{
    partial class Form_OrederTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.btnDelete = new CustomControl.CButton();
            this.btnSave = new CustomControl.CButton();
            this.btnClose = new CustomControl.CButton();
            this.rbTake = new CustomControl.CRadioButton();
            this.rbOrder = new CustomControl.CRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTakeTime = new CustomControl.CDatePicker();
            this.dtpTakeDate = new CustomControl.CDatePicker();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCName = new CustomControl.CTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.White;
            this.pnContainer.Controls.Add(this.btnDelete);
            this.pnContainer.Controls.Add(this.btnSave);
            this.pnContainer.Controls.Add(this.btnClose);
            this.pnContainer.Controls.Add(this.rbTake);
            this.pnContainer.Controls.Add(this.rbOrder);
            this.pnContainer.Controls.Add(this.label5);
            this.pnContainer.Controls.Add(this.dtpTakeTime);
            this.pnContainer.Controls.Add(this.dtpTakeDate);
            this.pnContainer.Controls.Add(this.lbCurrentTime);
            this.pnContainer.Controls.Add(this.label2);
            this.pnContainer.Controls.Add(this.txtCName);
            this.pnContainer.Controls.Add(this.label4);
            this.pnContainer.Controls.Add(this.panel2);
            this.pnContainer.Controls.Add(this.dataGridView1);
            this.pnContainer.Controls.Add(this.dgvCustomer);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(677, 376);
            this.pnContainer.TabIndex = 0;
            this.pnContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContainer_Paint);
            this.pnContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomTag = "";
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnDelete.HoverColor = System.Drawing.Color.Empty;
            this.btnDelete.HoverImage = global::TripleX.v2.Properties.Resources.save_close_20px1;
            this.btnDelete.Image = global::TripleX.v2.Properties.Resources.save_close_20px;
            this.btnDelete.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnDelete.LeaveColor = System.Drawing.Color.White;
            this.btnDelete.LeaveImage = global::TripleX.v2.Properties.Resources.save_close_20px;
            this.btnDelete.Location = new System.Drawing.Point(527, 336);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(40, 30);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Location = new System.Drawing.Point(577, 336);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(40, 30);
            this.btnSave.TabIndex = 28;
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
            this.btnClose.Location = new System.Drawing.Point(627, 336);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 27;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rbTake
            // 
            this.rbTake.AutoSize = true;
            this.rbTake.Checked = true;
            this.rbTake.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbTake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTake.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbTake.Location = new System.Drawing.Point(430, 287);
            this.rbTake.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.rbTake.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbTake.Name = "rbTake";
            this.rbTake.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbTake.Size = new System.Drawing.Size(114, 23);
            this.rbTake.TabIndex = 26;
            this.rbTake.TabStop = true;
            this.rbTake.Text = "Nhận Bàn";
            this.rbTake.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbTake.UseVisualStyleBackColor = true;
            this.rbTake.CheckedChanged += new System.EventHandler(this.rbTake_CheckedChanged);
            // 
            // rbOrder
            // 
            this.rbOrder.AutoSize = true;
            this.rbOrder.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.rbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.rbOrder.Location = new System.Drawing.Point(430, 254);
            this.rbOrder.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.rbOrder.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbOrder.Name = "rbOrder";
            this.rbOrder.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbOrder.Size = new System.Drawing.Size(115, 23);
            this.rbOrder.TabIndex = 25;
            this.rbOrder.Text = "Đặt Trước";
            this.rbOrder.UnCheckedColor = System.Drawing.Color.DarkGray;
            this.rbOrder.UseVisualStyleBackColor = true;
            this.rbOrder.CheckedChanged += new System.EventHandler(this.rbOrder_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày Nhận";
            // 
            // dtpTakeTime
            // 
            this.dtpTakeTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.dtpTakeTime.BorderSize = 2;
            this.dtpTakeTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpTakeTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpTakeTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpTakeTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpTakeTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpTakeTime.Enabled = false;
            this.dtpTakeTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTakeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTakeTime.Location = new System.Drawing.Point(573, 209);
            this.dtpTakeTime.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dtpTakeTime.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpTakeTime.Name = "dtpTakeTime";
            this.dtpTakeTime.ShowUpDown = true;
            this.dtpTakeTime.Size = new System.Drawing.Size(94, 35);
            this.dtpTakeTime.SkinColor = System.Drawing.Color.White;
            this.dtpTakeTime.TabIndex = 23;
            this.dtpTakeTime.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            // 
            // dtpTakeDate
            // 
            this.dtpTakeDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.dtpTakeDate.BorderSize = 2;
            this.dtpTakeDate.Enabled = false;
            this.dtpTakeDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTakeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTakeDate.Location = new System.Drawing.Point(440, 209);
            this.dtpTakeDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dtpTakeDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpTakeDate.Name = "dtpTakeDate";
            this.dtpTakeDate.Size = new System.Drawing.Size(115, 35);
            this.dtpTakeDate.SkinColor = System.Drawing.Color.White;
            this.dtpTakeDate.TabIndex = 22;
            this.dtpTakeDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Enabled = false;
            this.lbCurrentTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.lbCurrentTime.Location = new System.Drawing.Point(437, 152);
            this.lbCurrentTime.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(120, 18);
            this.lbCurrentTime.TabIndex = 21;
            this.lbCurrentTime.Text = "28/05/2023 17:54";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hiện Tại";
            // 
            // txtCName
            // 
            this.txtCName.BackColor = System.Drawing.Color.White;
            this.txtCName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.txtCName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.txtCName.BorderRadius = 0;
            this.txtCName.BorderSize = 2;
            this.txtCName.Enabled = false;
            this.txtCName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.txtCName.Location = new System.Drawing.Point(436, 82);
            this.txtCName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCName.Multiline = false;
            this.txtCName.Name = "txtCName";
            this.txtCName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCName.PasswordChar = false;
            this.txtCName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCName.PlaceholderText = "Chưa Chọn Khách Hàng";
            this.txtCName.Size = new System.Drawing.Size(227, 31);
            this.txtCName.TabIndex = 19;
            this.txtCName.Texts = "";
            this.txtCName.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 40);
            this.panel2.TabIndex = 17;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(657, 40);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "B101";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(211, 59);
            this.dataGridView1.TabIndex = 4;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomer.ColumnHeadersHeight = 30;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCustomer.Location = new System.Drawing.Point(10, 60);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 50;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(396, 266);
            this.dgvCustomer.TabIndex = 3;
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
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CPhone";
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form_OrederTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 376);
            this.Controls.Add(this.pnContainer);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_OrederTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_OrederTable";
            this.Activated += new System.EventHandler(this.Form_RoundExample_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form_RoundExample_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form_RoundExample_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_RoundExample_Paint);
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private CustomControl.CTextbox txtCName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private CustomControl.CDatePicker dtpTakeTime;
        private CustomControl.CDatePicker dtpTakeDate;
        private CustomControl.CRadioButton rbTake;
        private CustomControl.CRadioButton rbOrder;
        private CustomControl.CButton btnSave;
        private CustomControl.CButton btnClose;
        private CustomControl.CButton btnDelete;
    }
}