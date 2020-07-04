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
    
    public partial class AddKhuCanHo : Form
    {
        KhuCanHoDAL kch = new KhuCanHoDAL();
        public AddKhuCanHo()
        {
            InitializeComponent();
        }

        private void button_them_AddKhuCanHo_Click(object sender, EventArgs e)
        {
            Regex rex_maKhu = new Regex(@"^\D{3}$");
            if (!rex_maKhu.IsMatch(maKhu_themKhuCanHo.Text))
                MessageBox.Show("Mã căn hộ gồm 3 kí tự.");

            Regex rex_tenKhu = new Regex(@"^\D{4,10}$");
            if (!rex_tenKhu.IsMatch(tenKhu_themKhuCanHo.Text))
                MessageBox.Show("Tên khu.?");

            Regex rex_soTang = new Regex(@"^\d{1,2}$");
            if (!rex_soTang.IsMatch(soTang_themKhuCanHo.Text))
                MessageBox.Show("Số tầng.?");

            Regex rex_soCan = new Regex(@"^\d{1,2}$");
            if (!rex_soCan.IsMatch(soCan_themKhuCanHo.Text))
                MessageBox.Show("Số căn.?");

            Regex rex_diaChi = new Regex(@"^\D{2,45}$");
            if (!rex_diaChi.IsMatch(diaChi_themKhuCanHo.Text))
                MessageBox.Show("Địa chỉ.?");

            if (rex_maKhu.IsMatch(maKhu_themKhuCanHo.Text) && rex_tenKhu.IsMatch(tenKhu_themKhuCanHo.Text) 
                && rex_soTang.IsMatch(soTang_themKhuCanHo.Text) && rex_soCan.IsMatch(soCan_themKhuCanHo.Text) && rex_diaChi.IsMatch(diaChi_themKhuCanHo.Text))
            {
                kch.maKhu = maKhu_themKhuCanHo.Text;
                kch.tenKhu = tenKhu_themKhuCanHo.Text;
                kch.soTang = int.Parse(soTang_themKhuCanHo.Text);
                kch.soCan = int.Parse(soCan_themKhuCanHo.Text);
                kch.diaChi = diaChi_themKhuCanHo.Text;

                if (NhanVien_Controller.Instance.Add_KhuCanHo(kch) > 0)
                {

                    MessageBox.Show("Thêm Thành công..!");
                    var myParent = (KhuCanHo)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }

            
        }

        private void button_thoat_AddKhuCanHo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
