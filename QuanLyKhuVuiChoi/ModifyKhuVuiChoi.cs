using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyKhuVuiChoi
{
    class ModifyKhuVuiChoi
    {
        public ModifyKhuVuiChoi()
        {

        }
        SqlDataAdapter dataAdapter;//truy xuat data vao bang
        SqlCommand sqlCommand; //truy van
        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public bool insert(QuanLyKhu quanLyKhu)
        {
             // Phương thức để thực hiện các truy vấn không trả về dữ liệu (INSERT, UPDATE, DELETE)
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query ="INSERT INTO KhuVuiChoi VALUES (@MaKhu,@TenKhu,@Vitri,@DienTich,@Giomocua,@Giodongcua,@Giatrem,@Gianguoilon)";
            
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyKhu.Id;
                sqlCommand.Parameters.Add("@TenKhu", SqlDbType.NVarChar).Value = quanLyKhu.Name;
                sqlCommand.Parameters.Add("@Vitri", SqlDbType.NVarChar).Value = quanLyKhu.Vitri;
                sqlCommand.Parameters.Add("@DienTich", SqlDbType.Int).Value = quanLyKhu.Dientich;
                sqlCommand.Parameters.Add("@Giomocua", SqlDbType.Time).Value = quanLyKhu.Giomo;
                sqlCommand.Parameters.Add("@Giodongcua", SqlDbType.Time).Value = quanLyKhu.Giodong;
                sqlCommand.Parameters.Add("@Giatrem", SqlDbType.Int).Value = quanLyKhu.Giatreem;
                sqlCommand.Parameters.Add("@Gianguoilon", SqlDbType.Int).Value = quanLyKhu.Gianguoilon;
                sqlCommand.ExecuteNonQuery();//thuc thi truy van
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi từ SQL Server
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(QuanLyKhu quanLyKhu)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "UPDATE  KhuVuiChoi SET TenKhu = @TenKhu,ViTri = @Vitri,DienTich = @DienTich,Giomocua = @Giomocua,Giodongcua = @Giodongcua,Giatreem = @Giatrem,Gianguoilon = @Gianguoilon WHERE MaKhu = @MaKhu";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyKhu.Id;
                sqlCommand.Parameters.Add("@TenKhu", SqlDbType.NVarChar).Value = quanLyKhu.Name;
                sqlCommand.Parameters.Add("@Vitri", SqlDbType.NVarChar).Value = quanLyKhu.Vitri;
                sqlCommand.Parameters.Add("@DienTich", SqlDbType.Int).Value = quanLyKhu.Dientich;
                sqlCommand.Parameters.Add("@Giomocua", SqlDbType.Time).Value = quanLyKhu.Giomo;
                sqlCommand.Parameters.Add("@Giodongcua", SqlDbType.Time).Value = quanLyKhu.Giodong;
                sqlCommand.Parameters.Add("@Giatrem", SqlDbType.Int).Value = quanLyKhu.Giatreem;
                sqlCommand.Parameters.Add("@Gianguoilon", SqlDbType.Int).Value = quanLyKhu.Gianguoilon;
                sqlCommand.ExecuteNonQuery();//thuc thi truy van
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi từ SQL Server
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool delete(QuanLyKhu quanLyKhu)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "DELETE  KhuVuiChoi WHERE MaKhu = @MaKhu";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyKhu.Id;
               
                sqlCommand.ExecuteNonQuery();//thuc thi truy van
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi từ SQL Server
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
