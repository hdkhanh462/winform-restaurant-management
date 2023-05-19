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
using System.Windows.Forms.Design.Behavior;
using TripleX.v2.Customer;

namespace TripleX.v2.Table
{
    public partial class TableM : Form
    {
        //Fields
        public static string tableID;
        string sql;
        public TableM()
        {
            InitializeComponent();
            Connection.Connect();
            GetData();
        }

        public void GetData()
        {
            sql = "select * from TTable";
            GetEmptyTable(sql);
        }

        void GetEmptyTable(string sqlTemp)
        {
            SqlDataReader reader = SqlClass.ReadData(sqlTemp, Connection.conn);
            flpTable.Controls.Clear();
            while (reader.Read())
            {

                CTable ct = new CTable();
                ct.TableID = reader["ID"].ToString();
                ct.TableName = reader["TName"].ToString();
                ct.TableStatus = "1";
                ct.Customer = "Bàn Trống";
                ct.Chair = "Số Ghế: " + reader["TChair"].ToString();

                ct._CClick += new EventHandler(addOrder);
                flpTable.Controls.Add(ct);
            }
            reader.Close();
        }

        void GetOrderTable(string sqlTemp)
        {
            SqlDataReader reader = SqlClass.ReadData(sqlTemp, Connection.conn);
            flpTable.Controls.Clear();
            while (reader.Read())
            {

                CTable ct = new CTable();
                ct.TableID = reader["ID"].ToString();
                ct.TableName = reader["TName"].ToString();
                ct.TableStatus = reader["TStatus"].ToString();
                ct.Customer = reader["TStatus"].ToString();
                ct.Chair = "Số Ghế: " + reader["TChair"].ToString();

                ct._CClick += new EventHandler(editOrder);
                flpTable.Controls.Add(ct);
            }
            reader.Close();
        }

        private void addOrder(object sender, EventArgs e)
        {
            tableID = ((Label)sender).Tag.ToString();
            Form form = new OrderTable();
            form.ShowDialog();
        }

        private void editOrder(object sender, EventArgs e)
        {
            tableID = ((Label)sender).Tag.ToString();
            Form form = new OrderTable();
            form.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(panel2, 8, e.Graphics, Color.Empty, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(panel1, 8, e.Graphics, Color.Empty, 0);
        }

        private void cTable1__CClick(object sender, EventArgs e)
        {
            tableID = ((Label)sender).Tag.ToString();
            Form form = new OrderTable();
            form.ShowDialog();
        }

        private void grbStatus_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(grbStatus, 8, e.Graphics, Color.Empty, 0);
        }

        private void grbKind_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(grbKind, 8, e.Graphics, Color.Empty, 0);
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Form form = new AddTable();
            form.ShowDialog();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpty.Checked == true)
            {
                sql = "select * from TTable where TKind = 1 and TStatus = 1";
                GetEmptyTable(sql);
            }

            if (rbIsOrder.Checked == true)
            {
                sql = "select * from TTable where TKind = 1 and TStatus = 2";
                GetOrderTable(sql);
            }
        }
    }
}
