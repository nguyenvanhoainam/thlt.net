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
    internal class KetNoi
    {
        
            public SqlConnection conn;
            public void openConnection()
            {
                conn = new SqlConnection("Data Source=MSI\\CONGTHANG;Initial Catalog=qlch;Integrated Security=True");
                conn.Open();
            }
        public void closeConnection()
        {
            conn.Close();
        }

        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                openConnection();  // Mở kết nối đến cơ sở dữ liệu
                SqlCommand cmd = new SqlCommand(sql, conn);  // Chuẩn bị câu lệnh SQL
                SqlDataReader reader = cmd.ExecuteReader();  // Thực thi câu lệnh và nhận kết quả
                dt.Load(reader);  // Nạp dữ liệu từ SqlDataReader vào DataTable
                reader.Close();  // Đóng SqlDataReader
                cmd.Dispose();  // Giải phóng tài nguyên
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // Nếu có lỗi, hiển thị thông báo
            }
            finally
            {
                closeConnection();  // Đảm bảo đóng kết nối
            }

            return dt;  // Trả về kết quả dưới dạng DataTable
        }
        public void CreateUpdateDelete(string sql, SqlParameter[] sqlp = null)
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))

                {
                    if (sqlp != null) cmd.Parameters.AddRange(sqlp);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

        }


    }
}
