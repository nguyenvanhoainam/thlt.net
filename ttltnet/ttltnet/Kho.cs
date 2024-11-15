using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttltnet
{
    internal class Kho
    {
        private Ketnoi kn;
        public Kho()
        {
            kn = new Ketnoi();
        }

        public DataTable GetAllKho()
        {
            string sql = "Select * from Kho";
            return kn.ReadData(sql);
        }
        public DataTable TimKiemkho(string keyword)
        {
            string sql1 = "SELECT * FROM Kho WHERE manguyenlieu LIKE '%" + keyword + "%'";  // Tìm kiếm theo mã nhà cung cấp
            return kn.ReadData(sql1);  // Truyền câu lệnh SQL vào ReadData
        }
        public DataTable Tinhsoluong()
        {
            // Câu truy vấn để tính số lượng còn lại
            string selectQuery = @"
   SELECT 
    k.manguyenlieu,                                 -- Mã nguyên liệu (dùng để kết nối giữa các bảng)
    k.tennguyenlieu,                                -- Tên nguyên liệu (chỉ để tham khảo)
    COALESCE(hdn.total_nhap, 0) - COALESCE(hdb.total_ban, 0) AS soluong -- Tổng lượng còn lại
FROM 
    Kho k                                           -- Bảng Kho làm bảng chính
LEFT JOIN 
    (SELECT manguyenlieu, SUM(soluong) AS total_nhap 
     FROM HoaDonNhap 
     GROUP BY manguyenlieu) AS hdn                  -- Tính tổng số lượng nhập cho từng mã nguyên liệu
ON 
    k.manguyenlieu = hdn.manguyenlieu
LEFT JOIN 
    (SELECT manguyenlieu, SUM(soluongnguyenlieu) AS total_ban 
     FROM HoaDonBan 
     GROUP BY manguyenlieu) AS hdb                  -- Tính tổng số lượng nguyên liệu đã sử dụng cho từng mã
ON 
    k.manguyenlieu = hdb.manguyenlieu;
    ";

            // Thực thi câu lệnh truy vấn và trả về DataTable
            return kn.ReadData(selectQuery);

        }
        public DataTable updatekho()
        {
            string updateQuery = @"
   UPDATE Kho
   SET soluong = COALESCE(hdn.total_nhap, 0) - COALESCE(hdb.total_ban, 0)
   FROM Kho k
   LEFT JOIN 
       (SELECT manguyenlieu, SUM(soluong) AS total_nhap 
        FROM HoaDonNhap 
        GROUP BY manguyenlieu) AS hdn 
   ON k.manguyenlieu = hdn.manguyenlieu
   LEFT JOIN 
       (SELECT manguyenlieu, SUM(soluongnguyenlieu) AS total_ban 
        FROM HoaDonBan 
        GROUP BY manguyenlieu) AS hdb 
   ON k.manguyenlieu = hdb.manguyenlieu;
";
            return kn.ReadData(updateQuery);
        }
    }
}
