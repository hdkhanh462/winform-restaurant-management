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
        public CustomerM()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            sql = "select * from TCustomer";
            SqlDataReader reader = SqlClass.ReadData(sql, Connection.conn);
            pnCustomer.Controls.Clear();
            while (reader.Read())
            {
                CCustomer cc = new CCustomer();
                cc.ID = reader["ID"].ToString();
                cc.CName = reader["CName"].ToString();
                cc.CCCD = reader["CCCD"].ToString();
                cc.Phone = reader["CPhone"].ToString();
                cc.IsMale = reader["IsMale"].ToString();

                cc._CClick += new EventHandler(selectCustomer);
                pnCustomer.Controls.Add(cc);
            }
            reader.Close();
        }

        private void selectCustomer(object sender, EventArgs e)
        {
            customerID = ((Label)sender).Tag.ToString();
        }
    }
}
