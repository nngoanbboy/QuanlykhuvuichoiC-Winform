using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhuVuiChoi
{
    class ModifyDichVu
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand; //truy van
        public ModifyDichVu()
        {
        }

        public DataTable getAllDichVu()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM DichVu";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;

        }
        public bool insert(QuanLyDichVu quanLyDichVu)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "INSERT INTO DichVu VALUES (@MaDichVu,@TenDichVu,@GiaDichVu,@MaKhu)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaDichVu", SqlDbType.NVarChar).Value = quanLyDichVu.Id;
                sqlCommand.Parameters.Add("@TenDichVu", SqlDbType.NVarChar).Value = quanLyDichVu.Name;
                sqlCommand.Parameters.Add("@GiaDichVu", SqlDbType.NVarChar).Value = quanLyDichVu.Price;
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyDichVu.IdKhu;

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

        public bool update(QuanLyDichVu quanLyDichVu)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "UPDATE  DichVu SET TenDichVu = @TenDichVu,GiaDichVu = @GiaDichVu,MaKhu = @MaKhu WHERE MaDichVu = @MaDichVu";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaDichVu", SqlDbType.NVarChar).Value = quanLyDichVu.Id;
                sqlCommand.Parameters.Add("@TenDichVu", SqlDbType.NVarChar).Value = quanLyDichVu.Name;
                sqlCommand.Parameters.Add("@GiaDichVu", SqlDbType.NVarChar).Value = quanLyDichVu.Price;
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyDichVu.IdKhu;

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

        public bool delete(QuanLyDichVu quanLyDichVu)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "DELETE  DichVu WHERE MaDichVu = @MaDichVu";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaDichVu", SqlDbType.NVarChar).Value = quanLyDichVu.Id;

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
        public DataTable searchDichVuByName(string name)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM DichVu WHERE TenDichVu LIKE @TenDichVu";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@TenDichVu", "%" + name + "%");
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable searchDichVuByID(string id)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM DichVu WHERE MaDichVu LIKE @MaDichVu";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@MaDichVu", "%" + id + "%");
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
