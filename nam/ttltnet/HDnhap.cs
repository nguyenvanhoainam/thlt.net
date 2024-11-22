using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ttltnet
{
     internal class HDnhap
    {
        private Ketnoi kn;

        public HDnhap()
        {
            kn = new Ketnoi();
        }



        // Lấy tất cả nhà cung cấp
        public DataTable GetAll()
        {
            string sql = "Select * from HoaDonNhap";
            return kn.ReadData(sql);
        }
        public DataTable GetNhaCungCap()
        {
            string sql = "SELECT DISTINCT manhacc FROM NhaCungCap;";
            return kn.ReadData(sql);
        }

        // Lấy danh sách mã nhân viên
        public DataTable GetNhanVien()
        {
            string sql = "SELECT manv FROM NhanVien";
            return kn.ReadData(sql);
        }
        public DataTable GetMaHD()
        {
            string sql = "SELECT mahdnhap FROM HoaDonNhap";
            return kn.ReadData(sql);
        }
        public DataTable GetNguyenLieu()
        {
            string sql = "SELECT manguyenlieu FROM Kho";
            return kn.ReadData(sql);
        }
        // Thêm nhà cung cấp mới
        public void Create(string mahdnhap, string manhacc, DateTime ngay, string manguyenlieu, string gia, string soluong, string manv)
        {
            string sql = "INSERT INTO HoaDonNhap (mahdnhap,manhacc,ngay,manguyenlieu,gia,soluong,manv) VALUES (@mahdnhap,@manhacc,@ngay,@manguyenlieu,@gia,@soluong,@manv)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@mahdnhap", mahdnhap),
            new SqlParameter("@manhacc", manhacc),
            new SqlParameter("@ngay",ngay),
            new SqlParameter("@manguyenlieu", manguyenlieu),
            new SqlParameter("@gia", gia),
            new SqlParameter("@soluong",soluong),
            new SqlParameter("@manv", manv)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Cập nhật nhà cung cấp
        public void Update(string mahdnhap, string manhacc, DateTime ngay, string manguyenlieu, string gia, string soluong, string manv)
        {
            string sql = "UPDATE HoaDonNhap SET manhacc = @manhacc, ngay = @ngay, manguyenlieu = @manguyenlieu,gia = @gia, soluong = @soluong, manv = @manv WHERE mahdnhap = @mahdnhap";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@mahdnhap", mahdnhap),
            new SqlParameter("@manhacc", manhacc),
            new SqlParameter("@ngay",ngay),
            new SqlParameter("@manguyenlieu", manguyenlieu),
            new SqlParameter("@gia", gia),
            new SqlParameter("@soluong",soluong),
            new SqlParameter("@manv", manv)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Xóa nhà cung cấp
        public void Delete(string mahdnhap)
        {
            string sql = "DELETE FROM HoaDonNhap WHERE mahdnhap = @mahdnhap";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@mahdnhap", mahdnhap)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Tìm kiếm nhà cung cấp
        public DataTable TimKiemTheoMa(string keyword)
        {
            string sql1 = "SELECT * FROM HoaDonNhap WHERE mahdnhap LIKE '%" + keyword + "%'";  // Tìm kiếm theo mã nhà cung cấp
            return kn.ReadData(sql1);  // Truyền câu lệnh SQL vào ReadData
        }
        public DataTable TimKiemNgay(string keyword)
        {
            string sql1 = "SELECT * FROM HoaDonNhap WHERE tennhacc LIKE '%" + keyword + "%'";  // Tìm kiếm theo mã nhà cung cấp
            return kn.ReadData(sql1);  // Truyền câu lệnh SQL vào ReadData
        }
    }
}
