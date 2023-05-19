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
            //siticoneDataGridView1.Rows[0].Cells[4].Value = someImage;
            sql = "select * from TCustomer";
            SharedClass.FillDGV(siticoneDataGridView1, sql, Connection.conn);
            int rcount = siticoneDataGridView1.RowCount;
            if(rcount > 0)
            {
                for (int i = 0; i < rcount; i++)
                {
                    string temp = siticoneDataGridView1.Rows[i].Cells["Column5"].Value.ToString();
                    if (temp == "2")
                    {
                        siticoneDataGridView1.Rows[i].Cells["Column6"].Value = male;
                    }
                    else if (temp == "1")
                    {
                        siticoneDataGridView1.Rows[i].Cells["Column6"].Value = female;
                    }
                }
            }
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I suposed you want to handle the event for column at index 1
            if (e.ColumnIndex == 5)
                MessageBox.Show("Clicked!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new AddCustomer();
            form.ShowDialog();
        }
    }
}
