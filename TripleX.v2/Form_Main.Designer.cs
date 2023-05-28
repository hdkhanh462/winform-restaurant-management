namespace TripleX.v2
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnClose = new CustomControl.CButton();
            this.btnMaximize = new CustomControl.CButton();
            this.btnMinimize = new CustomControl.CButton();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnStaffM = new CustomControl.CButton();
            this.btnCustomerM = new CustomControl.CButton();
            this.btnFoodM = new CustomControl.CButton();
            this.btnPayment = new CustomControl.CButton();
            this.btnOrderFood = new CustomControl.CButton();
            this.btnTableM = new CustomControl.CButton();
            this.btnDashboard = new CustomControl.CButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnContainer.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.White;
            this.pnContainer.Controls.Add(this.pnMain);
            this.pnContainer.Controls.Add(this.pnTitle);
            this.pnContainer.Controls.Add(this.pnMenu);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1184, 611);
            this.pnContainer.TabIndex = 0;
            this.pnContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContainer_Paint);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(70, 40);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1114, 571);
            this.pnMain.TabIndex = 3;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.btnClose);
            this.pnTitle.Controls.Add(this.btnMaximize);
            this.pnTitle.Controls.Add(this.btnMinimize);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(70, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1114, 40);
            this.pnTitle.TabIndex = 2;
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.btnClose.HoverImage = null;
            this.btnClose.Image = global::TripleX.v2.Properties.Resources.close10_20px;
            this.btnClose.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnClose.LeaveColor = System.Drawing.Color.White;
            this.btnClose.LeaveImage = null;
            this.btnClose.Location = new System.Drawing.Point(1064, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.BackgroundColor = System.Drawing.Color.White;
            this.btnMaximize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaximize.BorderRadius = 10;
            this.btnMaximize.BorderSize = 0;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.CustomTag = "";
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnMaximize.HoverColor = System.Drawing.Color.Empty;
            this.btnMaximize.HoverImage = null;
            this.btnMaximize.Image = global::TripleX.v2.Properties.Resources.maximize_button10_18px;
            this.btnMaximize.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnMaximize.LeaveColor = System.Drawing.Color.White;
            this.btnMaximize.LeaveImage = null;
            this.btnMaximize.Location = new System.Drawing.Point(1024, 4);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnMaximize.Size = new System.Drawing.Size(40, 30);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.TextColor = System.Drawing.Color.White;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.BackgroundColor = System.Drawing.Color.White;
            this.btnMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BorderRadius = 10;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomTag = "";
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnMinimize.HoverColor = System.Drawing.Color.Empty;
            this.btnMinimize.HoverImage = null;
            this.btnMinimize.Image = global::TripleX.v2.Properties.Resources.subtract10_20px;
            this.btnMinimize.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnMinimize.LeaveColor = System.Drawing.Color.White;
            this.btnMinimize.LeaveImage = null;
            this.btnMinimize.Location = new System.Drawing.Point(984, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnMinimize.Size = new System.Drawing.Size(40, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.pnLeft);
            this.pnMenu.Controls.Add(this.btnStaffM);
            this.pnMenu.Controls.Add(this.btnCustomerM);
            this.pnMenu.Controls.Add(this.btnFoodM);
            this.pnMenu.Controls.Add(this.btnPayment);
            this.pnMenu.Controls.Add(this.btnOrderFood);
            this.pnMenu.Controls.Add(this.btnTableM);
            this.pnMenu.Controls.Add(this.btnDashboard);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(70, 611);
            this.pnMenu.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.pnLeft.Location = new System.Drawing.Point(5, 71);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(7, 50);
            this.pnLeft.TabIndex = 0;
            this.pnLeft.Visible = false;
            // 
            // btnStaffM
            // 
            this.btnStaffM.BackColor = System.Drawing.Color.White;
            this.btnStaffM.BackgroundColor = System.Drawing.Color.White;
            this.btnStaffM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnStaffM.BorderRadius = 0;
            this.btnStaffM.BorderSize = 0;
            this.btnStaffM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffM.CustomTag = "";
            this.btnStaffM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffM.FlatAppearance.BorderSize = 0;
            this.btnStaffM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffM.ForeColor = System.Drawing.Color.White;
            this.btnStaffM.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnStaffM.HoverColor = System.Drawing.Color.Empty;
            this.btnStaffM.HoverImage = global::TripleX.v2.Properties.Resources.user_account_32px1;
            this.btnStaffM.Image = global::TripleX.v2.Properties.Resources.user_account_32px;
            this.btnStaffM.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnStaffM.LeaveColor = System.Drawing.Color.White;
            this.btnStaffM.LeaveImage = global::TripleX.v2.Properties.Resources.user_account_32px;
            this.btnStaffM.Location = new System.Drawing.Point(0, 370);
            this.btnStaffM.Name = "btnStaffM";
            this.btnStaffM.Size = new System.Drawing.Size(70, 50);
            this.btnStaffM.TabIndex = 8;
            this.btnStaffM.TextColor = System.Drawing.Color.White;
            this.btnStaffM.UseVisualStyleBackColor = false;
            this.btnStaffM.Click += new System.EventHandler(this.btnStaffM_Click);
            // 
            // btnCustomerM
            // 
            this.btnCustomerM.BackColor = System.Drawing.Color.White;
            this.btnCustomerM.BackgroundColor = System.Drawing.Color.White;
            this.btnCustomerM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnCustomerM.BorderRadius = 0;
            this.btnCustomerM.BorderSize = 0;
            this.btnCustomerM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerM.CustomTag = "";
            this.btnCustomerM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerM.FlatAppearance.BorderSize = 0;
            this.btnCustomerM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerM.ForeColor = System.Drawing.Color.White;
            this.btnCustomerM.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnCustomerM.HoverColor = System.Drawing.Color.Empty;
            this.btnCustomerM.HoverImage = global::TripleX.v2.Properties.Resources.customer_32px1;
            this.btnCustomerM.Image = global::TripleX.v2.Properties.Resources.customer_32px;
            this.btnCustomerM.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnCustomerM.LeaveColor = System.Drawing.Color.White;
            this.btnCustomerM.LeaveImage = global::TripleX.v2.Properties.Resources.customer_32px;
            this.btnCustomerM.Location = new System.Drawing.Point(0, 320);
            this.btnCustomerM.Name = "btnCustomerM";
            this.btnCustomerM.Size = new System.Drawing.Size(70, 50);
            this.btnCustomerM.TabIndex = 7;
            this.btnCustomerM.TextColor = System.Drawing.Color.White;
            this.btnCustomerM.UseVisualStyleBackColor = false;
            this.btnCustomerM.Click += new System.EventHandler(this.btnCustomerM_Click);
            // 
            // btnFoodM
            // 
            this.btnFoodM.BackColor = System.Drawing.Color.White;
            this.btnFoodM.BackgroundColor = System.Drawing.Color.White;
            this.btnFoodM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnFoodM.BorderRadius = 0;
            this.btnFoodM.BorderSize = 0;
            this.btnFoodM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodM.CustomTag = "";
            this.btnFoodM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodM.FlatAppearance.BorderSize = 0;
            this.btnFoodM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodM.ForeColor = System.Drawing.Color.White;
            this.btnFoodM.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnFoodM.HoverColor = System.Drawing.Color.Empty;
            this.btnFoodM.HoverImage = global::TripleX.v2.Properties.Resources.food_32px_2;
            this.btnFoodM.Image = global::TripleX.v2.Properties.Resources.food_32px_21;
            this.btnFoodM.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnFoodM.LeaveColor = System.Drawing.Color.White;
            this.btnFoodM.LeaveImage = global::TripleX.v2.Properties.Resources.food_32px_21;
            this.btnFoodM.Location = new System.Drawing.Point(0, 270);
            this.btnFoodM.Name = "btnFoodM";
            this.btnFoodM.Size = new System.Drawing.Size(70, 50);
            this.btnFoodM.TabIndex = 6;
            this.btnFoodM.TextColor = System.Drawing.Color.White;
            this.btnFoodM.UseVisualStyleBackColor = false;
            this.btnFoodM.Click += new System.EventHandler(this.btnFoodM_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.White;
            this.btnPayment.BackgroundColor = System.Drawing.Color.White;
            this.btnPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnPayment.BorderRadius = 0;
            this.btnPayment.BorderSize = 0;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.CustomTag = "";
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnPayment.HoverColor = System.Drawing.Color.Empty;
            this.btnPayment.HoverImage = global::TripleX.v2.Properties.Resources.initiate_money_transfer_32px1;
            this.btnPayment.Image = global::TripleX.v2.Properties.Resources.initiate_money_transfer_32px;
            this.btnPayment.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnPayment.LeaveColor = System.Drawing.Color.White;
            this.btnPayment.LeaveImage = global::TripleX.v2.Properties.Resources.initiate_money_transfer_32px;
            this.btnPayment.Location = new System.Drawing.Point(0, 220);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(70, 50);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.TextColor = System.Drawing.Color.White;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.BackColor = System.Drawing.Color.White;
            this.btnOrderFood.BackgroundColor = System.Drawing.Color.White;
            this.btnOrderFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnOrderFood.BorderRadius = 0;
            this.btnOrderFood.BorderSize = 0;
            this.btnOrderFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderFood.CustomTag = "";
            this.btnOrderFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderFood.FlatAppearance.BorderSize = 0;
            this.btnOrderFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderFood.ForeColor = System.Drawing.Color.White;
            this.btnOrderFood.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnOrderFood.HoverColor = System.Drawing.Color.Empty;
            this.btnOrderFood.HoverImage = global::TripleX.v2.Properties.Resources.buy_32px1;
            this.btnOrderFood.Image = global::TripleX.v2.Properties.Resources.buy_32px;
            this.btnOrderFood.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnOrderFood.LeaveColor = System.Drawing.Color.White;
            this.btnOrderFood.LeaveImage = global::TripleX.v2.Properties.Resources.buy_32px;
            this.btnOrderFood.Location = new System.Drawing.Point(0, 170);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(70, 50);
            this.btnOrderFood.TabIndex = 4;
            this.btnOrderFood.TextColor = System.Drawing.Color.White;
            this.btnOrderFood.UseVisualStyleBackColor = false;
            this.btnOrderFood.Click += new System.EventHandler(this.btnOrderFood_Click);
            // 
            // btnTableM
            // 
            this.btnTableM.BackColor = System.Drawing.Color.White;
            this.btnTableM.BackgroundColor = System.Drawing.Color.White;
            this.btnTableM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnTableM.BorderRadius = 0;
            this.btnTableM.BorderSize = 0;
            this.btnTableM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableM.CustomTag = "";
            this.btnTableM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableM.FlatAppearance.BorderSize = 0;
            this.btnTableM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableM.ForeColor = System.Drawing.Color.White;
            this.btnTableM.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnTableM.HoverColor = System.Drawing.Color.Empty;
            this.btnTableM.HoverImage = global::TripleX.v2.Properties.Resources.table_32px1;
            this.btnTableM.Image = global::TripleX.v2.Properties.Resources.table_32px;
            this.btnTableM.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnTableM.LeaveColor = System.Drawing.Color.White;
            this.btnTableM.LeaveImage = global::TripleX.v2.Properties.Resources.table_32px;
            this.btnTableM.Location = new System.Drawing.Point(0, 120);
            this.btnTableM.Name = "btnTableM";
            this.btnTableM.Size = new System.Drawing.Size(70, 50);
            this.btnTableM.TabIndex = 3;
            this.btnTableM.TextColor = System.Drawing.Color.White;
            this.btnTableM.UseVisualStyleBackColor = false;
            this.btnTableM.Click += new System.EventHandler(this.btnTableM_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.BackgroundColor = System.Drawing.Color.White;
            this.btnDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomTag = "";
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnDashboard.HoverColor = System.Drawing.Color.Empty;
            this.btnDashboard.HoverImage = global::TripleX.v2.Properties.Resources.combo_chart_32px1;
            this.btnDashboard.Image = global::TripleX.v2.Properties.Resources.combo_chart_32px;
            this.btnDashboard.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnDashboard.LeaveColor = System.Drawing.Color.White;
            this.btnDashboard.LeaveImage = global::TripleX.v2.Properties.Resources.combo_chart_32px;
            this.btnDashboard.Location = new System.Drawing.Point(0, 70);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(70, 50);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.TextColor = System.Drawing.Color.White;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.pbLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Padding = new System.Windows.Forms.Padding(5);
            this.pnLogo.Size = new System.Drawing.Size(70, 70);
            this.pnLogo.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(5, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pnContainer);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Main";
            this.Activated += new System.EventHandler(this.Form_RoundExample_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form_RoundExample_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_RoundExample_Paint);
            this.StyleChanged += new System.EventHandler(this.Form_RoundExample_SizeChanged);
            this.pnContainer.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Panel pnMenu;
        private CustomControl.CButton btnDashboard;
        private CustomControl.CButton btnStaffM;
        private CustomControl.CButton btnCustomerM;
        private CustomControl.CButton btnFoodM;
        private CustomControl.CButton btnPayment;
        private CustomControl.CButton btnOrderFood;
        private CustomControl.CButton btnTableM;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnLeft;
        private CustomControl.CButton btnClose;
        private CustomControl.CButton btnMaximize;
        private CustomControl.CButton btnMinimize;
    }
}