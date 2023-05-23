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

namespace TripleX.v2.Food
{
    public partial class OrderFood : Form
    {
        //Fields
        private CButton currentBtn;
        private Panel leftPn;

        public OrderFood()
        {
            InitializeComponent();

            leftPn = new Panel();
            leftPn.Size = new Size(70, 7);
            pnTop.Controls.Add(leftPn);
        }

        //Methods
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
                currentBtn.BackColor = Color.Gainsboro;
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
                else if (currentBtn.Name == "btnHaiSan")
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
                else if (currentBtn.Name == "btnHaiSan")
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
