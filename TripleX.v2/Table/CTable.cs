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
    public partial class CTable : UserControl
    {
        //Fields
        string id;
        string oTableID = "";
        string name;
        string status;
        string customer;
        string date;
        string chair;
        Image image = Properties.Resources.coffee_table_32px1;

        //Events
        public event EventHandler _CClick;

        //Properties
        [Category("CTable Setting")]
        public string OTableID
        {
            get { return oTableID; }
            set
            {
                oTableID = value;
                if (oTableID != "")
                {
                    foreach (var control in GetControlHierarchy(this))
                    {
                        control.Tag = id + "," + oTableID;
                    }
                }
                Invalidate();
            }
        }

        [Category("CTable Setting")]
        public string TableID
        {
            get { return id; }
            set
            {
                id = value;
                foreach (var control in GetControlHierarchy(this))
                {
                    control.Tag = id;
                }
                Invalidate();
            }
        }

        [Category("CTable Setting")]
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

        [Category("CTable Setting")]
        public string TableStatus
        {
            get { return status; }
            set
            {
                status = value;
                if(status == "1")
                {
                    lbStatus.Text = "Bàn Trống";
                }
                else
                {
                    lbStatus.Text = "Đã Được Đặt";
                }
                Invalidate();
            }
        }

        [Category("CTable Setting")]
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

        [Category("CTable Setting")]
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

        [Category("CTable Setting")]
        public string Chair
        {
            get { return chair; }
            set
            {
                chair = value;
                lbChair.Text = chair;
                Invalidate();
            }
        }

        [Category("CTable Setting")]
        public Image TableImage
        {
            get { return image; }
            set
            {
                image = value;
                pictureBox1.Image = image;
                Invalidate();
            }
        }

        //Constructor
        public CTable()
        {
            InitializeComponent();
            Font font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Color color = Color.FromArgb(252, 74, 26);
            lbStatus.Font = font;
            lbDate.Font = font;
            lbName.Font = font;
            lbCustomer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point); ;
            lbChair.Font = font;
            lbDate.TextAlign = ContentAlignment.MiddleLeft;

            lbName.BackColor = color;
            lbStatus.BackColor = color;
            lbCustomer.BackColor = color;
            lbDate.BackColor = Color.LightGray;
            lbChair.BackColor = Color.LightGray;

            foreach (var control in GetControlHierarchy(this))
            {
                control.Click += ClickEvent;
            }
        }

        //Methods
        private IEnumerable<Control> GetControlHierarchy(Control root)
        {
            var queue = new Queue<Control>();

            queue.Enqueue(root);

            do
            {
                var control = queue.Dequeue();

                yield return control;

                foreach (var child in control.Controls.OfType<Control>())
                    queue.Enqueue(child);

            } while (queue.Count > 0);

        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (_CClick != null)
                _CClick.Invoke(sender, e);
        }
    }
}
