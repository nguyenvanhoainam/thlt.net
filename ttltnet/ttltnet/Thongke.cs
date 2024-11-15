using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttltnet
{
    internal class Thongke
    {
        private Ketnoi kn;
        public Thongke()
        {
            kn = new Ketnoi();
        }
        public DataTable GetMaHD()
        {
            string sql = "SELECT mahdnhap FROM HoaDonNhap";
            return kn.ReadData(sql);
        }
        public DataTable DoanhThu(DateTime startDate, DateTime endDate)
        {
            // Câu lệnh SQL
            string sql = @"
        -- Xóa bản ghi trùng trước khi thêm mới
        DELETE FROM DoanhThu WHERE maThang BETWEEN FORMAT(@StartDate, 'yyyy-MM') AND FORMAT(@EndDate, 'yyyy-MM');

        -- Sử dụng CTE để tính toán doanh thu và chi phí nhập
        WITH DoanhThuBanThang AS (
            SELECT
                FORMAT(ngay, 'yyyy-MM') AS maThang,  
                SUM(tongtien) AS doanhThuBan         
            FROM HoaDonBan
            WHERE ngay BETWEEN @StartDate AND @EndDate
            GROUP BY FORMAT(ngay, 'yyyy-MM')
        ),
        ChiPhiNhapThang AS (
            SELECT
                FORMAT(ngay, 'yyyy-MM') AS maThang,  
                SUM(tongtien) AS chiPhiNhap         
            FROM HoaDonNhap
            WHERE ngay BETWEEN @StartDate AND @EndDate
            GROUP BY FORMAT(ngay, 'yyyy-MM')
        )
        
        -- Chèn dữ liệu vào bảng DoanhThu
        INSERT INTO DoanhThu (maThang, doanhThuBan, chiPhiNhap, loiNhuan)
        SELECT DTB.maThang, 
               DTB.doanhThuBan, 
               CPN.chiPhiNhap, 
               (DTB.doanhThuBan - CPN.chiPhiNhap) AS loiNhuan
        FROM DoanhThuBanThang DTB
        JOIN ChiPhiNhapThang CPN ON DTB.maThang = CPN.maThang
        ORDER BY DTB.maThang;

        -- Truy vấn dữ liệu để hiển thị
        SELECT maThang, doanhThuBan, chiPhiNhap, loiNhuan FROM DoanhThu
        WHERE maThang BETWEEN FORMAT(@StartDate, 'yyyy-MM') AND FORMAT(@EndDate, 'yyyy-MM');
    ";

            // Tạo mảng tham số
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@StartDate", startDate),
        new SqlParameter("@EndDate", endDate)
            };

            // Đọc dữ liệu và trả về DataTable chứa kết quả từ bảng DoanhThu
            return kn.Read(sql, sqlParameters);
        }

    }
}
