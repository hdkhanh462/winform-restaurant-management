using CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleX.v2.Customer;

namespace TripleX.v2.Table
{
    public partial class AddTable : Form
    {
        //Fields 
        string kind = "1";

        public AddTable()
        {
            InitializeComponent();
            Connection.Connect();
        }

        //Methods
        void ReLoadTableM()
        {
            var mainForm = Application.OpenForms.OfType<TableM>().Single();
            mainForm.GetData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int chair = int.Parse(txtChair.Text);
            if (chair <= 4)
            {
                kind = "1";
            }
            if (chair >= 5 && chair < 8)
            {
                kind = "2";
            }
            if (chair >= 8)
            {
                kind = "3";
            }

            string sql = "exec PTableAdd '" + txtName.Text + "'," + txtChair.Text + "," + kind;
            SqlClass.RunSql(sql, Connection.conn);
            SharedClass.Alert("Thêm Thành Công!", Form_Alert.enmType.Success);
            ReLoadTableM();
            //CMessageBox.Show(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
