using CustomControl;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleX.v2.Customer
{
    public partial class AddCustomer : Form
    {
        //Fields
        readonly MaterialSkinManager materialSkinManager;
        string isMale = "2";

        public AddCustomer()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.DeepOrange400, MaterialSkin.Primary.DeepOrange400, MaterialSkin.Primary.DeepOrange400,
                MaterialSkin.Accent.DeepOrange400, MaterialSkin.TextShade.WHITE);
            Connection.Connect();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "insert into TCustomer values(N'"+ txtName.Text +"','"+ txtCCCD.Text +"','"+ txtPhone.Text +"'," + isMale +")";
            SqlClass.RunSql(sql, Connection.conn);
            //CMessageBox.Show(sql);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                isMale = "2";
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                isMale = "1";
            }
        }
    }
}
