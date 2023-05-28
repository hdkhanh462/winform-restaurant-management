namespace TripleX.v2
{
    partial class Form1
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
            this.cButton1 = new CustomControl.CButton();
            this.SuspendLayout();
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.Red;
            this.cButton1.BackgroundColor = System.Drawing.Color.Red;
            this.cButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton1.BorderRadius = 0;
            this.cButton1.BorderSize = 0;
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton1.CustomTag = "";
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.HoverBorderColor = System.Drawing.Color.Empty;
            this.cButton1.HoverColor = System.Drawing.Color.Empty;
            this.cButton1.HoverImage = null;
            this.cButton1.LeaveBorderColor = System.Drawing.Color.Empty;
            this.cButton1.LeaveColor = System.Drawing.Color.Empty;
            this.cButton1.LeaveImage = null;
            this.cButton1.Location = new System.Drawing.Point(411, 192);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(150, 40);
            this.cButton1.TabIndex = 0;
            this.cButton1.Text = "cButton1";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.CButton cButton1;
    }
}

