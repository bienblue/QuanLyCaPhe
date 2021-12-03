using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BLL
    {
        DataProvider conn;
        public BLL()
        {
            conn = new DataProvider();
        }

        public DataTable GetAllUsers()
        {
            string sql = "select * from users";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }

        //Show Thông Tin Người Dùng
        public DataTable DanhSachThongTinNguoiDung()
        {
            string sql = "select * from view_Users";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }

        //Show Thông Tin Nhân Viên
        public DataTable DanhSachNhanVien()
        {
            string sql = "select * from view_NhanVien";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }

        //Show Thông Tin Khách Hàng
        public DataTable DanhSachKhachHang()
        {
            string sql = "select * from view_KhachHang";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }

        //Show Danh Sách Đồ Uống
        public DataTable DanhSachDoUong()
        {
            string sql = "select * from view_DoUong";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }

        //Show Danh Sách Bàn
        public DataTable DanhSachBan()
        {
            string sql = "select * from ban";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }

        public DataTable DanhSachLoaiHang()
        {
            string sql = "select * from loaihang";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }
        // Thêm, Sửa, Xóa USER
        public void ThemThongTinNguoiDung(string ID, string Ten,
            string UserName, string PassWord, string phanquyen)
        {
            conn.ExcuteNonQuery("users_insert", CommandType.StoredProcedure,
                new SqlParameter("@ID", ID),
                new SqlParameter("@Ten", Ten),
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@PassWord", PassWord),
                new SqlParameter("@phanquyen", phanquyen));
        }
        public void SuaThongTinNguoiDung(string ID, string Ten,
            string UserName, string PassWord, string phanquyen)
        {
            conn.ExcuteNonQuery("users_update", CommandType.StoredProcedure,
                new SqlParameter("@ID", ID),
                new SqlParameter("@Ten", Ten),
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@PassWord", PassWord),
                new SqlParameter("@phanquyen", phanquyen));
        }
        public void XoaThongTinNguoiDung(string ID)
        {
            conn.ExcuteNonQuery("users_delete", CommandType.StoredProcedure,
                new SqlParameter("@ID", ID));
        }

        //Thêm, Sửa, Xóa Nhân Viên
        public void ThemThongTinNhanVien(string ma_nv, string ten_nv,
            string diachi, string sdt, string chucvu, string gioitinh, DateTime ngay_vao_lam)
        {
            conn.ExcuteNonQuery("nhanvien_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_nv", ma_nv),
                new SqlParameter("@ten_nv", ten_nv),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@chucvu", chucvu),
                new SqlParameter("@gioitinh", gioitinh),
                new SqlParameter("@ngay_vao_lam", ngay_vao_lam.Year + "-" + ngay_vao_lam.Month + "-" + ngay_vao_lam.Day));
        }
        public void SuaThongTinNhanVien(string ma_nv, string ten_nv,
            string diachi, string sdt, string chucvu, string gioitinh, DateTime ngay_vao_lam)
        {
            conn.ExcuteNonQuery("nhanvien_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_nv", ma_nv),
                new SqlParameter("@ten_nv", ten_nv),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@chucvu", chucvu),
                new SqlParameter("@gioitinh", gioitinh),
                new SqlParameter("@ngay_vao_lam", ngay_vao_lam.Year + "-" + ngay_vao_lam.Month + "-" + ngay_vao_lam.Day));
        }
        public void XoaThongTinNhanVien(string ma_nv)
        {
            conn.ExcuteNonQuery("nhanvien_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_nv", ma_nv));
        }

        //Thêm, Sửa, Xóa Khách Hàng
        public void ThemThongTinKhachHang(string ma_kh, string ten_kh,
            string diachi, string sdt)
        {
            conn.ExcuteNonQuery("khachhang_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_kh", ma_kh),
                new SqlParameter("@ten_kh", ten_kh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt));
        }
        public void SuaThongTinKhachHang(string ma_kh, string ten_kh,
            string diachi, string sdt)
        {
            conn.ExcuteNonQuery("khachhang_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_kh", ma_kh),
                new SqlParameter("@ten_kh", ten_kh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt));
        }
        public void XoaThongTinKhachHang(string ma_kh)
        {
            conn.ExcuteNonQuery("khachhang_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_kh", ma_kh));
        }

        //Thêm, Sửa, Xóa Danh Sách Đồ Uống
        public void ThemDoUong(string ma_hh, string ten_hh,
            int soluong, int gia_sp, string ma_lh)
        {
            conn.ExcuteNonQuery("douong_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_hh", ma_hh),
                new SqlParameter("@ten_hh", ten_hh),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@gia_sp", gia_sp),
                new SqlParameter("@ma_lh", ma_lh));
        }
        public void SuaDoUong(string ma_hh, string ten_hh,
            int soluong, int gia_sp, string ma_lh)
        {
            conn.ExcuteNonQuery("douong_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_hh", ma_hh),
                new SqlParameter("@ten_hh", ten_hh),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@gia_sp", gia_sp),
                new SqlParameter("@ma_lh", ma_lh));
        }
        public void XoaDoUong(string ma_hh)
        {
            conn.ExcuteNonQuery("douong_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_hh", ma_hh));
        }
        public DataTable TimDoUongTheoTen(string ten_hh)
        {
            string sql = "select * from hanghoa where ten_hh like N'%" + ten_hh + "%'";
            return conn.GetDataToDataTable(sql, CommandType.Text);
        }

        //Thêm, Sửa, Xóa Danh Sách Bàn
        public void ThemBan(string ma_ban, string ten_ban,
            string thuoc_tinh)
        {
            conn.ExcuteNonQuery("ban_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", ma_ban),
                new SqlParameter("@ten_ban", ten_ban),
                new SqlParameter("@thuoc_tinh", thuoc_tinh));
        }
        public void SuaBan(string ma_ban, string ten_ban,
            string thuoc_tinh)
        {
            conn.ExcuteNonQuery("ban_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", ma_ban),
                new SqlParameter("@ten_ban", ten_ban),
                new SqlParameter("@thuoc_tinh", thuoc_tinh));
        }
        public void XoaBan(string ma_ban)
        {
            conn.ExcuteNonQuery("ban_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", ma_ban));
        }
    }
}
