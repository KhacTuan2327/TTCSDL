using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TTCSDL
{
    internal class Modify //Thay đổi các lần truy xuất theo nhu cầu
    {

        //SqlDataAdapter dataAdapter; //Se truy xuat du lieu vao bang
        public Modify()
        {
        }
        SqlCommand sqlCommand;//Dùng để truy vấn câu lệnh trong sql
        SqlDataAdapter adapter; //truy xuất dữ liệu từ bảng 
        SqlDataReader dataReader; //Đọc dữ liệu từ trong bảng
        //truy vấn lấy từ bảng DANGNHAP
        public List<UserLogin> UserLogins (string query) //truy vấn tài khoản đăng nhập
        {
            List<UserLogin> users = new List<UserLogin>();
            using(SqlConnection sqlConnection = Connection.getConnection()) //Sử dụng lệnh trong ngoặc nhọn, sau khi thực hiện xong thì 
                //xóa toàn bộ đối tượng đã khởi tạo trong ngoặc
            {
                
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader(); //Lệnh thực thi đọc dữ liệu bảng
                while (dataReader.Read())
                {
                    users.Add(new UserLogin(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return users;
        }
        //hiển thị thông tin Table
        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.getConnection())
              {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        //Dùng để thêm sửa xóa
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand (query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        //----------------bỏ-----------------
        public bool insert(Khoa khoa)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into Khoa values (@MAKHOA, @TENKHOA, @DIACHI, @CHUNHIEM, @SĐT)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MAKHOA", SqlDbType.VarChar).Value = khoa.Id;
                sqlCommand.Parameters.Add("@TENKHOA", SqlDbType.NVarChar).Value = khoa.Name;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = khoa.Address;
                sqlCommand.Parameters.Add("@CHUNHIEM", SqlDbType.NVarChar).Value = khoa.Boss;
                sqlCommand.Parameters.Add("@SĐT", SqlDbType.NVarChar).Value = khoa.Phone;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
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
        public bool update(Khoa khoa)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "update Khoa set MAKHOA = @MAKHOA, TENKHOA = @TENKHOA,DIACHI=DIACHI, CHUNHIEM=CHUNHIEM, SĐT=@SĐT Where MAKHOA = @MAKHOA ";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MAKHOA", SqlDbType.VarChar).Value = khoa.Id;
                sqlCommand.Parameters.Add("@TENKHOA", SqlDbType.NVarChar).Value = khoa.Name;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = khoa.Address;
                sqlCommand.Parameters.Add("@CHUNHIEM", SqlDbType.NVarChar).Value = khoa.Boss;
                sqlCommand.Parameters.Add("@SĐT", SqlDbType.NVarChar).Value = khoa.Phone;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
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

        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete Khoa where MAKHOA = @MAKHOA";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MAKHOA", SqlDbType.VarChar).Value = id;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
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
