using Buoi6.Core.B1;
using Buoi6.Modal;
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

namespace Buoi6
{
    public partial class B1 : Form
    {
        Services svs;
        public B1()
        {
            InitializeComponent();
            svs = new Services();
        }      
        private void B1_Load(object sender, EventArgs e)
        {
            string[] dts = File.ReadAllLines(@"E:\LuuDuLieuSinhVien\VuNgoDat_2001202045_SM24\BTTL\ListDanToc.txt");
            dts.ToList().ForEach(x => cboEthnic.Items.Add(x));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (svs.CheckItemExistInList(txtId.Text))
            {
                MessageBox.Show("Đã tồn tại sinh viên có mã là " + txtId.Text, "Hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                var gender = panelGender.Controls.OfType<RadioButton>().ToList().Where(x => x.Checked).FirstOrDefault();              
                var fls = svs.ConvertString(panelFL);
                var ethnic = cboEthnic.Text;
                Student std = new Student(txtName.Text, txtId.Text, gender.Text == "Nam" ? true : false, fls, ethnic);
                svs.List.Add(std);
                lstvOutput.Items.Add(new ListViewItem(svs.ConvertStudentToStringArr(std)));
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Mày có muốn chỉnh sửa sinh ziên lày?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (check == DialogResult.Yes)
            {
                if (lstvOutput.FocusedItem != null && lstvOutput.FocusedItem.Index >= 0)
                {
                    if (!svs.CheckItemExistInList(txtId.Text))
                    {
                        ListViewItem item = lstvOutput.FocusedItem;                
                        item.SubItems[0].Text = txtName.Text;
                        item.SubItems[1].Text = txtId.Text;
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại sinh viên có mã là " + txtId.Text, "Hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Mày có muốn xóa sinh ziên lày? Xóa lộn đừng đi hỏi tao cách khôi phục, không tao lại đấm cho vỡ mồm nghe chưa 3:))", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (check == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstvOutput.SelectedItems)
                {
                    item.Remove();
                }
            }
        }


        private void lstvOutput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.Location.X + e.X + lstvOutput.Location.X + 20, this.Location.Y + e.Y + lstvOutput.Location.Y);
            }

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);    
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDel_Click(sender, e);
        }

        private void sửaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

    }
}
