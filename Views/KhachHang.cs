using KhuCanHo.Controller;
using KhuCanHo.Model;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;
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
    public partial class KhachHang : Form
    {

        KhachHangDAL kh = new KhachHangDAL();
        public void RefreshForm()
        {
            dataGridView_KhachHang.DataSource = NhanVien_Controller.Instance.Load_KhachHang();
            dataGridView_KhachHang.ReadOnly = true;
        }
        public KhachHang()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void button_them_KhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            AddKhachHang addKhachHang = new AddKhachHang();
            addKhachHang.Show(this);
            RefreshForm(); 
        }

        private void button_sua_KhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            EditKhachHang editKhachHang = new EditKhachHang(kh);
            editKhachHang.Show(this);
            dataGridView_KhachHang.DataSource = NhanVien_Controller.Instance.Load_KhachHang();
            
        }

        private void button_DelKhachHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_Controller.Instance.Del_KhachHang(kh);
                MessageBox.Show("Đã xóa..!");
                dataGridView_KhachHang.DataSource = NhanVien_Controller.Instance.Load_KhachHang();
            }
        }

        private void dataGridView_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_KhachHang.CurrentRow.Selected = true;
            int index = e.RowIndex;
            if (index >= 0)
            {
                kh.maKhachHang = dataGridView_KhachHang.Rows[index].Cells["maKhachHang"].Value.ToString();
                kh.tenKhachHang = dataGridView_KhachHang.Rows[index].Cells["tenKhachHang"].Value.ToString();
                kh.ngaySinh = dataGridView_KhachHang.Rows[index].Cells["ngaySinh"].Value.ToString();
                kh.gioiTinh = dataGridView_KhachHang.Rows[index].Cells["gioiTinh"].Value.ToString();
                kh.soDienThoai = dataGridView_KhachHang.Rows[index].Cells["soDienThoai"].Value.ToString();
                kh.soCMND = dataGridView_KhachHang.Rows[index].Cells["soCMND"].Value.ToString();
                kh.queQuan = dataGridView_KhachHang.Rows[index].Cells["queQuan"].Value.ToString();
            }   
        }

        private void dataGridView_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_KhachHang.CurrentRow.Selected = true;
            int index = e.RowIndex;
            if (index >= 1)
            {
                kh.maKhachHang = dataGridView_KhachHang.Rows[index].Cells["maKhachHang"].Value.ToString();
                kh.tenKhachHang = dataGridView_KhachHang.Rows[index].Cells["tenKhachHang"].Value.ToString();
                kh.ngaySinh = dataGridView_KhachHang.Rows[index].Cells["ngaySinh"].Value.ToString();
                kh.gioiTinh = dataGridView_KhachHang.Rows[index].Cells["gioiTinh"].Value.ToString();
                kh.soDienThoai = dataGridView_KhachHang.Rows[index].Cells["soDienThoai"].Value.ToString();
                kh.soCMND = dataGridView_KhachHang.Rows[index].Cells["soCMND"].Value.ToString();
                kh.queQuan = dataGridView_KhachHang.Rows[index].Cells["queQuan"].Value.ToString();
            }
        }

        private void textBox_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (textBox_timKiem.Text != "")
            {
                string searchstr, field;
                searchstr = textBox_timKiem.Text;
                field = "maKhachHang";
                switch (comboBox_timKiem.SelectedIndex)
                {
                    case 0:
                        field = "maKhachHang";
                        // code block
                        break;
                    case 1:
                        field = "tenKhachHang";
                        // code block
                        break;
                    case 2:
                        field = "ngaySinh";
                        // code block
                        break;
                    case 3:
                        field = "gioiTinh";
                        // code block
                        break;
                    case 4:
                        field = "soDienThoai";
                        // code block
                        break;
                    case 5:
                        field = "soCMND";
                        // code block
                        break;
                    case 6:
                        field = "queQuan";
                        break;
                }
                dataGridView_KhachHang.DataSource = NhanVien_Controller.Instance.Search_KhachHang(searchstr, field);
            }
            else
            {
                dataGridView_KhachHang.DataSource = NhanVien_Controller.Instance.Load_KhachHang();
            }
        }
    }
}
