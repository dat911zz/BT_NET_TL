using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTL
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] dts = File.ReadAllLines(@"E:\LuuDuLieuSinhVien\VuNgoDat_2001202045_SM24\BTTL\ListDanToc.txt");
            dts.ToList().ForEach(x => cboDanToc.Items.Add(x));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (cboDanToc.SelectedIndex >= 0)
            {
                lbResult.Text = s + cboDanToc.SelectedItem.ToString();
            }
            else
            {
                lbResult.Text = "Chọn dân tộc đi thằng đầu moiz!";
            }
        }
    }
}
