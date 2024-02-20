using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhuVuiChoi
{
    class ModifyTroChoi
    {
        SqlDataAdapter dataAdapter;//truy xuat data vao bang
        SqlCommand sqlCommand; //truy van
        public ModifyTroChoi()
        {
        }
        public DataTable getAllTroChoi()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM TroChoi";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(QuanLyTroChoi quanLyTroChoi)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "INSERT INTO TroChoi VALUES (@MaTroChoi,@TenTroChoi,@ViTri,@MaKhu)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaTroChoi", SqlDbType.NVarChar).Value = quanLyTroChoi.Id;
                sqlCommand.Parameters.Add("@TenTroChoi", SqlDbType.NVarChar).Value = quanLyTroChoi.Name;
                sqlCommand.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = quanLyTroChoi.Vitri;
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyTroChoi.IdKhu;
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
        public bool update(QuanLyTroChoi quanLyTroChoi)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "UPDATE  TroChoi SET TenTroChoi = @TenTroChoi,ViTri = @ViTri,MaKhu = @MaKhu WHERE MaTroChoi = @MaTroChoi";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaTroChoi", SqlDbType.NVarChar).Value = quanLyTroChoi.Id;
                sqlCommand.Parameters.Add("@TenTroChoi", SqlDbType.NVarChar).Value = quanLyTroChoi.Name;
                sqlCommand.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = quanLyTroChoi.Vitri;
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyTroChoi.IdKhu;
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

        public bool delete(QuanLyTroChoi quanLyTroChoi)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "DELETE  TroChoi WHERE  MaTroChoi = @MaTroChoi";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaTroChoi", SqlDbType.NVarChar).Value = quanLyTroChoi.Id;

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
        public DataTable searchTroChoiByName(string name)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM TroChoi WHERE TenTroChoi LIKE @TenTroChoi";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@TenTroChoi", "%" + name + "%");
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable searchTroChoiByID(string id)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM TroChoi WHERE MaTroChoi LIKE @MaTroChoi";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@MaTroChoi", "%" + id + "%");
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }

}
