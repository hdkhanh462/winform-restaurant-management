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
    public partial class EditTable : Form
    {
        //Fields
        string sql;
        string tableID;
        string oTableID;
        string isPay = "1";
        
        public EditTable()
        {
            InitializeComponent();
            Connection.Connect();
            tableID = TableM.tableID;
            oTableID = TableM.oTableID;
            GetData();
        }

        public void GetData()
        {
            sql = "select TName from TTable where ID = " + tableID;
            lbTName.Text =  SqlClass.GetOneValue(sql, Connection.conn);

            sql = "exec PShowCustomerByOTableID " + oTableID;
            SqlDataReader reader = SqlClass.ReadData(sql, Connection.conn);
            while (reader.Read())
            {
                lbCName.Text = reader["CName"].ToString();
                lbCCCD.Text = reader["CCCD"].ToString();
                break;
            }
            reader.Close();

            sql = "select OBook,OTake from TOTable where ID = " + oTableID;
            SqlDataReader reader1 = SqlClass.ReadData(sql, Connection.conn);
            while (reader1.Read())
            {
                lbBook.Text = DateToString(reader1["OBook"].ToString());
                lbTake.Text = DateToString(reader1["OTake"].ToString());
                break;
            }
            reader1.Close();
            GetOFood();
        }

        void GetOFood()
        {
            sql = "select * from TOFood where ID <> 1";
            SharedClass.FillDGV(dgvOFood,sql, Connection.conn);
            //CMessageBox.Show(sql);
        }

        private string DateToString(string date)
        {
            DateTime dtOrederDate = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss", SharedClass.cultureVN);
            string dateTime = dtOrederDate.ToString("dd/MM/yyyy HH:mm", SharedClass.cultureVN);
            return dateTime;
        }

        private void cbIsPay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsPay.Checked)
                isPay = "2";
            else
                isPay = "1";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = "update TOTable set OIsTakeOrCancel = " + isPay + " where ID = " + oTableID;
            //SqlClass.RunSql(sql, Connection.conn);
            CMessageBox.Show(sql);
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
