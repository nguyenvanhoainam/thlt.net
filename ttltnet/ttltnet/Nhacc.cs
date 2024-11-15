using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttltnet
{
    internal class Nhacc
    {
        private Ketnoi kn;

        public Nhacc()
        {
            kn = new Ketnoi();
        }



        // Lấy tất cả nhà cung cấp
        public DataTable GetAllNhacc()
        {
            string sql = "Select * from NhaCungCap";
            return kn.ReadData(sql);
        }

        // Thêm nhà cung cấp mới
        public void CreateNhaCungCap(string Manl, string MaNhaCC, string TenNhaCC, string TenNl, string SDT, string DiaChi)
        {
            string sql = "INSERT INTO NhaCungCap (manguyenlieu, manhacc, TenNhaCC,tennguyenlieu, sdt, DiaChi) VALUES (@manl,@ma, @ten,@tennl, @sdt, @diachi)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@manl", Manl),
            new SqlParameter("@ma", MaNhaCC),
            new SqlParameter("@ten", TenNhaCC),
            new SqlParameter("@tennl", TenNl),
            new SqlParameter("@sdt",SDT),
            new SqlParameter("@diachi", DiaChi)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Cập nhật nhà cung cấp
        public void UpdateNhaCungCap(string Manl, string MaNhaCC, string TenNhaCC, string TenNl, string SDT, string DiaChi)
        {
            string sql = "UPDATE NhaCungCap SET manhacc = @ma ,TenNhaCC = @ten,tennguyenlieu = @tennl, sdt = @sdt, DiaChi = @diachi WHERE manguyenlieu = @manl";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
         new SqlParameter("@manl", Manl),
        new SqlParameter("@ma", MaNhaCC),
        new SqlParameter("@ten", TenNhaCC),
        new SqlParameter("@tennl", TenNl),
        new SqlParameter("@sdt", SDT),
        new SqlParameter("@diachi", DiaChi)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Xóa nhà cung cấp
        public void DeleteNhaCungCap(string Manl)
        {
            string sql = "DELETE FROM NhaCungCap WHERE manguyenlieu = @manl";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@manl", Manl)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Tìm kiếm nhà cung cấp
        public DataTable TimKiemNhaCungCapTheoMa(string keyword)
        {
            string sql1 = "SELECT * FROM NhaCungCap WHERE manhacc LIKE '%" + keyword + "%'";  // Tìm kiếm theo mã nhà cung cấp
            return kn.ReadData(sql1);  // Truyền câu lệnh SQL vào ReadData
        }
        public DataTable TimKiemNhaCungCapTen(string keyword)
        {
            string sql1 = "SELECT * FROM NhaCungCap WHERE tennhacc LIKE '%" + keyword + "%'";  // Tìm kiếm theo mã nhà cung cấp
            return kn.ReadData(sql1);  // Truyền câu lệnh SQL vào ReadData
        }
    }
}
