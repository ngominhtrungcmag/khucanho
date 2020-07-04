using KhuCanHo.Controller;
using KhuCanHo.Model;
using Microsoft.SqlServer.Management.SqlParser.MetadataProvider;
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
    public partial class AddCanHo : Form
    {
        bool tmp_status = false;
        public AddCanHo()
        {
            InitializeComponent();
        }

        private void AddCanHo_Load(object sender, EventArgs e)
        {

        }

        private void button_thoat_AddCanHo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button_them_AddCanHo_MouseClick(object sender, MouseEventArgs e)
        {
            Regex rex_maCanHo = new Regex(@"^\d{6}$");
            if (!rex_maCanHo.IsMatch(maCanHo_themCanHo.Text))
                MessageBox.Show("Mã căn hộ gồm 6 kí tự.");

            Regex rex_dienTich = new Regex(@"^\d{2,3}$");
            if (!rex_dienTich.IsMatch(dienTich_themCanHo.Text))
                MessageBox.Show("Diện tích.?");

            Regex rex_giaBan = new Regex(@"^\d{4,9}$");
            if (!rex_giaBan.IsMatch(gia_themCanHo.Text))
                MessageBox.Show("Giá bán.?");

            Regex rex_SoPhong = new Regex(@"^\d{1,2}$");
            if (!rex_SoPhong.IsMatch(soPhong_themCanHo.Text))
                MessageBox.Show("Số phòng.?");

            Regex rex_maKhu = new Regex(@"^\D{3}$");
            if (!rex_maKhu.IsMatch(maKhu_themCanHo.Text))
                MessageBox.Show("Mã khu.?");

            if (checkBox_ban.Checked == false && checkBox_chuaBan.Checked == false)
                MessageBox.Show("Check trạng thái.");
            else tmp_status = true;

            if (rex_maCanHo.IsMatch(maCanHo_themCanHo.Text) && rex_dienTich.IsMatch(dienTich_themCanHo.Text) && rex_giaBan.IsMatch(gia_themCanHo.Text) && rex_SoPhong.IsMatch(soPhong_themCanHo.Text) && rex_maKhu.IsMatch(maKhu_themCanHo.Text) && tmp_status)
            {
                CanHoDAL caho = new CanHoDAL();
                int daBan = 1, chuaBan = 0;
                caho.maCanHo = maCanHo_themCanHo.Text;
                caho.dienTich = dienTich_themCanHo.Text;
                caho.soPhong = int.Parse(dienTich_themCanHo.Text);
                if (checkBox_ban.Checked)
                    caho.trangThai = Convert.ToByte(daBan);
                if (checkBox_chuaBan.Checked)
                    caho.trangThai = Convert.ToByte(chuaBan);

                caho.maKhu = maKhu_themCanHo.Text;
                if (NhanVien_Controller.Instance.Add_CanHo(caho) > 0)
                {
                    MessageBox.Show("Thêm Thành công..!");
                    var myParent = (CanHo)this.Owner;
                    myParent.RefreshForm();
                    this.Close();
                }
            }

            
        }
    }
}
