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
    public partial class AddGiaoDich : Form
    {
        HopDongDAL hopDongDAL = new HopDongDAL();
        public AddGiaoDich()
        {
            InitializeComponent();
        }

        
        private void button_thoat_AddGiaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button_them_AddGiaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            Regex rex_maHD = new Regex(@"^\d{10}$");
            if (!rex_maHD.IsMatch(maHopDong_themGiaoDich.Text))
                MessageBox.Show("Mã hợp đồng 10");

            Regex rex_maKH = new Regex(@"^\d{6}$");
            if (!rex_maHD.IsMatch(maHopDong_themGiaoDich.Text))
                MessageBox.Show("Mã khách hàng.?");

            Regex rex_maNV = new Regex(@"^\d{8}$");
            if (!rex_maHD.IsMatch(maHopDong_themGiaoDich.Text))
                MessageBox.Show("Mã nhân viên.?");

            Regex rex_maCH = new Regex(@"^\d{6}$");
            if (!rex_maHD.IsMatch(maHopDong_themGiaoDich.Text))
                MessageBox.Show("Mã căn hộ.?");

            if (rex_maHD.IsMatch(maHopDong_themGiaoDich.Text) && rex_maHD.IsMatch(maHopDong_themGiaoDich.Text) && rex_maHD.IsMatch(maHopDong_themGiaoDich.Text) && rex_maHD.IsMatch(maHopDong_themGiaoDich.Text))
            {
                
                hopDongDAL.maHopDong = maHopDong_themGiaoDich.Text;
                hopDongDAL.maKhachHang = maKhachHang_themGiaoDich.Text;
                hopDongDAL.maNhanVien = maNhanVien_themGiaoDich.Text;
                hopDongDAL.maCanHo = maCanHo_themGiaoDich.Text;
                hopDongDAL.ngayGiaoDich = dateTimePicker_ngayGiaoDich.Value.Date.ToString("yyyy-MM-dd");

                if(NhanVien_Controller.Instance.Add_GiaoDich(hopDongDAL) > 0)
                {
                    MessageBox.Show("Update thành công..!");
                    var myParent = (GiaoDich)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }

            
        }

        private void AddGiaoDich_Load(object sender, EventArgs e)
        {

        }

        private void maNhanVien_themGiaoDich_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
