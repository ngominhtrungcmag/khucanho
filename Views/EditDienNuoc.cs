using KhuCanHo.Controller;
using KhuCanHo.Model;
using Microsoft.SqlServer.Management.XEvent;
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
    
    public partial class EditDienNuoc : Form
    {
        private DienNuocDAL dinc = new DienNuocDAL();
        public EditDienNuoc(DienNuocDAL dinc)
        {
            InitializeComponent();
            maCanHo_suaDienNuoc.Text = dinc.maCanHo;
            eChiSoCu_suaDienNuoc.Text = dinc.eChiSoCu.ToString();
            eChiSoMoi_suaDienNuoc.Text = dinc.eChiSoMoi.ToString();
            wChiSoCu_suaDienNuoc.Text = dinc.wChiSoCu.ToString();
            wChiSoCMoi_suaDienNuoc.Text = dinc.wChiSoMoi.ToString();

        }

        private void button_them_EditDienNuoc_MouseClick(object sender, MouseEventArgs e)
        {
            Regex rex_maCan = new Regex(@"^\d{6}$");
            if (!rex_maCan.IsMatch(maCanHo_suaDienNuoc.Text))
                MessageBox.Show("Mã căn hộ gồm 6 kí tự.");

            Regex rex_eChiSoCu = new Regex(@"^\d{1,4}$");
            if (!rex_eChiSoCu.IsMatch(eChiSoCu_suaDienNuoc.Text))
                MessageBox.Show("Chỉ số điện cũ.?");

            Regex rex_eChiSoMoi = new Regex(@"^\d{1,4}$");
            if (!rex_eChiSoMoi.IsMatch(eChiSoMoi_suaDienNuoc.Text))
                MessageBox.Show("Chỉ số điện mới.?");

            Regex rex_wChiSoCu = new Regex(@"^\d{1,4}$");
            if (!rex_wChiSoCu.IsMatch(wChiSoCu_suaDienNuoc.Text))
                MessageBox.Show("Chỉ số nước cũ.?");

            Regex rex_wChiSoMoi = new Regex(@"^\d{1,4}$");
            if (!rex_wChiSoMoi.IsMatch(wChiSoCMoi_suaDienNuoc.Text))
                MessageBox.Show("Chỉ số nước mới.?");

            if (rex_maCan.IsMatch(maCanHo_suaDienNuoc.Text) && rex_eChiSoCu.IsMatch(eChiSoCu_suaDienNuoc.Text) && rex_eChiSoMoi.IsMatch(eChiSoMoi_suaDienNuoc.Text) && rex_wChiSoCu.IsMatch(wChiSoCu_suaDienNuoc.Text) && rex_wChiSoMoi.IsMatch(wChiSoCMoi_suaDienNuoc.Text))
            {


                dinc.maCanHo = maCanHo_suaDienNuoc.Text;
                dinc.eChiSoCu = int.Parse(eChiSoCu_suaDienNuoc.Text);
                dinc.eChiSoMoi = int.Parse(eChiSoCu_suaDienNuoc.Text);
                dinc.wChiSoCu = int.Parse(wChiSoCu_suaDienNuoc.Text);
                dinc.wChiSoMoi = int.Parse(wChiSoCu_suaDienNuoc.Text);

                if (NhanVien_Controller.Instance.Update_DienNuoc(dinc) > 0)
                {
                    MessageBox.Show("Thêm Thành công..!");
                    var myParent = (DienNuocKhac)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }
        }

        private void button_thoat_EditDienNuoc_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
