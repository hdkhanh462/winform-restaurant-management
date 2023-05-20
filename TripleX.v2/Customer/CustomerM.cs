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
            sql = "select * from TCustomer where ID <> 1";
            SharedClass.FillDGV(dataGridView1, sql, Connection.conn);
            int rcount = dataGridView1.RowCount;
            dgvCustomer.Rows.Add(rcount);
            for (int i = 0; i < rcount; i++)
            {
                dgvCustomer.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                dgvCustomer.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[4].Value;
                dgvCustomer.Rows[i].Cells[2].Value = CheckSex(i);
                dgvCustomer.Rows[i].Cells[3].Value = dataGridView1.Rows[i].Cells[1].Value;
                dgvCustomer.Rows[i].Cells[4].Value = dataGridView1.Rows[i].Cells[2].Value;
                dgvCustomer.Rows[i].Cells[5].Value = dataGridView1.Rows[i].Cells[3].Value;
            }
        }

        public Image CheckSex(int row)
        {
            if (dgvCustomer.Rows[row].Cells[1].Value.ToString() == "1")
            {
                return female;
            }
            else
            {
                return male;
            }
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
            if (e.ColumnIndex == 2)
                MessageBox.Show("Clicked!");
        }
    }
}
