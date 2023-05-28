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

namespace TripleX.v2.Customer
{
    public partial class Form_Customer : Form
    {
        public Form_Customer()
        {
            InitializeComponent();
            Connection.Connect();
            sql = "select * from TCustomer where ID <> 1";
            GetData(sql);

            //btnShow.Location = new Point(this.Right - btnShow.Width - 1, (btnShow.Height + this.Height)/2);
            btnShow.Left = this.Right - btnShow.Width - 1;
            btnShow.Top = (this.Height - btnShow.Height) / 2;
        }

        //Fields
        string sql;
        string customerID;
        Image female = Properties.Resources.female_26px;
        Image male = Properties.Resources.male_26px;

        //Methods
        public void GetData(string sqlTemp)
        {
            SharedClass.FillDGV(dataGridView1, sql, Connection.conn);
            int rcount = dataGridView1.RowCount;
            dgvCustomer.Rows.Clear();
            if(rcount > 0)
            {
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
        }

        public Image CheckSex(int row)
        {
            if (dgvCustomer.Rows[row].Cells[1].Value.ToString() == "0")
            {
                return female;
            }
            else
            {
                return male;
            }
        }

        #region <-- Filter Events --> 
        private void flpnTable_MouseEnter(object sender, EventArgs e)
        {
            btnShow.Visible = true;
        }
        private void pbShow_Click(object sender, EventArgs e)
        {
            if (pnFilter.Visible)
            {
                btnShow.Image = Properties.Resources.back_20px1;
                btnShow.Left = this.Right - btnShow.Width - 1;
                btnShow.Top = (this.Height - btnShow.Height) / 2;
                pnFilter.Visible = false;
            }
            else
            {
                btnShow.Image = Properties.Resources.forward_20px;
                btnShow.Left = this.Right - btnShow.Width - pnFilter.Width;
                btnShow.Top = (this.Height - btnShow.Height) / 2;
                pnFilter.Visible = true;
            }
        }
        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {

            }
        }
        private void pnFilter_MouseEnter(object sender, EventArgs e)
        {
            btnShow.Visible = false;
        }
        #endregion

        //Events
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                customerID = e.RowIndex.ToString();
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form form = new Form_AddCustomer();
            form.Show();
        }

        private void rbAllSex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllSex.Checked)
            {
                sql = "select * from TCustomer where ID <> 1";
                GetData(sql);
            }
        }

        private void rbOrdered_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrdered.Checked)
            {
                sql = "select * from TCustomer where ID <> 1 and IsMale = 1";
                GetData(sql);
            }
        }

        private void rbHasCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrdered.Checked)
            {
                sql = "select * from TCustomer where ID <> 1 and IsMale = 0";
                GetData(sql);
            }
        }

        
    }
}
