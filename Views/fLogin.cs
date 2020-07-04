using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhuCanHo.Controller;
using KhuCanHo.Database;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;
using KhuCanHo.Views;
using KhuCanHo.Model;

namespace KhuCanHo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            /*txtPassWord.Text = "trungnm";
            txtUserName.Text = "trungnm";*/
        }


        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
                  
        }

        private void dangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            NhanVienDAL nv = new NhanVienDAL();
            nv.maNhanVien = userName;
            if (Admin_Controller.Instance.Check_Login(userName,passWord)==1)
            {
                fAdmin admin_space = new fAdmin();
                this.Hide();
                admin_space.ShowDialog();
                this.Show();
            }
            else if (Admin_Controller.Instance.Check_Login(userName, passWord) == 0)
            {
                Home home = new Home(nv);
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau");
            }
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
