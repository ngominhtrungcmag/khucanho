using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhuCanHo.Controller;
using System.Windows.Forms;
using KhuCanHo.Model;

namespace KhuCanHo.Views
{
    public partial class fAdmin : Form
    {
        NhanVienDAL nhanvien = new NhanVienDAL();
        public fAdmin()
        {
            InitializeComponent();
        }

        public void RefreshForm()
        {
            dataGirdView_taiKhoan.DataSource = Load_Account();
            dataGirdView_taiKhoan.ReadOnly = true;
        }
        private void load_acount_Click(object sender, EventArgs e)
        {
            dataGirdView_taiKhoan.DataSource = Load_Account();
        }

        DataTable Load_Account()
        {
            return Admin_Controller.Instance.Load_Acount();
        }

        private void button_addAccount_Click(object sender, EventArgs e)
        {
            AddNhanvien addNhanVien = new AddNhanvien();
            addNhanVien.Show(this);
        }

        private void button_EditAccount_Click(object sender, EventArgs e)
        {            
            EditNhanVien editNhanVien = new EditNhanVien(nhanvien);
            editNhanVien.Show(this);
        }


        private void dataGirdView_taiKhoan_Click(object sender, EventArgs e)
        {
            dataGirdView_taiKhoan.CurrentRow.Selected = true;
            int index = dataGirdView_taiKhoan.CurrentRow.Index;
            if (index >= 0)
            {
                nhanvien.maNhanVien = dataGirdView_taiKhoan.Rows[index].Cells["maNhanVien"].Value.ToString();
                nhanvien.matKhau = dataGirdView_taiKhoan.Rows[index].Cells["maKhau"].Value.ToString();
                nhanvien.hoTen = dataGirdView_taiKhoan.Rows[index].Cells["hoTen"].Value.ToString();
                nhanvien.ngaySinh = dataGirdView_taiKhoan.Rows[index].Cells["ngaySinh"].Value.ToString();
                nhanvien.gioiTinh = dataGirdView_taiKhoan.Rows[index].Cells["gioiTinh"].Value.ToString();
                nhanvien.soDienThoai = dataGirdView_taiKhoan.Rows[index].Cells["soDienThoai"].Value.ToString();
                nhanvien.diaChi = dataGirdView_taiKhoan.Rows[index].Cells["diaChi"].Value.ToString();
                nhanvien.soCMND = dataGirdView_taiKhoan.Rows[index].Cells["soCMND"].Value.ToString();
                nhanvien.luongCung = dataGirdView_taiKhoan.Rows[index].Cells["luongCung"].Value.ToString();
                nhanvien.vaiTro = dataGirdView_taiKhoan.Rows[index].Cells["vaiTro"].Value.ToString();
            }
        }

        private void button_DelAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Admin_Controller.Instance.Del_NhanVien(nhanvien);
                MessageBox.Show("Đã xóa thành công!");
                dataGirdView_taiKhoan.DataSource = Admin_Controller.Instance.Load_Acount();

            }
        }
    }
}
