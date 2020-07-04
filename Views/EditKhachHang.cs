using KhuCanHo.Controller;
using KhuCanHo.Model;
using Microsoft.SqlServer.Management.Assessment.Checks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KhuCanHo
{
    public partial class EditKhachHang : Form
    {
        KhachHangDAL kh = new KhachHangDAL();
        bool tmp_gioiTinh = false;
        public EditKhachHang(KhachHangDAL kh)
        {
            InitializeComponent();

            maKhachHang_suaKhachHang.Text = kh.maKhachHang;
            maKhachHang_suaKhachHang.Enabled = false;
            tenKhachHang_suaKhachHang.Text = kh.tenKhachHang;
            dateTimePicker_suaKhachHang.Text = kh.ngaySinh;
            if (kh.gioiTinh == "True")
            {
                checkBox_Nam.Checked = true;
            }
            else
            {
                checkBox_Nu.Checked = true;
            }
            soDienThoai_suaKhachHang.Text = kh.soDienThoai;
            cmnd_suaKhachHang.Text = kh.soCMND;
            queQuan_suaKhachHang.Text = kh.queQuan;
        }

        private void button_sua_EditKhachHang_Click(object sender, EventArgs e)
        {
            Regex rex_maKH = new Regex(@"^\d{6}$");
            if (!rex_maKH.IsMatch(maKhachHang_suaKhachHang.Text))
                MessageBox.Show("Mã KH gồm 6 kí tự.");

            Regex rex_tenKH = new Regex(@"^\D{2,45}$");
            if (!rex_tenKH.IsMatch(tenKhachHang_suaKhachHang.Text))
                MessageBox.Show("Tên khách hàng.?");

            Regex rex_sdt = new Regex(@"^\d{10}$");
            if (!rex_sdt.IsMatch(soDienThoai_suaKhachHang.Text))
                MessageBox.Show("Số điện thoại.?");

            Regex rex_cmnd = new Regex(@"^\d{9,12}$");
            if (!rex_cmnd.IsMatch(cmnd_suaKhachHang.Text))
                MessageBox.Show("CMND.?");

            Regex rex_queQuan = new Regex(@"^\D{2,45}$");
            if (!rex_queQuan.IsMatch(queQuan_suaKhachHang.Text))
                MessageBox.Show("Quê quán.?");

            if (checkBox_Nam.Checked == false && checkBox_Nu.Checked == false)
                MessageBox.Show("Check giới tính.?");
            else tmp_gioiTinh = true;


            if (rex_maKH.IsMatch(maKhachHang_suaKhachHang.Text) && rex_tenKH.IsMatch(tenKhachHang_suaKhachHang.Text)
                && rex_sdt.IsMatch(soDienThoai_suaKhachHang.Text) && rex_cmnd.IsMatch(cmnd_suaKhachHang.Text)
                && rex_queQuan.IsMatch(queQuan_suaKhachHang.Text) && tmp_gioiTinh)
            {


                int temp1 = 0, temp2 = 1;
                kh.maKhachHang = maKhachHang_suaKhachHang.Text;
                kh.tenKhachHang = tenKhachHang_suaKhachHang.Text;
                DateTime ngaySinh = dateTimePicker_suaKhachHang.Value.Date;
                kh.ngaySinh = ngaySinh.ToString("yyyy-MM-dd");

                kh.queQuan = queQuan_suaKhachHang.Text;
                kh.soCMND = cmnd_suaKhachHang.Text.Trim();
                kh.soDienThoai = soDienThoai_suaKhachHang.Text;
                if (checkBox_Nam.Checked)
                {
                    kh.gioiTinh = temp1.ToString();
                }
                if (checkBox_Nu.Checked)
                {
                    kh.gioiTinh = temp2.ToString();
                }
                if (NhanVien_Controller.Instance.Update_KhachHang(kh) > 0)
                {
                    MessageBox.Show("Update thành công..!");
                    var myParent = (KhachHang)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }
        }

        private void button_thoat_EditKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_Nam_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Nu.Checked = false;
        }

        private void checkBox_Nu_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Nam.Checked = false;
        }
    }
}
