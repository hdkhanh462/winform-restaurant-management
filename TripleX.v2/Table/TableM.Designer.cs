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
            this.grbKind = new System.Windows.Forms.GroupBox();
            this.rbBig = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAgv = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSmall = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rbIsOrder = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbEmpty = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddTable = new CustomControl.CButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
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
            this.grbKind.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.grbKind);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.grbStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(604, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 361);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grbKind
            // 
            this.grbKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.grbKind.Controls.Add(this.rbBig);
            this.grbKind.Controls.Add(this.rbAgv);
            this.grbKind.Controls.Add(this.rbSmall);
            this.grbKind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKind.Location = new System.Drawing.Point(0, 115);
            this.grbKind.Name = "grbKind";
            this.grbKind.Size = new System.Drawing.Size(200, 143);
            this.grbKind.TabIndex = 3;
            this.grbKind.TabStop = false;
            this.grbKind.Paint += new System.Windows.Forms.PaintEventHandler(this.grbKind_Paint);
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Depth = 0;
            this.rbBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.rbBig.Location = new System.Drawing.Point(18, 92);
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
            this.rbAgv.Location = new System.Drawing.Point(18, 55);
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
            this.rbSmall.Location = new System.Drawing.Point(18, 18);
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
            this.panel12.Location = new System.Drawing.Point(0, 105);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 10);
            this.panel12.TabIndex = 2;
            // 
            // grbStatus
            // 
            this.grbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.grbStatus.Controls.Add(this.rbIsOrder);
            this.grbStatus.Controls.Add(this.rbEmpty);
            this.grbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbStatus.Location = new System.Drawing.Point(0, 0);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(200, 105);
            this.grbStatus.TabIndex = 1;
            this.grbStatus.TabStop = false;
            this.grbStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.grbStatus_Paint);
            // 
            // rbIsOrder
            // 
            this.rbIsOrder.AutoSize = true;
            this.rbIsOrder.Depth = 0;
            this.rbIsOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbIsOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(48)))));
            this.rbIsOrder.Location = new System.Drawing.Point(20, 55);
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
            this.rbEmpty.Location = new System.Drawing.Point(20, 18);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.btnAddTable);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.materialTextBox1);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 70);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddTable.BorderRadius = 0;
            this.btnAddTable.BorderSize = 0;
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.CustomTag = "";
            this.btnAddTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnAddTable.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTable.HoverImage = null;
            this.btnAddTable.Image = global::TripleX.v2.Properties.Resources.Add_properties_26px;
            this.btnAddTable.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnAddTable.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddTable.LeaveImage = null;
            this.btnAddTable.Location = new System.Drawing.Point(10, 10);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(50, 50);
            this.btnAddTable.TabIndex = 4;
            this.btnAddTable.TextColor = System.Drawing.Color.White;
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 10);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 50);
            this.panel11.TabIndex = 5;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackColor = System.Drawing.Color.White;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.ForeColor = System.Drawing.Color.Black;
            this.materialTextBox1.Hint = "Search";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(397, 10);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(387, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = global::TripleX.v2.Properties.Resources.search_26px;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(784, 10);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(784, 10);
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
            this.cTable1.OrderID = null;
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
            this.Controls.Add(this.panel2);
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
            this.grbKind.ResumeLayout(false);
            this.grbKind.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private CTable cTable1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private CustomControl.CButton btnAddTable;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.GroupBox grbKind;
        private MaterialSkin.Controls.MaterialRadioButton rbSmall;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox grbStatus;
        private MaterialSkin.Controls.MaterialRadioButton rbBig;
        private MaterialSkin.Controls.MaterialRadioButton rbAgv;
        private MaterialSkin.Controls.MaterialRadioButton rbIsOrder;
        private MaterialSkin.Controls.MaterialRadioButton rbEmpty;
    }
}