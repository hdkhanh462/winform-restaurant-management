namespace TripleX.v2.Table
{
    partial class TableM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableM));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnAddTable = new FontAwesome.Sharp.IconButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.rbBig = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAgv = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSmall = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.rbIsOrder = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbEmpty = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnThucUong = new CustomControl.CButton();
            this.btnHaiSan = new CustomControl.CButton();
            this.btnGiaCam = new CustomControl.CButton();
            this.btnGiaSuc = new CustomControl.CButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cTable1 = new TripleX.v2.Table.CTable();
            this.flpTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Controls.Add(this.cTable1);
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(10, 90);
            this.flpTable.Margin = new System.Windows.Forms.Padding(10);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(594, 361);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(604, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 361);
            this.panel1.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel11.Controls.Add(this.btnAddTable);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 321);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 40);
            this.panel11.TabIndex = 8;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnAddTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTable.IconSize = 28;
            this.btnAddTable.Location = new System.Drawing.Point(160, 0);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(40, 40);
            this.btnAddTable.TabIndex = 8;
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel14.Controls.Add(this.rbBig);
            this.panel14.Controls.Add(this.rbAgv);
            this.panel14.Controls.Add(this.rbSmall);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 110);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 136);
            this.panel14.TabIndex = 2;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Depth = 0;
            this.rbBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.rbBig.Location = new System.Drawing.Point(40, 87);
            this.rbBig.Margin = new System.Windows.Forms.Padding(0);
            this.rbBig.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBig.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBig.Name = "rbBig";
            this.rbBig.Ripple = true;
            this.rbBig.Size = new System.Drawing.Size(54, 37);
            this.rbBig.TabIndex = 2;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "To";
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.rbBig_CheckedChanged);
            // 
            // rbAgv
            // 
            this.rbAgv.AutoSize = true;
            this.rbAgv.Depth = 0;
            this.rbAgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.rbAgv.Location = new System.Drawing.Point(40, 50);
            this.rbAgv.Margin = new System.Windows.Forms.Padding(0);
            this.rbAgv.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAgv.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAgv.Name = "rbAgv";
            this.rbAgv.Ripple = true;
            this.rbAgv.Size = new System.Drawing.Size(64, 37);
            this.rbAgv.TabIndex = 1;
            this.rbAgv.TabStop = true;
            this.rbAgv.Text = "Vừa";
            this.rbAgv.UseVisualStyleBackColor = true;
            this.rbAgv.CheckedChanged += new System.EventHandler(this.rbAgv_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Depth = 0;
            this.rbSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.rbSmall.Location = new System.Drawing.Point(40, 13);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(0);
            this.rbSmall.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSmall.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Ripple = true;
            this.rbSmall.Size = new System.Drawing.Size(64, 37);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Nhỏ";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 100);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 10);
            this.panel12.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel13.Controls.Add(this.rbIsOrder);
            this.panel13.Controls.Add(this.rbEmpty);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 100);
            this.panel13.TabIndex = 1;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // rbIsOrder
            // 
            this.rbIsOrder.AutoSize = true;
            this.rbIsOrder.Depth = 0;
            this.rbIsOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbIsOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.rbIsOrder.Location = new System.Drawing.Point(40, 50);
            this.rbIsOrder.Margin = new System.Windows.Forms.Padding(0);
            this.rbIsOrder.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbIsOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbIsOrder.Name = "rbIsOrder";
            this.rbIsOrder.Ripple = true;
            this.rbIsOrder.Size = new System.Drawing.Size(84, 37);
            this.rbIsOrder.TabIndex = 2;
            this.rbIsOrder.TabStop = true;
            this.rbIsOrder.Text = "Đã Đặt";
            this.rbIsOrder.UseVisualStyleBackColor = true;
            this.rbIsOrder.CheckedChanged += new System.EventHandler(this.rbIsOrder_CheckedChanged);
            // 
            // rbEmpty
            // 
            this.rbEmpty.AutoSize = true;
            this.rbEmpty.Checked = true;
            this.rbEmpty.Depth = 0;
            this.rbEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.rbEmpty.Location = new System.Drawing.Point(40, 13);
            this.rbEmpty.Margin = new System.Windows.Forms.Padding(0);
            this.rbEmpty.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEmpty.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEmpty.Name = "rbEmpty";
            this.rbEmpty.Ripple = true;
            this.rbEmpty.Size = new System.Drawing.Size(77, 37);
            this.rbEmpty.TabIndex = 1;
            this.rbEmpty.TabStop = true;
            this.rbEmpty.Text = "Trống";
            this.rbEmpty.UseVisualStyleBackColor = true;
            this.rbEmpty.CheckedChanged += new System.EventHandler(this.rbEmpty_CheckedChanged);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnTop.Controls.Add(this.btnSearch);
            this.pnTop.Controls.Add(this.txtSearch);
            this.pnTop.Controls.Add(this.panel9);
            this.pnTop.Controls.Add(this.panel8);
            this.pnTop.Controls.Add(this.panel7);
            this.pnTop.Controls.Add(this.btnThucUong);
            this.pnTop.Controls.Add(this.btnHaiSan);
            this.pnTop.Controls.Add(this.btnGiaCam);
            this.pnTop.Controls.Add(this.btnGiaSuc);
            this.pnTop.Controls.Add(this.panel15);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(10, 10);
            this.pnTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(794, 70);
            this.pnTop.TabIndex = 2;
            this.pnTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnThucUong
            // 
            this.btnThucUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnThucUong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnThucUong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThucUong.BorderRadius = 0;
            this.btnThucUong.BorderSize = 0;
            this.btnThucUong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucUong.CustomTag = "";
            this.btnThucUong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThucUong.FlatAppearance.BorderSize = 0;
            this.btnThucUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucUong.ForeColor = System.Drawing.Color.White;
            this.btnThucUong.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnThucUong.HoverColor = System.Drawing.Color.Empty;
            this.btnThucUong.HoverImage = null;
            this.btnThucUong.Image = global::TripleX.v2.Properties.Resources.wine_bottle_32px;
            this.btnThucUong.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnThucUong.LeaveColor = System.Drawing.Color.Empty;
            this.btnThucUong.LeaveImage = null;
            this.btnThucUong.Location = new System.Drawing.Point(250, 0);
            this.btnThucUong.Name = "btnThucUong";
            this.btnThucUong.Size = new System.Drawing.Size(60, 70);
            this.btnThucUong.TabIndex = 15;
            this.btnThucUong.TextColor = System.Drawing.Color.White;
            this.btnThucUong.UseVisualStyleBackColor = false;
            this.btnThucUong.Click += new System.EventHandler(this.btnThucUong_Click);
            // 
            // btnHaiSan
            // 
            this.btnHaiSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnHaiSan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnHaiSan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHaiSan.BorderRadius = 0;
            this.btnHaiSan.BorderSize = 0;
            this.btnHaiSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHaiSan.CustomTag = "";
            this.btnHaiSan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHaiSan.FlatAppearance.BorderSize = 0;
            this.btnHaiSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaiSan.ForeColor = System.Drawing.Color.White;
            this.btnHaiSan.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnHaiSan.HoverColor = System.Drawing.Color.Empty;
            this.btnHaiSan.HoverImage = null;
            this.btnHaiSan.Image = global::TripleX.v2.Properties.Resources.crab_32px;
            this.btnHaiSan.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnHaiSan.LeaveColor = System.Drawing.Color.Empty;
            this.btnHaiSan.LeaveImage = null;
            this.btnHaiSan.Location = new System.Drawing.Point(190, 0);
            this.btnHaiSan.Name = "btnHaiSan";
            this.btnHaiSan.Size = new System.Drawing.Size(60, 70);
            this.btnHaiSan.TabIndex = 14;
            this.btnHaiSan.TextColor = System.Drawing.Color.White;
            this.btnHaiSan.UseVisualStyleBackColor = false;
            this.btnHaiSan.Click += new System.EventHandler(this.btnHaiSan_Click);
            // 
            // btnGiaCam
            // 
            this.btnGiaCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnGiaCam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnGiaCam.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGiaCam.BorderRadius = 0;
            this.btnGiaCam.BorderSize = 0;
            this.btnGiaCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaCam.CustomTag = "";
            this.btnGiaCam.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGiaCam.FlatAppearance.BorderSize = 0;
            this.btnGiaCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaCam.ForeColor = System.Drawing.Color.White;
            this.btnGiaCam.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnGiaCam.HoverColor = System.Drawing.Color.Empty;
            this.btnGiaCam.HoverImage = null;
            this.btnGiaCam.Image = global::TripleX.v2.Properties.Resources.chicken_32px;
            this.btnGiaCam.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnGiaCam.LeaveColor = System.Drawing.Color.Empty;
            this.btnGiaCam.LeaveImage = null;
            this.btnGiaCam.Location = new System.Drawing.Point(130, 0);
            this.btnGiaCam.Name = "btnGiaCam";
            this.btnGiaCam.Size = new System.Drawing.Size(60, 70);
            this.btnGiaCam.TabIndex = 13;
            this.btnGiaCam.TextColor = System.Drawing.Color.White;
            this.btnGiaCam.UseVisualStyleBackColor = false;
            this.btnGiaCam.Click += new System.EventHandler(this.btnGiaCam_Click);
            // 
            // btnGiaSuc
            // 
            this.btnGiaSuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnGiaSuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnGiaSuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGiaSuc.BorderRadius = 0;
            this.btnGiaSuc.BorderSize = 0;
            this.btnGiaSuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaSuc.CustomTag = "";
            this.btnGiaSuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGiaSuc.FlatAppearance.BorderSize = 0;
            this.btnGiaSuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaSuc.ForeColor = System.Drawing.Color.White;
            this.btnGiaSuc.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnGiaSuc.HoverColor = System.Drawing.Color.Empty;
            this.btnGiaSuc.HoverImage = null;
            this.btnGiaSuc.Image = global::TripleX.v2.Properties.Resources.bull_32px;
            this.btnGiaSuc.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnGiaSuc.LeaveColor = System.Drawing.Color.Empty;
            this.btnGiaSuc.LeaveImage = null;
            this.btnGiaSuc.Location = new System.Drawing.Point(70, 0);
            this.btnGiaSuc.Name = "btnGiaSuc";
            this.btnGiaSuc.Size = new System.Drawing.Size(60, 70);
            this.btnGiaSuc.TabIndex = 12;
            this.btnGiaSuc.TextColor = System.Drawing.Color.White;
            this.btnGiaSuc.UseVisualStyleBackColor = false;
            this.btnGiaSuc.Click += new System.EventHandler(this.btnGiaSuc_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.Location = new System.Drawing.Point(457, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(70, 70);
            this.panel15.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Hint = "Search";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(507, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 50);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = null;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(310, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(474, 10);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(310, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(474, 10);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(784, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 70);
            this.panel7.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(794, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 461);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(804, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 461);
            this.panel6.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(10, 451);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(794, 10);
            this.panel10.TabIndex = 5;
            // 
            // cTable1
            // 
            this.cTable1.Chair = null;
            this.cTable1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cTable1.Customer = null;
            this.cTable1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTable1.Location = new System.Drawing.Point(8, 8);
            this.cTable1.Margin = new System.Windows.Forms.Padding(8);
            this.cTable1.Name = "cTable1";
            this.cTable1.OrderDate = null;
            this.cTable1.OTableID = "";
            this.cTable1.Size = new System.Drawing.Size(250, 150);
            this.cTable1.TabIndex = 0;
            this.cTable1.TableID = null;
            this.cTable1.TableImage = ((System.Drawing.Image)(resources.GetObject("cTable1.TableImage")));
            this.cTable1.TableName = null;
            this.cTable1.TableStatus = null;
            this.cTable1._CClick += new System.EventHandler(this.cTable1__CClick);
            // 
            // TableM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableM";
            this.Text = "TableM";
            this.flpTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private CTable cTable1;
        private System.Windows.Forms.Panel pnTop;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private MaterialSkin.Controls.MaterialRadioButton rbSmall;
        private System.Windows.Forms.Panel panel12;
        private MaterialSkin.Controls.MaterialRadioButton rbBig;
        private MaterialSkin.Controls.MaterialRadioButton rbAgv;
        private MaterialSkin.Controls.MaterialRadioButton rbIsOrder;
        private MaterialSkin.Controls.MaterialRadioButton rbEmpty;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton btnAddTable;
        private System.Windows.Forms.Panel panel15;
        private FontAwesome.Sharp.IconButton btnSearch;
        private CustomControl.CButton btnGiaSuc;
        private CustomControl.CButton btnThucUong;
        private CustomControl.CButton btnHaiSan;
        private CustomControl.CButton btnGiaCam;
    }
}