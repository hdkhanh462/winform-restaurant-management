using CustomControl;
using MaterialSkin;
using MaterialSkin.Controls;
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
        readonly MaterialSkinManager materialSkinManager;
        public static string tableID;
        string sql;
        public TableM()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.DeepOrange400, MaterialSkin.Primary.DeepOrange400, MaterialSkin.Primary.DeepOrange400,
                MaterialSkin.Accent.DeepOrange400, MaterialSkin.TextShade.WHITE);
            Connection.Connect();
            GetData();
        }

        public void GetData()
        {
            sql = "select * from TTable where ID <> 1 and TStatus = 1";
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
            tableID = ((Control)sender).Tag.ToString();
            Form form = new OrderTable();
            form.ShowDialog();
        }

        private void editOrder(object sender, EventArgs e)
        {
            tableID = ((Control)sender).Tag.ToString();
            Form form = new EditTable();
            form.ShowDialog();
        }

        void CheckedChange(string kind)
        {
            sql = "select * from TTable where ID <> 1 and TKind = " + kind + " and TStatus = ";
            if (rbEmpty.Checked == true)
            {
                sql = sql + "1";
                GetEmptyTable(sql);
            }

            if (rbIsOrder.Checked == true)
            {
                sql = sql + "2";
                GetOrderTable(sql);
            }
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
            tableID = ((Control)sender).Tag.ToString();
            Form form = new OrderTable();
            form.ShowDialog();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Form form = new AddTable();
            form.ShowDialog();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChange("1");
        }

        private void rbAgv_CheckedChanged(object sender, EventArgs e)
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
            }
        }

        private void rbIsOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIsOrder.Checked == true)
            {
                sql = "select * from TTable where TStatus = 2";
                GetOrderTable(sql);
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(panel13, 8, e.Graphics, Color.Empty, 0);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

            SharedClass.RoundedControl(panel14, 8, e.Graphics, Color.Empty, 0);
        }
    }
}
