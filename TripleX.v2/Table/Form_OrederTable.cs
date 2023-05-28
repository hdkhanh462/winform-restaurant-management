using CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TripleX.v2.Table
{
    public partial class Form_OrederTable : Form
    {
        public Form_OrederTable()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = color60;
            Connection.Connect();
            tableID = Form_Table.tableID;
            GetData();
        }

        //Fields
        string sql;
        string tableID;
        string customerID = "";
        Image female = Properties.Resources.female_26px;
        Image male = Properties.Resources.male_26px;
        public static Color color60 = Color.White;
        public static Color color30 = Color.FromArgb(14, 14, 14);
        public static Color color10 = Color.FromArgb(252, 74, 26);

        //Methods
        public void GetData()
        {
            sql = "select TName from TTable where ID = " + tableID;
            lbName.Text = SqlClass.GetOneValue(sql, Connection.conn);

            sql = "select * from TCustomer where ID <> 1";
            SharedClass.FillDGV(dataGridView1, sql, Connection.conn);
            int rcount = dataGridView1.RowCount;
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

        #region <-- Smooth Rounded Form -->
        //Fields
        private int borderRadius = 10;
        private int borderSize = 2;

        #region <-- Drag Form -->
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        //Events
        private void Form_RoundExample_Paint(object sender, PaintEventArgs e)
        {
            RoundAForm.FormPaint(e, this, borderRadius, color10, borderSize);
        }
        private void Form_RoundExample_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form_RoundExample_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form_RoundExample_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {
            RoundAForm.ControlRegionAndBorder(pnContainer, borderRadius - (borderSize / 2), e.Graphics, color10);
        }
        #endregion

        //Events
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCName.Texts = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customerID = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (customerID == "")
            {
                SharedClass.Alert("Chưa Chọn Khách Hàng!", Form_Alert.enmType.Success);
            }
            else if (rbOrder.Checked)
            {
                sql = "exec POTable " + tableID + "," + customerID + ",N'"
                    + lbCurrentTime + "',N'"
                    + DateToString(dtpTakeDate) + " " + TimeToString(dtpTakeTime) + "'";
                //SqlClass.RunSql(sql, Connection.conn);
                //CMessageBox.Show("Thêm Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Form_AddTable.ReLoadTableM();
                //this.Close();
                CMessageBox.Show(sql);
            }
            else if (rbTake.Checked)
            {
                sql = "exec PAutoOTable " + tableID + "," + customerID + ",N'"
                    + lbCurrentTime + "'";
                //SqlClass.RunSql(sql, Connection.conn);
                //CMessageBox.Show("Thêm Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Form_AddTable.ReLoadTableM();
                //this.Close();
                CMessageBox.Show(sql);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "delete TTable where ID = " + tableID;
            //SqlClass.RunSqlDel(sql, Connection.conn);
            //Form_AddTable.ReLoadTableM();
            CMessageBox.Show(sql);
            this.Close();
        }
        private void rbTake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTake.Checked)
            {
                dtpTakeDate.Enabled = false;
                dtpTakeTime.Enabled = false;
                lbCurrentTime.Enabled = false;
            }
        }
        private void rbOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrder.Checked)
            {
                dtpTakeDate.Enabled = true;
                dtpTakeTime.Enabled = true;
                lbCurrentTime.Enabled = true;
            }
        }
    }
}
