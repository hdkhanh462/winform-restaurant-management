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
using TripleX.v2.Table;
using TripleX.v2.Customer;
using TripleX.v2.Food;

namespace TripleX.v2
{
    public partial class MainForm : MaterialForm
    {
        //Fields
        private Form activateForm;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.DeepOrange400, MaterialSkin.Primary.DeepOrange400, MaterialSkin.Primary.DeepOrange400, 
                MaterialSkin.Accent.DeepOrange400, MaterialSkin.TextShade.WHITE);
        }

        //Methods
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void cTable1__CClick(object sender, EventArgs e)
        {
            MessageBox.Show("2");
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
    }
}
