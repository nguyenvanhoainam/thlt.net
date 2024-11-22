using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banhang
{
    internal class HDBH
    {
        public KetNoi kn;
        public HDBH()
        {
            kn = new KetNoi();
        }
        // Lấy tất cả ma hd
        public DataTable GetAll()
        {
            string sql = "Select * from HoaDonBan";
            return kn.ReadData(sql);
        }
        public DataTable Getmahd()
        {
            string sql = "SELECT mahdban FROM HoaDonBan";
            return kn.ReadData(sql);
        }
        public DataTable Getmanguyenlieu()
        {
            string sql = "SELECT manguyenlieu FROM Kho";
            return kn.ReadData(sql);
        }


        public DataTable Getmamon()
        {
            string sql = "SELECT mamon FROM MonAn";
            return kn.ReadData(sql);
        }

        // Lấy danh sách mã nhân viên
        public DataTable GetNhanVien()
        {
            string sql = "SELECT manv FROM NhanVien";
            return kn.ReadData(sql);
        }

        // Thêm nhà cung cấp mới
        public void Create(string mahd, string hotenkh, string sdt, string diachi, DateTime ngay, string mamon, string soluong, string manv,string mnl, string slnl)
        {
            string sql = "INSERT INTO HoaDonBan (mahdban,hotenkhach,sdt,diachi,ngay,mamon,soluong,manv,manguyenlieu,soluongnguyenlieu) VALUES (@mahdban,@hotenkhach,@sdt,@diachi,@ngay,@mamon,@soluong,@manv,@manguyenlieu,@soluongnguyenlieu)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@mahdban", mahd),
                new SqlParameter("@hotenkhach", hotenkh),
                new SqlParameter("@sdt",sdt),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@ngay", ngay),
                new SqlParameter("@mamon",mamon),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@manv",manv),
                new SqlParameter("@manguyenlieu", mnl),
                new SqlParameter("@soluongnguyenlieu",slnl)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Cập nhật nhà cung cấp
        public void Update(string mahd, string hotenkh, string sdt, string diachi, DateTime ngay, string mamon, string soluong, string manv, string mnl, string slnl)
        {
            string sql = "UPDATE HoaDonBan SET hotenkhach=@hotenkhach,sdt=@sdt,diachi=@diachi,ngay=@ngay,mamon=@mamon,soluong=@soluong,manv=@manv,manguyenlieu=@manguyenlieu,soluongnguyenlieu=@soluongnguyenlieu WHERE mahdban = @mahdban";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@mahdban", mahd),
                new SqlParameter("@hotenkhach", hotenkh),
                new SqlParameter("@sdt",sdt),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@ngay", ngay),
                new SqlParameter("@mamon",mamon),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@manv",manv),
                 new SqlParameter("@manguyenlieu", mnl),
                new SqlParameter("@soluongnguyenlieu",slnl)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        public void Delete(string mahdban)
        {
            string sql = "DELETE FROM HoaDonBan WHERE mahdban = @mahdban";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@mahdban", mahdban)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        // Tìm kiếm nhà cung cấp
        public DataTable TimKiemTheoMa(string keyword)
        {
            string sql1 = "SELECT * FROM HoaDonBan WHERE mahdban LIKE '%" + keyword + "%'";  // Tìm kiếm theo mã nhà cung cấp
            return kn.ReadData(sql1);  // Truyền câu lệnh SQL vào ReadData
        }
        public DataTable TimKiemTen(string keyword)
        {
            string sql1 = "SELECT * FROM HoaDonBan WHERE hotenkhach LIKE '%" + keyword + "%'";  // Tìm kiếm theo mã nhà cung cấp
            return kn.ReadData(sql1);  // Truyền câu lệnh SQL vào ReadData
        }
    }
}
