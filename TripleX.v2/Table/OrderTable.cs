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
using TripleX.v2.Customer;

namespace TripleX.v2.Table
{
    public partial class OrderTable : Form
    {
        //Field
        string tableID;
        string customerID;
        string orderFoodID;
        string sql;

        public OrderTable()
        {
            InitializeComponent();
            GetData();
        }

        //Methods
        void GetData()
        {
            tableID = TableM.tableID;
            sql = "select * from TCustomer";
            SharedClass.FillDGV(siticoneDataGridView1, sql, Connection.conn);
        }

        private void selectCustomer(object sender, EventArgs e)
        {
            customerID = ((Label)sender).Tag.ToString();
        }

        private string DateToString(CDatePicker dtpDate)
        {
            DateTime dtOrederDate = DateTime.ParseExact(dtpDate.Value.ToString(), "dd/MM/yyyy HH:mm:ss", SharedClass.cultureVN);
            string date = dtOrederDate.ToString("dd/MM/yyyy", SharedClass.cultureVN);
            return date;
        }

        private string TimeToString(CDatePicker dtpTime)
        {
            DateTime dtOrderTime = DateTime.ParseExact(dtpTime.Value.ToString(), "dd/MM/yyyy HH:mm:ss", SharedClass.cultureVN);
            string time = dtOrderTime.ToString("HH:mm:ss", SharedClass.cultureVN);
            return time;
        }

        private void pnCustomer_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(pnCustomer, 8, e.Graphics, Color.Empty, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = "exec POTable " + tableID + "," + customerID + ",N'" + DateToString(dtpBookDate) + " " + TimeToString(dtpBookTime)
                + "',N'" + DateToString(dtpTakeDate) + " " + TimeToString(dtpTakeTime) + "','" + orderFoodID + "'";
            CMessageBox.Show(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DeleteData();
        }

        private void cCustomer1__CClick(object sender, EventArgs e)
        {
            CMessageBox.Show("2");
        }
    }
}
