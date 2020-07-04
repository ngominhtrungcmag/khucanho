using KhuCanHo.Controller;
using KhuCanHo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhuCanHo
{
    public partial class AddDienNuoc : Form
    {
        public AddDienNuoc()
        {
            InitializeComponent();
        }

        private void button_thoat_AddCanHo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button_them_AddCanHo_MouseClick(object sender, MouseEventArgs e)
        {
            Regex rex_maCan = new Regex(@"^\d{6}$");
            if (!rex_maCan.IsMatch(maCanHo_dinc.Text))
                MessageBox.Show("Mã căn hộ gồm 6 kí tự.");

            Regex rex_eChiSoCu = new Regex(@"^\d{1,4}$");
            if (!rex_eChiSoCu.IsMatch(eChiSoCu_dinc.Text))
                MessageBox.Show("Chỉ số điện cũ.?");

            Regex rex_eChiSoMoi = new Regex(@"^\d{1,4}$");
            if (!rex_eChiSoMoi.IsMatch(eChiSoMoi_dinc.Text))
                MessageBox.Show("Chỉ số điện mới.?");

            Regex rex_wChiSoCu = new Regex(@"^\d{1,4}$");
            if (!rex_wChiSoCu.IsMatch(wChiSoCu_dinc.Text))
                MessageBox.Show("Chỉ số nước cũ.?");

            Regex rex_wChiSoMoi = new Regex(@"^\d{1,4}$");
            if (!rex_wChiSoMoi.IsMatch(wChiSoMoi_dinc.Text))
                MessageBox.Show("Chỉ số nước mới.?");

            if (rex_maCan.IsMatch(maCanHo_dinc.Text) && rex_eChiSoCu.IsMatch(eChiSoCu_dinc.Text) && rex_eChiSoMoi.IsMatch(eChiSoMoi_dinc.Text) && rex_wChiSoCu.IsMatch(wChiSoCu_dinc.Text) && rex_wChiSoMoi.IsMatch(wChiSoMoi_dinc.Text))
            {
                DienNuocDAL dinc = new DienNuocDAL();
                dinc.maCanHo = maCanHo_dinc.Text;
                dinc.eChiSoCu = int.Parse(eChiSoCu_dinc.Text);
                dinc.eChiSoMoi = int.Parse(eChiSoMoi_dinc.Text);
                dinc.wChiSoCu = int.Parse(eChiSoCu_dinc.Text);
                dinc.wChiSoMoi = int.Parse(eChiSoMoi_dinc.Text);


                if (NhanVien_Controller.Instance.Add_DienNuoc(dinc) > 0)
                {
                    MessageBox.Show("Thêm Thành công..!");
                    var myParent = (DienNuocKhac)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }

            

        }
    }
}
