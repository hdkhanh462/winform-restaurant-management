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

namespace TripleX.v2.Table
{
    public partial class OrderTable : Form
    {
        //Fields
        string sql;
        string tableID;
        string customerID = "";
        Image female = Properties.Resources.female_26px;
        Image male = Properties.Resources.male_26px;
        public OrderTable()
        {
            InitializeComponent();
            Connection.Connect();
            tableID = TableM.tableID;
            GetData();
        }

        public void GetData()
        {
            sql = "select TName from TTable where ID = " + tableID;
            lbName.Text = SqlClass.GetOneValue(sql, Connection.conn);

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

        void ReLoadTableM()
        {
            var mainForm = Application.OpenForms.OfType<TableM>().Single();
            mainForm.GetData();
        }

        //Events
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
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
            sql = "exec POTable " + tableID + "," + customerID + ",N'"
                + DateToString(dtpBookDate) + " " + TimeToString(dtpBookTime) + "',N'"
                + DateToString(dtpTakeDate) + " " + TimeToString(dtpTakeTime) + "'";
            if(customerID == "")
            {
                SharedClass.Alert("Chưa Chọn Khách Hàng!", Form_Alert.enmType.Success);
            }
            else
            {
                SqlClass.RunSql(sql, Connection.conn);
                CMessageBox.Show("Thêm Thành Công!","Thông Báo!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                ReLoadTableM();
                this.Close();
                //CMessageBox.Show(sql);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "delete TTable where ID = " + tableID;
            SqlClass.RunSqlDel(sql, Connection.conn);
            ReLoadTableM();
            this.Close();
        }

        #region Shadown
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        private bool m_aeroEnabled;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        #endregion
    }
}
