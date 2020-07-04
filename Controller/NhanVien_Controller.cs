using KhuCanHo.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhuCanHo.Model;
using System.Windows.Forms;

namespace KhuCanHo.Controller
{
    class NhanVien_Controller
    {
        private static NhanVien_Controller instance;

        public static NhanVien_Controller Instance
        {
            get
            {
                if (instance == null) instance = new NhanVien_Controller();
                return instance;
            }
            private set { instance = value; }
        }

        private NhanVien_Controller() { }

        public DataTable Load_MyInFor(NhanVienDAL nv)
        {
            String query = "SELECT * FROM Nhanvien WHERE maNhanVien = '"+nv.maNhanVien+"'";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public int Update_MyInFor(NhanVienDAL nv)
        {
            string query = "UPDATE nhanvien SET hoTen=N'" + nv.hoTen + "', diaChi=N'" + nv.diaChi + "', soCMND='" + nv.soCMND + "', soDienThoai='" + nv.soDienThoai + "', maKhau= '"+nv.matKhau+"' where maNhanVien='" + nv.maNhanVien + "'";
            MessageBox.Show(query);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        // Controller for Khu Can Ho
        #region
        public DataTable Load_KhuCanHo()
        {
            string query = "SELECT * FROM DBO.KHUCANHO";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public int Update_KhuCanHo(KhuCanHoDAL kch)
        {
        
            //Check bieu thuc chinh quy
            string query = "UPDATE KHUCANHO SET tenKhu='"+kch.tenKhu+"', soTang="+kch.soTang+", soCanHo="+kch.soCan+",diaChi=N'"+kch.diaChi+"' where maKhu='"+kch.maKhu+"'";
            return DataProvider.Instance.ExcuteNonQuery(query);
            //Return Thong bao loi hoac thanh cong
        }
        public int Add_KhuCanHo(KhuCanHoDAL kch)
        {
            string query = "insert into KHUCANHO values('"+kch.maKhu+"', '"+kch.tenKhu+"', "+kch.soCan+", "+kch.soTang+", N'"+kch.diaChi+"');";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        
        public int Del_KhuCanHo(KhuCanHoDAL kch)
        {
            string query = "DELETE KHUCANHO WHERE maKhu='" + kch.maKhu + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public DataTable Search_KhuCanHo(String searchstr, String field)
        {
            String query = "SELECT * FROM KHUCANHO WHERE "+field+" LIKE N'%"+searchstr+"%'";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        #endregion
        //End Controller for Khu Can Ho

        //Controller for Khach Hang
        #region
        public DataTable Load_KhachHang()
        {
            string query = "SELECT * FROM DBO.KHACHHANG";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public int Update_KhachHang(KhachHangDAL kh)
        {
            //Check bieu thuc chinh quy
/*            string setngay = "set dateformat dmy;";
            DataProvider.Instance.ExcuteNonQuery(setngay);
*/
            string query = "UPDATE KHACHHANG SET tenKhachHang=N'" + kh.tenKhachHang + "', ngaySinh='" + kh.ngaySinh + "', gioiTinh=" + kh.gioiTinh + ", soDienThoai='" + kh.soDienThoai + "', soCMND='" + kh.soCMND + "' where maKhachHang='" + kh.maKhachHang + "'";
            MessageBox.Show(query);
            return DataProvider.Instance.ExcuteNonQuery(query);
            //Return Thong bao loi hoac thanh cong
        }
        public int Add_KhachHang(KhachHangDAL kh)
        {
            string query = "insert into KHACHHANG values('" + kh.maKhachHang + "', '" + kh.tenKhachHang + "', '" + kh.ngaySinh + "', " + kh.gioiTinh + ", '" + kh.soDienThoai + "','"+kh.soCMND+"', '"+kh.queQuan+"');";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public int Del_KhachHang(KhachHangDAL kh)
        {
            string query = "DELETE KHACHHANG WHERE MAKHACHHANG ='" + kh.maKhachHang + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public DataTable Search_KhachHang(String searchstr, String field)
        {
            String query = "SELECT * FROM KHACHHANG WHERE "+field+" LIKE N'%" + searchstr + "%'";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        #endregion
        //End Controller for Khac Hang
        
        public DataTable Load_GiaoDich()
        {
            string query = "SELECT * FROM HOPDONG";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public int Update_GiaoDich(HopDongDAL hopdongDAL)
        {
            string query = "UPDATE HOPDONG SET maKhachHang='" + hopdongDAL.maKhachHang + "', maNhanVien='" + hopdongDAL.maNhanVien + "', maCanHo='" + hopdongDAL.maCanHo + "', ngayGiaoDich='" + hopdongDAL.ngayGiaoDich + "' where maHopDong='" + hopdongDAL.maHopDong + "';";
            MessageBox.Show(query);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public int Add_GiaoDich(HopDongDAL hopdongDAL)
        {
            string query = "insert into HOPDONG values('" + hopdongDAL.maHopDong + "', '" + hopdongDAL.maKhachHang + "', '" + hopdongDAL.maNhanVien + "', '" + hopdongDAL.maCanHo + "','" + hopdongDAL.ngayGiaoDich + "');";
            MessageBox.Show(query);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public int Del_GiaoDich(HopDongDAL hopdongDAL)
        {
            string query = "DELETE HOPDONG WHERE maHopDong='" + hopdongDAL.maHopDong + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public DataTable Search_GiaoDich(String searchstr, String field)
        {
            String query = "SELECT * FROM HOPDONG WHERE "+field+" LIKE '%" + searchstr + "%'";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable Load_CanHo()
        {
            string query = "SELECT * FROM DBO.CANHO";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public int Update_CanHo(CanHoDAL canHoDAL)
        {
            string query = "UPDATE CANHO SET dienTich=" + canHoDAL.dienTich + ", giaBan=" + canHoDAL.giaBan + ", trangThai='" + canHoDAL.trangThai + "', soPhong=" + canHoDAL.soPhong + ", maKhu='" + canHoDAL.maKhu + "' where maCanHo='" + canHoDAL.maCanHo + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public int Add_CanHo(CanHoDAL canHoDAL)
        {
            string query = "insert into CANHO values('" + canHoDAL.maCanHo + "', '" + canHoDAL.dienTich + "', " + canHoDAL.giaBan + ", " + canHoDAL.trangThai + ", " + canHoDAL.soPhong + ",'" + canHoDAL.maKhu + "'); ";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public int Del_CanHo(CanHoDAL canHoDAL)
        {
            string query = "DELETE CANHO WHERE maCanHo='" + canHoDAL.maCanHo + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public DataTable Search_CanHo(String searchstr, String field)
        {
            String query = "SELECT * FROM CANHO WHERE "+field+" LIKE N'%" + searchstr + "%'";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable Load_DienNuocKhac()
        {
            string query = "SELECT * FROM DBO.DIENNUOC";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public int Update_DienNuoc(DienNuocDAL dienNuocDAL)
        {
            string query = "UPDATE DIENNUOC SET trangThai=" + dienNuocDAL.trangThai + ", eChiSoCu=" + dienNuocDAL.eChiSoCu + ", eChiSoMoi='" + dienNuocDAL.eChiSoMoi + "', wChiSoCu=" + dienNuocDAL.wChiSoCu + ", wChiSoMoi=" + dienNuocDAL.wChiSoMoi + " where maCanHo='" + dienNuocDAL.maCanHo + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public int Add_DienNuoc(DienNuocDAL dienNuocDAL)
        {
            string query = "insert into DIENNUOC values('" + dienNuocDAL.maCanHo + "', " + dienNuocDAL.eChiSoCu + ", " + dienNuocDAL.eChiSoMoi + ", " + dienNuocDAL.wChiSoCu + "," + dienNuocDAL.wChiSoMoi + "); ";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public int Del_DienNuoc(DienNuocDAL dienNuocDAL)
        {
            string query = "DELETE DIENNUOC WHERE maCanHo='" + dienNuocDAL.maCanHo + "'";
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public DataTable Search_DienNuoc(String searchstr, String field)
        {
            String query = "SELECT * FROM DIENNUOC WHERE "+field+" LIKE '%" + searchstr + "%'";
            return DataProvider.Instance.ExcuteQuery(query);
        }


    }
}
