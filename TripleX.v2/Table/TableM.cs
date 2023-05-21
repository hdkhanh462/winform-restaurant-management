using CustomControl;
using FontAwesome.Sharp;
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
        string sql;
        public static string tableID;
        public static string oTableID;
        private CButton currentBtn;
        private Panel leftPn;
        public TableM()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500, Primary.DeepOrange500,
                Accent.DeepOrange400, TextShade.WHITE);
            Connection.Connect();
            SetScroll();
            GetData();
            leftPn = new Panel();
            leftPn.Size = new Size(60, 7);
            pnTop.Controls.Add(leftPn);
        }

        public void GetData()
        {
            rbEmpty.Checked = true;
            rbSmall.Checked = false;
            rbAgv.Checked = false;
            rbBig.Checked = false;
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
                ct.OTableID = reader["OID"].ToString();
                ct.TableName = reader["TName"].ToString();
                ct.TableStatus = reader["TStatus"].ToString();
                ct.Customer = reader["CName"].ToString();
                ct.OrderDate = DateToString(reader["OTake"].ToString());
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
            string temp = ((Control)sender).Tag.ToString();
            int pos = temp.IndexOf(",");
            tableID = temp.Substring(0, pos);
            oTableID = temp.Substring(pos + 1);
            Form form = new EditTable();
            form.ShowDialog();
            //CMessageBox.Show(temp);
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
                sql = "select * from VOTable where TKind = " + kind;
                GetOrderTable(sql);
            }
        }

        private void SetScroll()
        {
            flpTable.AutoScroll = false;
            flpTable.VerticalScroll.Maximum = 0;
            flpTable.VerticalScroll.Visible = false;
            flpTable.HorizontalScroll.Maximum = 0;
            flpTable.HorizontalScroll.Visible = false;
            flpTable.AutoScroll = true;
        }

        private string DateToString(string date)
        {
            DateTime dtOrederDate = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss", SharedClass.cultureVN);
            string dateTime = dtOrederDate.ToString("dd/MM/yyyy HH:mm", SharedClass.cultureVN);
            return dateTime;
        }

        void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (CButton)senderBtn;
                currentBtn.Image = CheckButton(true);
                currentBtn.BackColor = Color.FromArgb(242, 242, 242);

                leftPn.BackColor = Color.FromArgb(255, 87, 34);
                leftPn.Location = new Point(currentBtn.Location.X, 0);
                leftPn.Visible = true;
                leftPn.BringToFront();
            }
        }

        void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.Image = CheckButton(false);
                currentBtn.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        Image CheckButton(bool isSelect)
        {
            if (isSelect)
            {
                if (currentBtn.Name == "btnGiaSuc")
                {
                    return Properties.Resources.bull_32px1;
                }
                else if (currentBtn.Name == "btnGiaCam")
                {
                    return Properties.Resources.chicken_32px1;
                }
                else if (currentBtn.Name == "btnHaiSna")
                {
                    return Properties.Resources.crab_32px1;
                }
                else
                {
                    return Properties.Resources.wine_bottle_32px1;
                }
            }
            else
            {
                if (currentBtn.Name == "btnGiaSuc")
                {
                    return Properties.Resources.bull_32px;
                }
                else if (currentBtn.Name == "btnGiaCam")
                {
                    return Properties.Resources.chicken_32px;
                }
                else if (currentBtn.Name == "btnHaiSna")
                {
                    return Properties.Resources.crab_32px;
                }
                else
                {
                    return Properties.Resources.wine_bottle_32px;
                }
            }
        }

        //Events
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(pnTop, 8, e.Graphics, Color.Empty, 0);
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
                sql = "select * from VOTable";
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

        private void btnGiaSuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnGiaCam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnHaiSan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
