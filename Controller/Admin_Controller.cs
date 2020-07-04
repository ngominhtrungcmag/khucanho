using KhuCanHo.Database;
using KhuCanHo.Model;
using Microsoft.SqlServer.Management.Assessment.Checks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhuCanHo.Controller
{
    class Admin_Controller
    {
        private static Admin_Controller instance;

        public static Admin_Controller Instance
        {
             get
            {
                if (instance == null) instance = new Admin_Controller();
                return instance;
            }
            private set { instance = value;  }
        }

        private Admin_Controller() { }

        public int Check_Login(string userName, string passWord)
        {
            int check = -1;
            string query = "SELECT count(*) FROM dbo.NHANVIEN WHERE maNhanVien = N'"+ userName + " 'AND maKhau = N'" + passWord+ "' AND vaiTro=1";

            if (DataProvider.Instance.ExecuteScalar(query)==1)
            {
                check = 1;
            }
            query = "SELECT count(*) FROM dbo.NHANVIEN WHERE maNhanVien = N'" + userName + " 'AND maKhau = N'" + passWord + "' AND vaiTro=0";
            if (DataProvider.Instance.ExecuteScalar(query) == 1)
            {
                check = 0;
            }

            return check;
        }

        public DataTable Load_Acount()
        {
            string query = "SELECT * FROM DBO.NHANVIEN";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public int Update_NhanVien(NhanVienDAL nv)
        {
            //Check bieu thuc chinh quy
            string query = "UPDATE NhanVien SET hoTen=N'" + nv.hoTen + "', ngaySinh='" + nv.ngaySinh + "', gioiTinh=" + nv.gioiTinh + ",soDienThoai='" + nv.soDienThoai + "', soCMND='" + nv.soCMND + "', vaiTro ="+nv.vaiTro+", luongCung = '"+nv.luongCung+"' where maNhanVien='" + nv.maNhanVien + "'";
            MessageBox.Show(query);
            return DataProvider.Instance.ExcuteNonQuery(query);
            //Return Thong bao loi hoac thanh cong
        }
        public int Add_NhanVien(NhanVienDAL nv)
        {
            string query = "insert into NHANVIEN values('" + nv.maNhanVien + "', '"+nv.matKhau+"','" + nv.hoTen + "', '" + nv.ngaySinh + "', " + nv.gioiTinh + ",'" + nv.soDienThoai + "', '"+nv.diaChi+"', '" + nv.soCMND +"','"+nv.luongCung+"',"+nv.vaiTro+");";
            System.Windows.Forms.MessageBox.Show(query);
            return DataProvider.Instance.ExcuteNonQuery(query);
            
        }

        public int Del_NhanVien(NhanVienDAL nv)
        {
            string query = "DELETE NHANVIEN WHERE MANHANVIEN ='" + nv.maNhanVien + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

    }
}
