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
    public partial class OrderTable : Form
    {
        //Field
        string tableID;

        public OrderTable()
        {
            InitializeComponent();
            GetData();
        }

        //Methods
        void GetData()
        {
            tableID = TableM.tableID;
            cCustomer1.CName = tableID;
        }

        void DataIntoPanel()
        {

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
            //SavingData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DeleteData();
        }
    }
}
