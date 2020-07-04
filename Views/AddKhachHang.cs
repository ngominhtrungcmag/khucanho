using KhuCanHo.Controller;
using KhuCanHo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhuCanHo
{
    public partial class AddKhachHang : Form
    {
        bool tmp_gioiTinh = false;        
        public AddKhachHang()
        {
            InitializeComponent();

        }

        private void button_thoat_AddKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button_them_AddKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            KhachHangDAL khachHangDAL = new KhachHangDAL();

            Regex rex_maKH = new Regex(@"^\d{6}$");
            if (!rex_maKH.IsMatch(maKhachHang_themKhachHang.Text))
                MessageBox.Show("Mã KH gồm 6 kí tự.");

            Regex rex_tenKH = new Regex(@"^\D{2,45}$");
            if (!rex_tenKH.IsMatch(tenKhachHang_themKhachHang.Text))
                MessageBox.Show("Tên khách hàng.?");

            Regex rex_sdt = new Regex(@"^\d{10}$");
            if (!rex_sdt.IsMatch(soDienThoai_themKhachHang.Text))
                MessageBox.Show("Số điện thoại.?");

            Regex rex_cmnd = new Regex(@"^\d{9,12}$");
            if (!rex_cmnd.IsMatch(cmnd_themKhachHang.Text))
                MessageBox.Show("CMND.?");

            Regex rex_queQuan = new Regex(@"^\D{2,45}$");
            if (!rex_queQuan.IsMatch(quaQuan_themKhachHang.Text))
                MessageBox.Show("Quê quán.?");

            if (checkBox_nam.Checked == false && checkBox_nu.Checked == false)
                MessageBox.Show("Check giới tính.?");
            else tmp_gioiTinh = true;


            if (rex_maKH.IsMatch(maKhachHang_themKhachHang.Text) && rex_tenKH.IsMatch(tenKhachHang_themKhachHang.Text) 
                && rex_sdt.IsMatch(soDienThoai_themKhachHang.Text) && rex_cmnd.IsMatch(cmnd_themKhachHang.Text) 
                && rex_queQuan.IsMatch(quaQuan_themKhachHang.Text) && tmp_gioiTinh)
            {
                int tmp1 = 0, tmp2 = 1;
                khachHangDAL.maKhachHang = maKhachHang_themKhachHang.Text;
                khachHangDAL.tenKhachHang = tenKhachHang_themKhachHang.Text;
                DateTime ngaysinh = dateTimePicker_ngaySinh.Value.Date;
                khachHangDAL.ngaySinh = ngaysinh.ToString("yyyy-MM-dd");
                if (checkBox_nam.Checked)
                    khachHangDAL.gioiTinh = tmp1.ToString();
                if (checkBox_nu.Checked)
                    khachHangDAL.gioiTinh = tmp2.ToString();
                khachHangDAL.soDienThoai = soDienThoai_themKhachHang.Text;
                khachHangDAL.soCMND = cmnd_themKhachHang.Text;
                khachHangDAL.queQuan = quaQuan_themKhachHang.Text;

                if (NhanVien_Controller.Instance.Add_KhachHang(khachHangDAL) > 0)
                {

                    MessageBox.Show("Thêm Thành công..!");
                    var myParent = (KhachHang)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }


            

        }

        private void AddKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void tenKhachHang_themKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ngaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maKhachHang_themKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void soDienThoai_themKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
