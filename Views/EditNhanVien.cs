using KhuCanHo.Controller;
using KhuCanHo.Model;
using Microsoft.SqlServer.Management.HadrModel;
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
    public partial class EditNhanVien : Form
    {
        NhanVienDAL nhanvien = new NhanVienDAL();
        public EditNhanVien(NhanVienDAL nhanvien)
        {
            InitializeComponent();
            textBox_maNhanVien.Text = nhanvien.maNhanVien;
            textBox_hoVaTen.Text = nhanvien.hoTen;
            textBox_diaChi.Text = nhanvien.diaChi;
            textBox_matKhau.Text = nhanvien.matKhau;
            textBox_soCMND.Text = nhanvien.soCMND;
            textBox_soDienThoai.Text = nhanvien.soDienThoai;
            textBox_Luong.Text = nhanvien.luongCung;
            dateTimePicker_ngaySinh.Text = nhanvien.ngaySinh;
            MessageBox.Show(nhanvien.gioiTinh);
            if (nhanvien.gioiTinh=="True")
            {
                radioButton_nam.Checked = true;
                radioButton_nu.Checked = false;
            }
            else
            {
                radioButton_nu.Checked = true;
                radioButton_nam.Checked = false ;
            }
            if (nhanvien.vaiTro == "True")
            {
                radioButton_Admin.Checked = true;
                radioButton_NhanVien.Checked = false;
            }
            else
            {
                radioButton_NhanVien.Checked = true;
                radioButton_Admin.Checked = false;
            }
        }




        private void radioButton_nam_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton_nam.Checked = true;
            radioButton_nu.Checked = false;
        }

        private void radioButton_Admin_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton_Admin.Checked = true;
            radioButton_NhanVien.Checked = false;
        }

        private void radioButton_NhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton_NhanVien.Checked = true;
            radioButton_Admin.Checked = false;
        }

        private void btn_suaNhanVien_Click(object sender, EventArgs e)
        {
            int nam = 0, nu = 1;
            NhanVienDAL nhanvien = new NhanVienDAL();

            nhanvien.maNhanVien = textBox_maNhanVien.Text;
            nhanvien.matKhau = textBox_matKhau.Text;
            nhanvien.diaChi = textBox_diaChi.Text;
            DateTime ngaysinh = dateTimePicker_ngaySinh.Value.Date;
            nhanvien.ngaySinh = ngaysinh.ToString("yyyy-MM-dd");
            nhanvien.luongCung = textBox_Luong.Text;
            nhanvien.hoTen = textBox_hoVaTen.Text;
            nhanvien.soCMND = textBox_soCMND.Text;
            nhanvien.soDienThoai = textBox_soDienThoai.Text;
            if (radioButton_nam.Checked)
            {
                nhanvien.gioiTinh = nam.ToString();
            }
            else
            {
                nhanvien.gioiTinh = nu.ToString();
            }

            if (radioButton_Admin.Checked)
            {
                nhanvien.vaiTro = "1";
            }
            else
            {
                nhanvien.vaiTro = "0";
            }

            if (Admin_Controller.Instance.Update_NhanVien(nhanvien) >=1)
            {
                MessageBox.Show("Cập nhật thành công!");
                var myParent = (fAdmin)this.Owner;
                myParent.RefreshForm();
                this.Close();
            }    
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
