using CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleX.v2.Home;
using TripleX.v2.Bill;
using TripleX.v2.Customer;
using TripleX.v2.Food;
using TripleX.v2.Staff;
using TripleX.v2.Table;
using FontAwesome.Sharp;

namespace TripleX.v2
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.pnMenu.BackColor = color60;
            this.pnTitle.BackColor = color60;
            this.BackColor = color60;

            ActivateButton(btnDashboard);
        }

        //Fields
        public static Color color60 = Color.White;
        public static Color color30 = Color.FromArgb(14, 14, 14);
        public static Color color10 = Color.FromArgb(252, 74, 26);
        private Form activateForm;
        private CButton currentBtn;

        #region <-- Smooth Rounded Form -->
        //Fields
        private int borderRadius = 10;
        private int borderSize = 2;

        #region <-- Drag Form -->
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        //Events
        private void Form_RoundExample_Paint(object sender, PaintEventArgs e)
        {
            RoundAForm.FormPaint(e, this, borderRadius, color60, borderSize);
        }
        private void Form_RoundExample_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form_RoundExample_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form_RoundExample_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {
            RoundAForm.ControlRegionAndBorder(pnContainer, borderRadius - (borderSize / 2), e.Graphics, color60);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
                color60 = Color.White;
                borderSize = 2;
                borderRadius = 10;
                this.Padding = new Padding(borderSize);
                this.Invalidate();
                pnContainer.Invalidate();
            }
            else
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                color60 = Color.Empty;
                borderSize = 0;
                borderRadius = 0;
                this.Padding = new Padding(0);
                this.Invalidate();
                pnContainer.Invalidate();
            }
        }
        #endregion

        //Methods
        void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (CButton)senderBtn;
                currentBtn.Image = ButtonImage(true);
                currentBtn.LeaveImage = ButtonImage(true);
                currentBtn.Padding = new Padding(10,0,0,0);

                pnLeft.Location = new Point(0, currentBtn.Location.Y);
                pnLeft.Visible = true;
                pnLeft.BringToFront();
            }
        }
        void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.Image = ButtonImage(false);
                currentBtn.LeaveImage = ButtonImage(false);
                currentBtn.Padding = new Padding(0);
            }
        }
        Image ButtonImage(bool isActive)
        {
            if (isActive)
            {
                switch (currentBtn.Name)
                {
                    case "btnDashboard":
                        return Properties.Resources.combo_chart_32px1;
                    case "btnTableM":
                        return Properties.Resources.table_32px1;
                    case "btnOrderFood":
                        return Properties.Resources.buy_32px1;
                    case "btnPayment":
                        return Properties.Resources.initiate_money_transfer_32px1;
                    case "btnFoodM":
                        return Properties.Resources.food_32px_2;
                    case "btnCustomerM":
                        return Properties.Resources.customer_32px1;
                    case "btnStaffM":
                        return Properties.Resources.user_account_32px1;
                    default:
                        return null;
                }
            }
            else
            {
                switch (currentBtn.Name)
                {
                    case "btnDashboard":
                        return Properties.Resources.combo_chart_32px;
                    case "btnTableM":
                        return Properties.Resources.table_32px;
                    case "btnOrderFood":
                        return Properties.Resources.buy_32px;
                    case "btnPayment":
                        return Properties.Resources.initiate_money_transfer_32px;
                    case "btnFoodM":
                        return Properties.Resources.food_32px_21;
                    case "btnCustomerM":
                        return Properties.Resources.customer_32px;
                    case "btnStaffM":
                        return Properties.Resources.user_account_32px;
                    default:
                        return null;
                }
            }
        }

        //Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activateForm = SharedClass.OpenChildForm(new Dashboard(), activateForm, pnMain);
            ActivateButton(sender);
        }

        private void btnTableM_Click(object sender, EventArgs e)
        {
            activateForm = SharedClass.OpenChildForm(new Form_Table(), activateForm, pnMain);
            ActivateButton(sender);
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            activateForm = SharedClass.OpenChildForm(new OrderFood(), activateForm, pnMain);
            ActivateButton(sender);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            activateForm = SharedClass.OpenChildForm(new BillM(), activateForm, pnMain);
            ActivateButton(sender);
        }

        private void btnFoodM_Click(object sender, EventArgs e)
        {
            activateForm = SharedClass.OpenChildForm(new FoodM(), activateForm, pnMain);
            ActivateButton(sender);
        }

        private void btnCustomerM_Click(object sender, EventArgs e)
        {
            activateForm = SharedClass.OpenChildForm(new Form_Customer(), activateForm, pnMain);
            ActivateButton(sender);
        }

        private void btnStaffM_Click(object sender, EventArgs e)
        {
            activateForm = SharedClass.OpenChildForm(new StaffM(), activateForm, pnMain);
            ActivateButton(sender);
        }
    }
}
