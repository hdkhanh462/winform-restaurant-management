using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleX.v2.Customer
{
    public partial class CCustomer : UserControl
    {
        //Feilds
        string id;
        string name;
        string cccd;
        string phone;
        string isMale = "2";
        int parentWidth;
        bool isSelected = false;
        //Events
        public event EventHandler _CClick;

        //Properties
        [Category("CCustomer Setting")]
        public string ID
        {
            get { return id; }
            set
            {
                id = value;
                lbName.Tag = id;
                Invalidate();
            }
        }

        [Category("CCustomer Setting")]
        public string CName
        {
            get { return name; }
            set
            {
                name = value;
                lbName.Text = name;
                Invalidate();
            }
        }

        [Category("CCustomer Setting")]
        public string CCCD
        {
            get { return cccd; }
            set
            {
                cccd = value;
                lbCCCD.Text = cccd;
                Invalidate();
            }
        }

        [Category("CCustomer Setting")]
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                lbPhone.Text = phone;
            }

        }

        [Category("CCustomer Setting")]
        public string IsMale
        {
            get { return isMale; }
            set
            {
                isMale = value;
                if (isMale == "2")
                {
                    btnSex.Image = Properties.Resources.male_26px;
                }
                else if (isMale == "1")
                {
                    btnSex.Image = Properties.Resources.female_26px;
                }
                Invalidate();
            }
        }

        [Category("CCustomer Setting")]
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                foreach(Control c in this.Controls)
                {
                    if (isSelected)
                    {
                        if (c.GetType() == typeof(Label))
                        {
                            c.BackColor = Color.FromArgb(249, 110, 48);
                            c.ForeColor = Color.FromArgb(242, 242, 242);
                        }
                        if (c.GetType() == typeof(Panel))
                        {
                            c.BackColor = Color.FromArgb(242, 242, 242);
                        }
                        btnSex.BackColor = Color.FromArgb(249, 110, 48);
                    }
                    else
                    {
                        if (c.GetType() == typeof(Label))
                        {
                            c.BackColor = Color.FromArgb(242, 242, 242);
                            c.ForeColor = Color.FromArgb(249, 110, 48);
                        }
                        if (c.GetType() == typeof(Panel))
                        {
                            c.BackColor = Color.FromArgb(249, 110, 48);
                        }
                        btnSex.BackColor = Color.FromArgb(242, 242, 242);
                    }
                }
                Invalidate();
            }
        }

        //Constructor
        public CCustomer()
        {
            InitializeComponent();
            Font font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Font = Font;
            lbCCCD.Font = Font;
            lbPhone.Font = Font;

            Color color = Color.FromArgb(249, 110, 48);
            lbName.ForeColor = color;
            lbCCCD.ForeColor = color;
            lbPhone.ForeColor = color;
            this.BackColor = Color.FromArgb(242, 242, 242);
        }

        //Methods

        void LbClick()
        {
            if (IsSelected)
                IsSelected = false;
            else
                IsSelected = true;
            Invalidate();
        }
        private void lbName_Click(object sender, EventArgs e)
        {
            if (_CClick != null)
            {
                _CClick.Invoke(sender, e);
                LbClick();
            }
        }

        private void lbCCCD_Click(object sender, EventArgs e)
        {
            if (_CClick != null)
            {
                _CClick.Invoke(sender, e);
                LbClick();
            }
        }

        private void lbPhone_Click(object sender, EventArgs e)
        {
            if (_CClick != null)
            {
                _CClick.Invoke(sender, e);
                LbClick();
            }
        }
    }
}
