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

namespace TripleX.v2.Table
{
    public partial class Form_Table : Form
    {
        public Form_Table()
        {
            InitializeComponent();
            Connection.Connect();
            SetScroll();
            GetData();
        }

        //Fields
        string sql;
        public static string tableID;
        public static string oTableID;

        //Methods
        public void GetData()
        {
            rbEmpty.Checked = true;
            rbSmall.Checked = false;
            rbAvg.Checked = false;
            rbBig.Checked = false;
            sql = "select * from TTable where ID <> 1 and TStatus = 1";
            GetEmptyTable(sql);
        }
        private void SetScroll()
        {
            flpnTable.AutoScroll = false;
            flpnTable.VerticalScroll.Maximum = 0;
            flpnTable.VerticalScroll.Visible = false;
            flpnTable.HorizontalScroll.Maximum = 0;
            flpnTable.HorizontalScroll.Visible = false;
            flpnTable.AutoScroll = true;
        }
        private string DateToString(string date)
        {
            DateTime dtOrederDate = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss", SharedClass.cultureVN);
            string dateTime = dtOrederDate.ToString("dd/MM/yyyy HH:mm", SharedClass.cultureVN);
            return dateTime;
        }
        void CheckedChange(string kind)
        {
            sql = "select * from TTable where ID <> 1 and TKind = " + kind + " and TStatus = ";
            if (rbEmpty.Checked == true)
            {
                sql = sql + "1";
                GetEmptyTable(sql);
            }

            if (rbOrdered.Checked == true)
            {
                sql = "select * from VOTable where TKind = " + kind;
                GetOrderTable(sql);
            }
        }

        #region <-- Checked Changed Events
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChange("1");
        }
        private void rbAvg_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChange("2");
        }
        private void rbBig_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChange("3");
        }
        private void rbEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpty.Checked == true)
            {
                sql = "select * from TTable where TStatus = 1";
                GetEmptyTable(sql);
                rbSmall.Checked = false;
                rbAvg.Checked = false;
                rbBig.Checked = false;
            }
        }
        private void rbOrdered_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrdered.Checked == true)
            {
                sql = "select * from VOTable";
                GetOrderTable(sql);
                rbSmall.Checked = false;
                rbAvg.Checked = false;
                rbBig.Checked = false;
            }
        }
        private void rbHasCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHasCustomer.Checked == true)
            {
                sql = "select * from VOTable";
                GetHasCustomerTable(sql);
                rbSmall.Checked = false;
                rbAvg.Checked = false;
                rbBig.Checked = false;
            }
        }
        #endregion

        #region <-- Show Tables -->
        void GetEmptyTable(string sqlTemp)
        {
            SqlDataReader reader = SqlClass.ReadData(sqlTemp, Connection.conn);
            flpnTable.Controls.Clear();
            while (reader.Read())
            {

                UC_Table ct = new UC_Table();
                ct.TableID = reader["ID"].ToString();
                ct.TableName = reader["TName"].ToString();
                ct.TableStatus = "1";
                ct.Chair = reader["TChair"].ToString();
                ct.Margin = new Padding(5);

                ct._Click += new EventHandler(addOrder);
                flpnTable.Controls.Add(ct);
            }
            reader.Close();
        }
        void GetOrderTable(string sqlTemp)
        {
            SqlDataReader reader = SqlClass.ReadData(sqlTemp, Connection.conn);
            flpnTable.Controls.Clear();
            while (reader.Read())
            {

                CTable ct = new CTable();
                ct.TableID = reader["ID"].ToString();
                ct.OTableID = reader["OID"].ToString();
                ct.TableName = reader["TName"].ToString();
                ct.TableStatus = reader["TStatus"].ToString();
                ct.Customer = reader["CName"].ToString();
                ct.OrderDate = DateToString(reader["OTake"].ToString());
                ct.Chair = "Số Ghế: " + reader["TChair"].ToString();
                ct.Margin = new Padding(5);

                ct._CClick += new EventHandler(editOrder);
                flpnTable.Controls.Add(ct);
            }
            reader.Close();
        }
        void GetHasCustomerTable(string sqlTemp)
        {
            SqlDataReader reader = SqlClass.ReadData(sqlTemp, Connection.conn);
            flpnTable.Controls.Clear();
            while (reader.Read())
            {

                CTable ct = new CTable();
                ct.TableID = reader["ID"].ToString();
                ct.OTableID = reader["OID"].ToString();
                ct.TableName = reader["TName"].ToString();
                ct.TableStatus = reader["TStatus"].ToString();
                ct.Customer = reader["CName"].ToString();
                ct.OrderDate = DateToString(reader["OTake"].ToString());
                ct.Chair = "Số Ghế: " + reader["TChair"].ToString();
                ct.Margin = new Padding(5);

                ct._CClick += new EventHandler(editOrder);
                flpnTable.Controls.Add(ct);
            }
            reader.Close();
        }
        private void addOrder(object sender, EventArgs e)
        {
            tableID = ((Control)sender).Tag.ToString();
            Form form = new Form_OrederTable();
            form.ShowDialog();
        }
        private void editOrder(object sender, EventArgs e)
        {
            string temp = ((Control)sender).Tag.ToString();
            int pos = temp.IndexOf(",");
            tableID = temp.Substring(0, pos);
            oTableID = temp.Substring(pos + 1);
            Form form = new EditTable();
            form.ShowDialog();
            //CMessageBox.Show(temp);
        }
        #endregion

        #region <-- Filter Events --> 
        private void flpnTable_MouseEnter(object sender, EventArgs e)
        {
            pnSubFilter.Visible = true;
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            if (pnFilter.Visible)
            {
                pbShow.Image = Properties.Resources.back_20px1;
                pnFilter.Visible = false;
            }
            else
            {
                pbShow.Image = Properties.Resources.forward_20px;
                pnFilter.Visible = true;
            }
        }

        private void pbShow_MouseLeave(object sender, EventArgs e)
        {
            pnSubFilter.Visible = false;
        }
        #endregion

        //Events
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Form form = new Form_AddTable();
            form.Show();
        }
        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if(txtSearch.Texts != "")
            {
                if (rbEmpty.Checked)
                {
                    sql = "select * from TTable where TStatus = 1 and TName like N'%" + txtSearch.Texts + "%'";
                    GetEmptyTable(sql);
                }
                else
                {
                    sql = "select * from VOTable where TName like N'%" + txtSearch.Texts + "%'";
                    GetOrderTable(sql);
                }
                rbSmall.Checked = false;
                rbAvg.Checked = false;
                rbBig.Checked = false;
            }
        }
    }
}
