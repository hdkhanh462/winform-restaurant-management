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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.rbBig = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAgv = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSmall = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.rbIsOrder = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbEmpty = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnAddTable = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new CustomControl.CTextbox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(10, 71);
            this.flpTable.Margin = new System.Windows.Forms.Padding(10);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(812, 492);
            this.flpTable.TabIndex = 0;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(832, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 492);
            this.panel1.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gainsboro;
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
            this.panel13.BackColor = System.Drawing.Color.Gainsboro;
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
            this.pnTop.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTop.Controls.Add(this.btnAddTable);
            this.pnTop.Controls.Add(this.btnSearch);
            this.pnTop.Controls.Add(this.txtSearch);
            this.pnTop.Controls.Add(this.panel9);
            this.pnTop.Controls.Add(this.panel8);
            this.pnTop.Controls.Add(this.panel7);
            this.pnTop.Controls.Add(this.panel15);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(10, 10);
            this.pnTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1022, 51);
            this.pnTop.TabIndex = 2;
            this.pnTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btnAddTable.IconSize = 22;
            this.btnAddTable.Location = new System.Drawing.Point(660, 10);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnAddTable.Size = new System.Drawing.Size(51, 31);
            this.btnAddTable.TabIndex = 16;
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
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
            this.btnSearch.IconSize = 22;
            this.btnSearch.Location = new System.Drawing.Point(711, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(51, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(762, 10);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(250, 31);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(70, 41);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(942, 10);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(70, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(942, 10);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1012, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 51);
            this.panel7.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(70, 51);
            this.panel15.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 573);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1032, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 573);
            this.panel6.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(10, 563);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1022, 10);
            this.panel10.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(822, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 492);
            this.panel2.TabIndex = 6;
            // 
            // TableM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1042, 573);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel2);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnTop;
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
        private System.Windows.Forms.Panel panel15;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnAddTable;
        private CustomControl.CTextbox txtSearch;
        private System.Windows.Forms.Panel panel2;
    }
}