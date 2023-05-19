namespace TripleX.v2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnCustomer = new CustomControl.CButton();
            this.btnFood = new CustomControl.CButton();
            this.btnTable = new CustomControl.CButton();
            this.btnHome = new CustomControl.CButton();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coffee_table_32px.png");
            this.imageList1.Images.SetKeyName(1, "food_32px.png");
            this.imageList1.Images.SetKeyName(2, "home_page_32px.png");
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnMenu.Controls.Add(this.btnCustomer);
            this.pnMenu.Controls.Add(this.btnFood);
            this.pnMenu.Controls.Add(this.btnTable);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 24);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(80, 500);
            this.pnMenu.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(80, 24);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(830, 500);
            this.pnMain.TabIndex = 1;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCustomer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCustomer.BorderRadius = 0;
            this.btnCustomer.BorderSize = 0;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.CustomTag = "";
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnCustomer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCustomer.HoverImage = global::TripleX.v2.Properties.Resources.budget_32px1;
            this.btnCustomer.Image = global::TripleX.v2.Properties.Resources.budget_32px;
            this.btnCustomer.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnCustomer.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCustomer.LeaveImage = global::TripleX.v2.Properties.Resources.budget_32px;
            this.btnCustomer.Location = new System.Drawing.Point(0, 180);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(80, 60);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.TextColor = System.Drawing.Color.White;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFood.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFood.BorderRadius = 0;
            this.btnFood.BorderSize = 0;
            this.btnFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFood.CustomTag = "";
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnFood.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFood.HoverImage = global::TripleX.v2.Properties.Resources.food_32px1;
            this.btnFood.Image = global::TripleX.v2.Properties.Resources.food_32px;
            this.btnFood.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnFood.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFood.LeaveImage = global::TripleX.v2.Properties.Resources.food_32px;
            this.btnFood.Location = new System.Drawing.Point(0, 120);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(80, 60);
            this.btnFood.TabIndex = 3;
            this.btnFood.TextColor = System.Drawing.Color.White;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTable.BorderRadius = 0;
            this.btnTable.BorderSize = 0;
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.CustomTag = "";
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnTable.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTable.HoverImage = global::TripleX.v2.Properties.Resources.coffee_table_32px1;
            this.btnTable.Image = global::TripleX.v2.Properties.Resources.coffee_table_32px;
            this.btnTable.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnTable.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTable.LeaveImage = global::TripleX.v2.Properties.Resources.coffee_table_32px;
            this.btnTable.Location = new System.Drawing.Point(0, 60);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(80, 60);
            this.btnTable.TabIndex = 2;
            this.btnTable.TextColor = System.Drawing.Color.White;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 0;
            this.btnHome.BorderSize = 0;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.CustomTag = "";
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnHome.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnHome.HoverImage = global::TripleX.v2.Properties.Resources.home_page_32px1;
            this.btnHome.Image = global::TripleX.v2.Properties.Resources.home_page_32px;
            this.btnHome.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnHome.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHome.LeaveImage = global::TripleX.v2.Properties.Resources.home_page_32px;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(913, 527);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerUseColors = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripleX v2.0";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnMenu;
        private CustomControl.CButton btnHome;
        private CustomControl.CButton btnFood;
        private CustomControl.CButton btnTable;
        private System.Windows.Forms.Panel pnMain;
        private CustomControl.CButton btnCustomer;
    }
}