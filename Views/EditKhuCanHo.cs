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
    public partial class EditKhuCanHo : Form
    {
        KhuCanHoDAL kch = new KhuCanHoDAL();
        public EditKhuCanHo(KhuCanHoDAL kch)
        {
            InitializeComponent();
            soCan_suaKhuCanHo.Text= kch.soCan.ToString();
            soTang_suaKhuCanHo.Text =  kch.soTang.ToString();
            diaChi_suaKhuCanHo.Text = kch.diaChi;
            maKhu_suaKhuCanHo.Text = kch.maKhu;
            tenKhu_suaKhuCanHo.Text = kch.tenKhu;
        }

        private void button_sua_EditKhuCanHo_Click(object sender, EventArgs e)
        {
            Regex rex_maKhu = new Regex(@"^\D{3}$");
            if (!rex_maKhu.IsMatch(maKhu_suaKhuCanHo.Text))
                MessageBox.Show("Mã căn hộ gồm 3 kí tự.");

            Regex rex_tenKhu = new Regex(@"^\D{4,10}$");
            if (!rex_tenKhu.IsMatch(tenKhu_suaKhuCanHo.Text))
                MessageBox.Show("Tên khu.?");

            Regex rex_soTang = new Regex(@"^\d{1,2}$");
            if (!rex_soTang.IsMatch(soTang_suaKhuCanHo.Text))
                MessageBox.Show("Số tầng.?");

            Regex rex_soCan = new Regex(@"^\d{1,2}$");
            if (!rex_soCan.IsMatch(soCan_suaKhuCanHo.Text))
                MessageBox.Show("Số căn.?");

            Regex rex_diaChi = new Regex(@"^\D{2,45}$");
            if (!rex_diaChi.IsMatch(diaChi_suaKhuCanHo.Text))
                MessageBox.Show("Địa chỉ.?");

            if (rex_maKhu.IsMatch(maKhu_suaKhuCanHo.Text) && rex_tenKhu.IsMatch(tenKhu_suaKhuCanHo.Text)
                && rex_soTang.IsMatch(soTang_suaKhuCanHo.Text) && rex_soCan.IsMatch(soCan_suaKhuCanHo.Text) && rex_diaChi.IsMatch(diaChi_suaKhuCanHo.Text))
            {

                kch.maKhu = maKhu_suaKhuCanHo.Text;
                kch.tenKhu = tenKhu_suaKhuCanHo.Text;
                kch.soTang = int.Parse(soTang_suaKhuCanHo.Text);
                kch.soCan = int.Parse(soCan_suaKhuCanHo.Text);
                kch.diaChi = diaChi_suaKhuCanHo.Text;


                if (NhanVien_Controller.Instance.Update_KhuCanHo(kch) > 0)
                {

                    MessageBox.Show("Update thành công..!");
                    var myParent = (KhuCanHo)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }
        }

        private void button_thoat_EditKhuCanHo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
