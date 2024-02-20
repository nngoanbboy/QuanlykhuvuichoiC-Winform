using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhuVuiChoi
{
    class ModifyNhanVien
    {
        SqlDataAdapter dataAdapter;//truy xuat data vao bang
        SqlCommand sqlCommand; //truy van
        public ModifyNhanVien()
        {
        }

        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM NhanVien";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(QuanLyNhanVien quanLyNhanVien)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "INSERT INTO NhanVien VALUES (@MaNV,@HoTen,@NgaySinh,@GioiTinh,@SDT,@ChucVu,@DiaChi,@Luong,@MaKhu)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = quanLyNhanVien.Id;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = quanLyNhanVien.Name;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = quanLyNhanVien.DateOfBirth;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = quanLyNhanVien.Sex;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = quanLyNhanVien.Phone;
                sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = quanLyNhanVien.Role;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = quanLyNhanVien.Address;
                sqlCommand.Parameters.Add("@Luong", SqlDbType.Int).Value = quanLyNhanVien.Salary;
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyNhanVien.IdKhu;
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
        public bool update(QuanLyNhanVien quanLyNhanVien)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "UPDATE  NhanVien SET HoTen = @HoTen,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,SDT = @SDT,ChucVu = @ChucVu,DiaChi = @DiaChi,Luong = @Luong,MaKhu = @MaKhu WHERE MaNV = @MaNV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = quanLyNhanVien.Id;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = quanLyNhanVien.Name;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = quanLyNhanVien.DateOfBirth;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = quanLyNhanVien.Sex;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = quanLyNhanVien.Phone;
                sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = quanLyNhanVien.Role;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = quanLyNhanVien.Address;
                sqlCommand.Parameters.Add("@Luong", SqlDbType.Int).Value = quanLyNhanVien.Salary;
                sqlCommand.Parameters.Add("@MaKhu", SqlDbType.NVarChar).Value = quanLyNhanVien.IdKhu;
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

        public bool delete(QuanLyNhanVien quanLyNhanVien)
        {
            SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection();
            string query = "DELETE  NhanVien WHERE MaNV = @MaNV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = quanLyNhanVien.Id;
               
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

        public DataTable searchNhanVienByName(string name)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM NhanVien WHERE HoTen LIKE @HoTen";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@HoTen", "%" + name + "%");
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable searchNhanVienByID(string id)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM NhanVien WHERE MaNV LIKE @MaNV";
            using (SqlConnection sqlConnection = ConnectionKVC.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@MaNV", "%" + id + "%");
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
