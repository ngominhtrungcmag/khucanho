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
    
    public partial class EditCanHo : Form
    {
        CanHoDAL caho = new CanHoDAL();
        bool tmp_status = false;
        public EditCanHo(CanHoDAL caho)
        {
            InitializeComponent();
            maCan_suaCanHo.Text = caho.maCanHo;
            maCan_suaCanHo.Enabled = false;
            dienTich_suaCanHo.Text = caho.dienTich;
          //  dienTich_suaCanHo.Text = Double.Parse(caho.dienTich).ToString();
            gia_suaCanHo.Text = caho.giaBan.ToString();
            soPhong_suaCanHo.Text = caho.soPhong.ToString();
            if (caho.trangThai == 1)
                checkBox_daBan.Checked = true;
            if (caho.trangThai == 0)
                checkBox_chuaBan.Checked = true;

            maKhu_suaCanHo.Text = caho.maKhu;
            


        }

        private void button_thoat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button_suaCanHo_MouseClick(object sender, MouseEventArgs e)
        {
            Regex rex_maCanHo = new Regex(@"^\d{6}$");
            if (!rex_maCanHo.IsMatch(maCan_suaCanHo.Text))
                MessageBox.Show("Mã căn hộ gồm 6 kí tự.");

            Regex rex_dienTich = new Regex(@"^\d{2,3}$");
            if (!rex_dienTich.IsMatch(dienTich_suaCanHo.Text))
                MessageBox.Show("Diện tích.?");

            Regex rex_giaBan = new Regex(@"^\d{4,9}$");
            if (!rex_giaBan.IsMatch(gia_suaCanHo.Text))
                MessageBox.Show("Giá bán.?");

            Regex rex_SoPhong = new Regex(@"^\d{1,2}$");
            if (!rex_SoPhong.IsMatch(soPhong_suaCanHo.Text))
                MessageBox.Show("Số phòng.?");

            Regex rex_maKhu = new Regex(@"^\D{3}$");
            if (!rex_maKhu.IsMatch(maKhu_suaCanHo.Text))
                MessageBox.Show("Mã khu.?");

            if (checkBox_daBan.Checked == false && checkBox_chuaBan.Checked == false)
                MessageBox.Show("Check trạng thái.");
            else tmp_status = true;

            if (rex_maCanHo.IsMatch(maCan_suaCanHo.Text) && rex_dienTich.IsMatch(dienTich_suaCanHo.Text) && rex_giaBan.IsMatch(gia_suaCanHo.Text) && rex_SoPhong.IsMatch(soPhong_suaCanHo.Text) && rex_maKhu.IsMatch(maKhu_suaCanHo.Text) && tmp_status)
            {


                caho.maCanHo = maCan_suaCanHo.Text;
                caho.dienTich = dienTich_suaCanHo.Text;
                caho.giaBan = Int32.Parse(gia_suaCanHo.Text);
                if (checkBox_daBan.Checked)
                {
                    caho.trangThai = 1;
                }
                if (checkBox_chuaBan.Checked)
                {
                    caho.trangThai = 0;
                }
                caho.soPhong = Int32.Parse(soPhong_suaCanHo.Text);
                caho.maKhu = maKhu_suaCanHo.Text;

                if (NhanVien_Controller.Instance.Update_CanHo(caho) > 0)
                {

                    MessageBox.Show("Update thành công..!");
                    var myParent = (CanHo)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }
        }
    }
}
