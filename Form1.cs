using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bang : Form
    {
        public Bang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Lv_01.SelectedItems.Count > 0)
            {
                ListViewItem lt = Lv_01.SelectedItems[0];
                string lastname = lt.SubItems[0].Text;
                string firstname = lt.SubItems[1].Text;
                string phone = lt.SubItems[2].Text;

                txtLastName.Text = lastname;
                txtFisrtName.Text = firstname;
                txtPhone.Text = phone;

            }
        }

        private void Lv_01_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txtLastName.Text);
            it.SubItems.Add(txtFisrtName.Text);
            it.SubItems.Add(txtPhone.Text);
            Lv_01.Items.Add(it);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Lv_01.SelectedItems.Count > 0)
            {
                ListViewItem item = Lv_01.SelectedItems[0];
                item.SubItems[0].Text = txtLastName.Text;
                item.SubItems[1].Text = txtFisrtName.Text;
                item.SubItems[2].Text = txtPhone.Text;

            }
            else
            {
                MessageBox.Show("Chọn dòng để sửa !");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (Lv_01.SelectedItems.Count > 0)
            {
                Lv_01.Items.RemoveAt(Lv_01.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa !");
            }
        }
    }
}
