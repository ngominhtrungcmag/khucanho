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
        NhanVienDAL nv = new NhanVienDAL();
        public AddGiaoDich(NhanVienDAL nv)
        {
            InitializeComponent();
            this.nv = nv;
            maNhanVien_themGiaoDich.Text = nv.maNhanVien;


            // load to combobox
            DataTable dt = NhanVien_Controller.Instance.Load_KhachHang();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                string text = dt.Rows[j]["maKhachHang"].ToString() +" - "+ dt.Rows[j]["tenKhachHang"].ToString();
                this.comboBox_maKhachHang.Items.Add(text);
            }

            dt = NhanVien_Controller.Instance.Load_CanHo();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                string text = dt.Rows[j]["maCanHo"].ToString();
                this.comboBox_maCanHo.Items.Add(text);
            }


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

            string[] text_maKH = comboBox_maKhachHang.SelectedItem.ToString().Split('-');

            Regex rex_maKH = new Regex(@"^\d{6}$");
            if (!rex_maKH.IsMatch(text_maKH[0]))
                MessageBox.Show("Mã khách hàng.?");

            Regex rex_maNV = new Regex(@"^\d{8}$");
            if (!rex_maNV.IsMatch(maNhanVien_themGiaoDich.Text))
                MessageBox.Show("Mã nhân viên.?");

            string text_maCH = comboBox_maCanHo.SelectedItem.ToString().Trim();
            Regex rex_maCH = new Regex(@"^\d{6}$");
            if (!rex_maCH.IsMatch(text_maCH))
                MessageBox.Show("Mã căn hộ.?");

            if (rex_maHD.IsMatch(maHopDong_themGiaoDich.Text) && rex_maHD.IsMatch(maHopDong_themGiaoDich.Text) && rex_maHD.IsMatch(maHopDong_themGiaoDich.Text) && rex_maHD.IsMatch(maHopDong_themGiaoDich.Text))
            {

                hopDongDAL.maHopDong = maHopDong_themGiaoDich.Text;
                hopDongDAL.maKhachHang = text_maKH[0];
                hopDongDAL.maNhanVien = maNhanVien_themGiaoDich.Text;
                hopDongDAL.maCanHo = text_maCH;
                hopDongDAL.ngayGiaoDich = dateTimePicker_ngayGiaoDich.Value.Date.ToString("yyyy-MM-dd");

                if (NhanVien_Controller.Instance.Add_GiaoDich(hopDongDAL) > 0)
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
    }
}
