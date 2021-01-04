using KhuCanHo.Controller;
using KhuCanHo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KhuCanHo.Views
{
    public partial class UpdatePassWord: Form
    {
        DataTable dt = new DataTable();
        NhanVienDAL nv = new NhanVienDAL();
        public UpdatePassWord(NhanVienDAL nv)
        {
            this.nv.maNhanVien = nv.maNhanVien;
            InitializeComponent();
            Load_PassWord();

        }

        private void ChangePassUpdate_Click(object sender, EventArgs e)
        {
            if (newPass.Text == reNewPass.Text)
            {
                nv.matKhau = reNewPass.Text.Trim();
                if (NhanVien_Controller.Instance.Update_MyPass(nv) >= 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu không đúng!");
            }

        }

        public void Load_PassWord()
        {
            dt = NhanVien_Controller.Instance.Load_MyInFor(nv);
            DataRow[] dr = dt.Select("maNhanVien = '" + nv.maNhanVien + "'");

            foreach (DataRow row in dr)
            {
                oldPass.Text = row["maKhau"].ToString().Trim();
            }
        }

        private void check_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (!check_Pass.Checked)
            {
                oldPass.UseSystemPasswordChar = true;
                newPass.UseSystemPasswordChar = true;
                reNewPass.UseSystemPasswordChar = true;
            }
            else
            {
                oldPass.UseSystemPasswordChar = false;
                newPass.UseSystemPasswordChar = false;
                reNewPass.UseSystemPasswordChar = false;
            }
        }

        private void ChangePassCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
