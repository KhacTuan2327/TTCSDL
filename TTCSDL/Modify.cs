using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TTCSDL
{
    internal class Modify //Thay đổi các lần truy xuất theo nhu cầu
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;//Dùng để truy vấn câu lệnh trong sql
        SqlDataReader dataReader; //Đọc dữ liệu từ trong bảng

        public List<UserLogin> UserLogins (string query) //truy vấn tài khoản đăng nhập
        {
            List<UserLogin> users = new List<UserLogin>();
            using(SqlConnection sqlConnection = Connection.GetSqlConnection()) //Sử dụng lệnh trong ngoặc nhọn, sau khi thực hiện xong thì 
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
    }
}
