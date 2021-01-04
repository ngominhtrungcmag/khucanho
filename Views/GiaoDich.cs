using KhuCanHo.Controller;
using KhuCanHo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhuCanHo
{
    public partial class GiaoDich : Form
    {
        NhanVienDAL nv = new NhanVienDAL();
        HopDongDAL hd = new HopDongDAL();

        public void RefreshForm()
        {
            dataGridView_GiaoDich.DataSource = NhanVien_Controller.Instance.Load_GiaoDich();
            dataGridView_GiaoDich.ReadOnly = true;
        }

        public GiaoDich(NhanVienDAL nv)
        {
            InitializeComponent();
            RefreshForm();
            this.nv = nv;  
        }

        private void button_them_GiaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            AddGiaoDich addGiaoDich = new AddGiaoDich(nv);
            addGiaoDich.Show(this);
            RefreshForm();
        }

        private void button_sua_GiaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            EditGiaoDich editGiaoDich = new EditGiaoDich(hd);
            editGiaoDich.Show();
            RefreshForm();
        }

        private void dataGridView_GiaoDich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView_GiaoDich.CurrentRow.Selected = true;
            dataGridView_GiaoDich.Rows[dataGridView_GiaoDich.CurrentRow.Index].Selected = true;
            int index = dataGridView_GiaoDich.CurrentRow.Index;
            if (index >= 0)
            {
                MessageBox.Show("chào bạn");
                hd.maHopDong = dataGridView_GiaoDich.Rows[index].Cells["maHopDong"].Value.ToString();
                hd.maKhachHang = dataGridView_GiaoDich.Rows[index].Cells["maKhachHang"].Value.ToString();
                hd.maNhanVien = dataGridView_GiaoDich.Rows[index].Cells["maNhanVien"].Value.ToString();
                hd.maCanHo = dataGridView_GiaoDich.Rows[index].Cells["maCanHo"].Value.ToString();
                hd.ngayGiaoDich = dataGridView_GiaoDich.Rows[index].Cells["ngayGiaoDich"].Value.ToString();
            }
        }



        private void button_xoa_giaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_Controller.Instance.Del_GiaoDich(hd);
                MessageBox.Show("Đã xóa thành công!");
                dataGridView_GiaoDich.DataSource = NhanVien_Controller.Instance.Load_GiaoDich();
            }
        }

        private void textBox_timKiem_GiaoDich_TextChanged(object sender, EventArgs e)
        {
            if (textBox_timKiem.Text != "")
            {
                string searchstr, field;
                searchstr = textBox_timKiem.Text;
                field = "maHopDong";
                switch (comboBox_timKiem.SelectedIndex)
                {
                    case 0:
                        field = "maHopDong";
                        // code block
                        break;
                    case 1:
                        field = "maKhachHang";
                        // code block
                        break;
                    case 2:
                        field = "maNhanVien";
                        // code block
                        break;
                    case 3:
                        field = "maCanHo";
                        // code block
                        break;
                    case 4:
                        field = "ngayGiaoDich";
                        // code block
                        break;
                }
                dataGridView_GiaoDich.DataSource = NhanVien_Controller.Instance.Search_GiaoDich(searchstr, field);
            }
            else
            {
                dataGridView_GiaoDich.DataSource = NhanVien_Controller.Instance.Load_GiaoDich();
            }
        }

        private void dataGridView_GiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_GiaoDich.CurrentRow.Selected = true;

            int index = dataGridView_GiaoDich.CurrentRow.Index;
            if (index >= 0)
            {
                MessageBox.Show("chào bạn");
                hd.maHopDong = dataGridView_GiaoDich.Rows[index].Cells["maHopDong"].Value.ToString();
                hd.maKhachHang = dataGridView_GiaoDich.Rows[index].Cells["maKhachHang"].Value.ToString();
                hd.maNhanVien = dataGridView_GiaoDich.Rows[index].Cells["maNhanVien"].Value.ToString();
                hd.maCanHo = dataGridView_GiaoDich.Rows[index].Cells["maCanHo"].Value.ToString();
                hd.ngayGiaoDich = dataGridView_GiaoDich.Rows[index].Cells["ngayGiaoDich"].Value.ToString();
            }
        }
    }
}
