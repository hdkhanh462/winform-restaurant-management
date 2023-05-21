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
using TripleX.v2.Table;

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
            Connection.Connect();
        }

        void ReLoadTableM()
        {
            var mainForm = Application.OpenForms.OfType<CustomerM>().Single();
            mainForm.GetData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "insert into TCustomer values(N'"+ txtName.Text +"','"+ txtCCCD.Text +"','"+ txtPhone.Text +"'," + isMale +")";
            SqlClass.RunSql(sql, Connection.conn);
            ReLoadTableM();
            SharedClass.Alert("Thêm Thành Công!", Form_Alert.enmType.Success);
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
