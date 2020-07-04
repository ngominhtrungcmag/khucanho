using KhuCanHo.Controller;
using KhuCanHo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhuCanHo
{
    public partial class EditGiaoDich : Form
    {
        HopDongDAL hd = new HopDongDAL();
        public EditGiaoDich(HopDongDAL hd)
        {
            InitializeComponent();
            maHopDong_suaGiaoDich.Text = hd.maHopDong;
            maKhachHang_suaGiaoDich.Text = hd.maKhachHang;
            maNhanVien_suaGiaoDich.Text = hd.maNhanVien;
            maCanHo_suaGiaoDich.Text = hd.maCanHo;
            dateTimePicker_ngayGiaoDich.Text = hd.ngayGiaoDich;

        }

        private void button_sua_EditGiaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            Regex rex_maHD = new Regex(@"^\d{10}$");
            if (!rex_maHD.IsMatch(maHopDong_suaGiaoDich.Text))
                MessageBox.Show("Mã hợp đồng 10");

            Regex rex_maKH = new Regex(@"^\d{6}$");
            if (!rex_maHD.IsMatch(maKhachHang_suaGiaoDich.Text))
                MessageBox.Show("Mã khách hàng.?");

            Regex rex_maNV = new Regex(@"^\d{8}$");
            if (!rex_maHD.IsMatch(maNhanVien_suaGiaoDich.Text))
                MessageBox.Show("Mã nhân viên.?");

            Regex rex_maCH = new Regex(@"^\d{6}$");
            if (!rex_maHD.IsMatch(maCanHo_suaGiaoDich.Text))
                MessageBox.Show("Mã căn hộ.?");

            if (rex_maHD.IsMatch(maHopDong_suaGiaoDich.Text) && rex_maHD.IsMatch(maKhachHang_suaGiaoDich.Text) && rex_maHD.IsMatch(maNhanVien_suaGiaoDich.Text) && rex_maHD.IsMatch(maCanHo_suaGiaoDich.Text))
            {

                hd.maHopDong = maHopDong_suaGiaoDich.Text.Trim();
                hd.maKhachHang = maKhachHang_suaGiaoDich.Text;
                hd.maNhanVien = maNhanVien_suaGiaoDich.Text;
                hd.maCanHo = maCanHo_suaGiaoDich.Text;
                hd.ngayGiaoDich = dateTimePicker_ngayGiaoDich.Value.Date.ToString("yyyy-MM-dd").Trim();

                
                if (NhanVien_Controller.Instance.Update_GiaoDich(hd) > 0)
                {
                    MessageBox.Show("Update thành công..!");
                    var myParent = (GiaoDich)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }
        }

        private void button_thoat_EditGiaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
