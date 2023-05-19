using CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleX.v2.Customer
{
    public partial class CustomerM : Form
    {
        //Fields
        string sql;
        string customerID;
        Image female = Properties.Resources.female_26px;
        Image male = Properties.Resources.male_26px;
        public CustomerM()
        {
            InitializeComponent();
            Connection.Connect();
            GetData();
        }

        public void GetData()
        {
            sql = "select * from TCustomer";
            SharedClass.FillDGV(dgvCustomer, sql, Connection.conn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new AddCustomer();
            form.ShowDialog();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I suposed you want to handle the event for column at index 1
            if (e.ColumnIndex == 6)
                MessageBox.Show("Clicked!");
        }
    }
}
