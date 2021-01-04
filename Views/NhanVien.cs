using KhuCanHo.Controller;
using KhuCanHo.Model;
using KhuCanHo.Views;
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
    public partial class NhanVien : Form
    {
        
        DataTable dt = new DataTable();
        NhanVienDAL nv = new NhanVienDAL();
        public NhanVien(NhanVienDAL nv)
        {
            this.nv.maNhanVien = nv.maNhanVien;
            InitializeComponent();
            Load_NhanVien();
    
        }
        public void Load_NhanVien()
        {
            dt = NhanVien_Controller.Instance.Load_MyInFor(nv);
            DataRow[] dr = dt.Select("maNhanVien = '"+nv.maNhanVien+"'");

            foreach (DataRow row in dr)
            {
                textBox_maNhanVien.Text = row["maNhanVien"].ToString();
                textBox_hoVaTen.Text = row["hoTen"].ToString();
                textBox_diaChi.Text = row["diaChi"].ToString();
                textBox_luong.Text = row["luongCung"].ToString();
                textBox_soCMND.Text = row["SoCMND"].ToString();
                textBox_soDienThoai.Text = row["SoDienThoai"].ToString();

                if (row["vaiTro"].ToString() == "False")
                {
                    textBox_vaiTro.Text = "Nhân viên";
                }    
                dateTimePicker_ngaySinh.Text = row["ngaySinh"].ToString();
                if (row["gioiTinh"].ToString() == "True")
                {
                    checkBox_nam.Checked = true;
                    checkBox_nu.Checked = false;
                }
                if (row["gioiTinh"].ToString() == "False")
                {
                    checkBox_nu.Checked = true;
                    checkBox_nam.Checked = false;
                }
            }
        }

        private void button_sua_nhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            nv.hoTen = textBox_hoVaTen.Text.Trim();
            nv.ngaySinh = dateTimePicker_ngaySinh.Value.Date.ToString("yyyy-MM-dd");
            nv.diaChi = textBox_diaChi.Text.Trim();
            nv.soCMND = textBox_soCMND.Text.Trim();
            nv.soDienThoai = textBox_soDienThoai.Text.Trim();
            //nv.matKhau = textBox_passWord.Text.Trim();
            if (checkBox_nam.Checked)
            {
                nv.gioiTinh = "0";
            }
            if (checkBox_nu.Checked)
            {
                nv.gioiTinh = "1";
            }
            if(NhanVien_Controller.Instance.Update_MyInFor(nv) >=1)
            {
                MessageBox.Show("Cập nhật thành công!");
                Load_NhanVien();    
            }
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            UpdatePassWord UpdatePass = new UpdatePassWord(nv);
            UpdatePass.Show();
        }
    }
}
