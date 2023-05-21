using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using TripleX.v2.Table;
using TripleX.v2.Customer;
using TripleX.v2.Food;
using CustomControl;
using FontAwesome.Sharp;
using TripleX.v2.Home;
using TripleX.v2.Staff;

namespace TripleX.v2
{
    public partial class MainForm : MaterialForm
    {
        //Fields
        private Form activateForm;
        private IconButton currentBtn;
        private Panel leftPn;
        readonly MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500, Primary.DeepOrange500, 
                Accent.DeepOrange400, TextShade.WHITE);

            leftPn = new Panel();
            leftPn.Size = new Size(7, 50);
            pnMenu.Controls.Add(leftPn);
            ActivateButton(btnDashboard);

            this.DoubleBuffered = true;
        }

        //Methods
        void ActivateButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(255, 87, 34);

                leftPn.BackColor = Color.FromArgb(255, 87, 34);
                leftPn.Location = new Point(0, currentBtn.Location.Y);
                leftPn.Visible = true;
                leftPn.BringToFront();
            }
        }

        void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(242, 242, 242);
                currentBtn.IconColor = Color.Black;
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TableM(), sender);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FoodM(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerM(), sender);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard(), sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaffM(), sender);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
