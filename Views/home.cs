using KhuCanHo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhuCanHo
{
    public partial class Home : Form
    {
        NhanVienDAL nv = new NhanVienDAL();
        public Home(NhanVienDAL nv)
        {
            InitializeComponent();
            this.nv.maNhanVien = nv.maNhanVien;
        }

        private void panel_KhuCanHo_MouseClick(object sender, MouseEventArgs e)
        {
            KhuCanHo khuCanHo = new KhuCanHo();
            khuCanHo.Show();
        }

        private void panel_CanHo_MouseClick(object sender, MouseEventArgs e)
        {
            CanHo canHo = new CanHo();
            canHo.Show();
        }

        private void panel_KhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.Show();
        }

        private void panel_GiaoDich_MouseClick(object sender, MouseEventArgs e)
        {
            GiaoDich giaoDich = new GiaoDich(nv);
            giaoDich.Show();
        }

        private void panel_DienNuoc_MouseClick(object sender, MouseEventArgs e)
        {
            DienNuocKhac dienNuoc = new DienNuocKhac();
            dienNuoc.Show();
        }

        private void panel_NhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            NhanVien nhanVien = new NhanVien(nv);
            nhanVien.Show();
        }

        private void panel_KhuCanHo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
