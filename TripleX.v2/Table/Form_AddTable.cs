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
    public partial class Form_AddTable : Form
    {
        public Form_AddTable()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = color60;
        }

        //Fields
        string sql;
        string kind = "1";
        public static Color color60 = Color.White;
        public static Color color30 = Color.FromArgb(14, 14, 14);
        public static Color color10 = Color.FromArgb(252, 74, 26);

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

        //Methods
        public static void ReLoadTableM()
        {
            var mainForm = Application.OpenForms.OfType<Form_Table>().Single();
            mainForm.GetData();
        }

        //Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int chair = int.Parse(txtChair.Texts);
            if (chair <= 4)
            {
                kind = "1";
            }
            if (chair >= 5 && chair < 8)
            {
                kind = "2";
            }
            if (chair >= 8)
            {
                kind = "3";
            }

            sql = "exec PTableAdd '" + txtName.Texts + "'," + txtChair.Texts + "," + kind;
            SqlClass.RunSql(sql, Connection.conn);
            SharedClass.Alert("Thêm Thành Công!", Form_Alert.enmType.Success);
            ReLoadTableM();
            //CMessageBox.Show(sql);
        }
    }
}
