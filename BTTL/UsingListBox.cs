using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTL
{
    public partial class UsingListBox : Form
    {
        public UsingListBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBtn();
        }
        public void ControlBtn()
        {
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnLeftAll.Enabled = false;
            btnRightAll.Enabled = false;
            if (lstLeft.Items.Count > 0)
            {
                btnRight.Enabled = true;
                btnRightAll.Enabled = true;
                lstLeft.SelectedIndex = 0;                
            }
            if (lstRight.Items.Count > 0)
            {
                btnLeft.Enabled = true;
                btnLeftAll.Enabled = true;
                lstRight.SelectedIndex = 0;
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            lstRight.Items.Add(lstLeft.SelectedItem);
            lstLeft.Items.Remove(lstLeft.SelectedItem);
            ControlBtn();
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            lstRight.Items.AddRange(lstLeft.Items);
            lstLeft.Items.Clear();
            ControlBtn();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lstLeft.Items.Add(lstRight.SelectedItem);
            lstRight.Items.Remove(lstRight.SelectedItem);
            ControlBtn();
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            lstLeft.Items.AddRange(lstRight.Items);
            lstRight.Items.Clear();
            ControlBtn();
        }

    }
}
