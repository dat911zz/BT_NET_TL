using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }
        DateTime time = new DateTime().AddMinutes(10);
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //for (int i = 0; i < 9999; i++)
            //{
            //    lbTime.Text = i.ToString("00:00:00");
            //    timer1.Interval = 20;
            //    lbTime.Refresh();
            //}
            timer1_Tick(sender, e);
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = time.ToLongTimeString();
        }
    }
}
