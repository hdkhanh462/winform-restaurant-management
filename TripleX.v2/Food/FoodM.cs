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
    public partial class FoodM : Form
    {
        //Fields
        string sql;
        Image cattle = Properties.Resources.bull_26px;
        Image poultry = Properties.Resources.chicken_26px;
        Image seafood = Properties.Resources.crab_26px;
        Image drink = Properties.Resources.wine_bottle_26px;

        public FoodM()
        {
            InitializeComponent();
            Connection.Connect();
            GetData();
        }

        public void GetData()
        {
            sql = "select * from TFood";
            SharedClass.FillDGV(dataGridView1, sql, Connection.conn);
            int rcount = dataGridView1.RowCount;
            dgvFood.Rows.Add(rcount);
            for (int i = 0; i < rcount; i++)
            {
                dgvFood.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                dgvFood.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                dgvFood.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                dgvFood.Rows[i].Cells[3].Value = CheckKind(i);
                dgvFood.Rows[i].Cells[4].Value = dataGridView1.Rows[i].Cells[3].Value;
            }
        }

        public Image CheckKind(int row)
        {
            if (dgvFood.Rows[row].Cells[2].Value.ToString() == "1")
            {
                return cattle;
            }
            else if(dgvFood.Rows[row].Cells[2].Value.ToString() == "2")
            {
                return poultry;
            }
            else if (dgvFood.Rows[row].Cells[2].Value.ToString() == "3")
            {
                return seafood;
            }
            else
            {
                return drink;
            }
        }
    }
}
