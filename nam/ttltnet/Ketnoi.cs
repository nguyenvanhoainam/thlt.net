using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttltnet
{
    class Ketnoi
    {
        public SqlConnection conn;
        public void openConnection()
        {
            string ckn = "Server = DESKTOP-7Q3FR2I\\SQLEXPRESS;Database=qlcuahangdoannhanh;Integrated Security = True";
            conn = new SqlConnection(ckn);
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }

        //public DataTable ReadData(string table)
        //{
        //    DataTable dt = new DataTable();
        //    string sql = "select * from NhaCungCap";

        //    try
        //    {
        //        openConnection();
        //        using (SqlCommand cmd = new SqlCommand(sql, conn))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                dt.Load(reader);
        //            }
        //        }
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        dt.Load(reader);
        //        reader.Close();
        //        cmd.Dispose();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        closeConnection();
        //    }
        //    return dt;

        //}
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
        public DataTable Read(string sql, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                openConnection();  // Mở kết nối đến cơ sở dữ liệu

                using (SqlCommand cmd = new SqlCommand(sql, conn))  // Tạo đối tượng SqlCommand với câu lệnh SQL
                {
                    // Nếu có các tham số, thêm chúng vào SqlCommand
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);  // Thêm tất cả các tham số vào câu lệnh SQL
                    }

                    // Thực thi câu lệnh SQL và lấy dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);  // Đọc dữ liệu từ SqlDataReader và nạp vào DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi câu lệnh SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();  // Đảm bảo đóng kết nối sau khi thực thi xong
            }

            return dt;  // Trả về DataTable chứa kết quả
        }
        public SqlConnection getConnection()
        {
            return conn;
        }

    }
}
