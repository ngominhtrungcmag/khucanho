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

namespace KhuCanHo.Views
{

    public partial class AddNhanvien : Form
    {
        public AddNhanvien()
        {
            InitializeComponent();
        }

        private void AddNhanvien_Load(object sender, EventArgs e)
        {

        }

        private void button_themNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienDAL nhanvien = new NhanVienDAL();
            nhanvien.maNhanVien = txt_maNhanVien.Text.Trim();
            nhanvien.diaChi = txt_diaChi.Text.Trim();
            nhanvien.matKhau = txt_matKhau.Text.Trim();
            nhanvien.hoTen = txt_hoVaTen.Text.Trim();
            nhanvien.luongCung = txt_luong.Text.Trim();
            nhanvien.soCMND = txt_soCMND.Text.Trim();
            nhanvien.soDienThoai = txt_soDienThoai.Text.Trim();
            nhanvien.gioiTinh = txt_gioiTinh.Text.Trim();
            nhanvien.vaiTro = txt_vaiTro.Text.Trim();
            DateTime ngaysinh = dateTimePicker_addNhanVien.Value.Date;
            nhanvien.ngaySinh = ngaysinh.ToString("yyyy-MM-dd");
            if(Admin_Controller.Instance.Add_NhanVien(nhanvien) > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                var myParent = (fAdmin)this.Owner;
                myParent.RefreshForm();
                this.Close();
            }    
            
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
