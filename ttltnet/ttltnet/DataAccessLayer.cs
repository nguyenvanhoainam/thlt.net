using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttltnet
{
    internal class DataAccessLayer
    {
        private Ketnoi kn;

        public DataAccessLayer()
        {
            kn = new Ketnoi();
        }

        // Lấy tất cả nhân viên
        public DataTable GetAllNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            return kn.ReadData(sql);
        }

        // Thêm nhân viên mới
        public void ThemNhanVien(string manv, string hoten, string chucvu, string sdt, string gt, string diachi)
        {
            string sql = "INSERT INTO NhanVien (manv, hoten, chucvu, sdt, gt, diachi) VALUES (@manv, @hoten, @chucvu, @sdt, @gt, @diachi)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@manv", manv),
            new SqlParameter("@hoten", hoten),
            new SqlParameter("@chucvu", chucvu),
            new SqlParameter("@sdt", sdt),
            new SqlParameter("@gt", gt),
            new SqlParameter("@diachi", diachi)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Cập nhật nhân viên
        public void SuaNhanVien(string manv, string hoten, string chucvu, string sdt, string gt, string diachi)
        {
            string sql = "UPDATE NhanVien SET hoten = @hoten, chucvu = @chucvu, sdt = @sdt, gt = @gt, diachi = @diachi WHERE manv = @manv";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@manv", manv),
            new SqlParameter("@hoten", hoten),
            new SqlParameter("@chucvu", chucvu),
            new SqlParameter("@sdt", sdt),
            new SqlParameter("@gt", gt),
            new SqlParameter("@diachi", diachi)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Xóa nhân viên
        public void XoaNhanVien(string manv)
        {
            string sql = "DELETE FROM NhanVien WHERE manv = @manv";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@manv", manv)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Tìm kiếm nhân viên
        public DataTable TimKiemNhanVien(string keyword, string criteria)
        {
            string sql = "";
            if (criteria == "MaNV")
            {
                sql = "SELECT * FROM NhanVien WHERE manv LIKE '%" + keyword + "%'";
            }
            else if (criteria == "TenNV")
            {
                sql = "SELECT * FROM NhanVien WHERE hoten LIKE '%" + keyword + "%'";
            }
            else if (criteria == "SDT")
            {
                sql = "SELECT * FROM NhanVien WHERE sdt LIKE '%" + keyword + "%'";
            }
            return kn.ReadData(sql);
        }







        /*thucdonmonan*/

        // Lấy tất cả món ăn
        public DataTable GetAllMonAn()
        {
            string sql = "SELECT * FROM MonAn";
            return kn.ReadData(sql);
        }

        // Thêm món ăn mới
        public void ThemMonAn(string mamon, string tenmon, string gia, byte[] imageData)
        {
            string sql = "INSERT INTO MonAn (mamon, tenmon, gia, ImageData) VALUES (@mamon, @tenmon, @gia, @ImageData)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@mamon", mamon),
            new SqlParameter("@tenmon", tenmon),
            new SqlParameter("@gia", gia),
            new SqlParameter("@ImageData", imageData ?? (object)DBNull.Value)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Cập nhật món ăn
        public void SuaMonAn(string mamon, string tenmon, string gia, byte[] imageData)
        {
            string sql = "UPDATE MonAn SET tenmon = @tenmon, gia = @gia, ImageData = @ImageData WHERE mamon = @mamon";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@mamon", mamon),
            new SqlParameter("@tenmon", tenmon),
            new SqlParameter("@gia", gia),
            new SqlParameter("@ImageData", imageData ?? (object)DBNull.Value)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Xóa món ăn
        public void XoaMonAn(string mamon)
        {
            string sql = "DELETE FROM MonAn WHERE mamon = @mamon";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@mamon", mamon)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Tìm kiếm món ăn
        public DataTable TimKiemMonAn(string keyword, string criteria)
        {
            string sql = "";
            if (criteria == "MaMon")
            {
                sql = "SELECT * FROM MonAn WHERE mamon LIKE '%" + keyword + "%'";
            }
            else if (criteria == "TenMon")
            {
                sql = "SELECT * FROM MonAn WHERE tenmon LIKE '%" + keyword + "%'";
            }
            else if (criteria == "Gia")
            {
                sql = "SELECT * FROM MonAn WHERE gia LIKE '%" + keyword + "%'";
            }
            return kn.ReadData(sql);
        }
    }





}

