using CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TripleX.v2
{
    public partial class UC_Table : UserControl
    {
        //Constructor
        public UC_Table()
        {
            InitializeComponent();
            oTableID = "";
            name = "B101";
            status = "1";
            customer = "";
            date = "01/01/1011 01:01";
            chair = "10";

            foreach (var control in SharedClass.GetAllControls(this))
            {
                control.Click += ClickEvent;
            }
        }

        //Fields
        string id;
        string oTableID;
        string name;
        string status;
        string customer;
        string date;
        string chair;

        Color colorEmpty = Color.DarkGray;
        Color colorOrdered = Color.FromArgb(96, 125, 139);
        Color colorHasCustomer = Color.FromArgb(252, 74, 26);
        Color fillColor;

        public event EventHandler _Click;

        #region <-- Properties -->
        [Category("Custom Control")]
        public string TableID
        {
            get { return id; }
            set
            {
                id = value;
                foreach (var control in SharedClass.GetAllControls(this))
                {
                    control.Tag = id;
                }
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public string OTableID
        {
            get { return oTableID; }
            set
            {
                oTableID = value;
                if (oTableID != "")
                {
                    foreach (var control in SharedClass.GetAllControls(this))
                    {
                        control.Tag = id + "," + oTableID;
                    }
                }
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public string TableName
        {
            get { return name; }
            set
            {
                name = value;
                lbName.Text = name;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public string TableStatus
        {
            get { return status; }
            set
            {
                status = value;
                if (status == "1")
                {
                    lbStatus.Text = "Bàn Trống";
                    lbStatus.Width = 93;
                    lbCustomer.Text = "Bàn Trống";
                    pbStatus.Image = Properties.Resources.table_32px2;
                    fillColor = colorEmpty;
                }
                else if (status == "2")
                {
                    lbStatus.Text = "Đã Được Đặt";
                    lbStatus.Width = 112;
                    pbStatus.Image = Properties.Resources.registration_32px;
                    fillColor = colorOrdered;
                }
                else
                {
                    lbStatus.Text = "Đã Có Khách";
                    lbStatus.Width = 112;
                    pbStatus.Image = Properties.Resources.checked_user_male_32px;
                    fillColor = colorHasCustomer;
                }
                this.BackColor = fillColor;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public string Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                lbCustomer.Text = customer;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public string OrderDate
        {
            get { return date; }
            set
            {
                date = value;
                lbDate.Text = date;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public string Chair
        {
            get { return chair; }
            set
            {
                chair = value;
                if(int.Parse(chair) < 10 && int.Parse(chair) > 0)
                {
                    lbChair.Text = "0" + chair;
                }
                else
                    lbChair.Text = chair;
                Invalidate();
            }
        }
        #endregion

        #region <-- Paint Events -->
        private void UC_Table_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(this, 10, e.Graphics, fillColor, 2);
        }
        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(pnContainer, 10, e.Graphics, Color.Empty, 0);
        }
        #endregion

        //Events
        private void ClickEvent(object sender, EventArgs e)
        {
            if (_Click != null)
                _Click.Invoke(sender, e);
        }
    }
}
