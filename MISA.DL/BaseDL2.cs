using MISA.DL.Interfaces;
using MISA.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace MISA.DL
{
    public class BaseDL2<T> : IBaseDL<T> where T : BaseEntity
    {
        public IEnumerable<T> GetData()
        {
            return null;
            // Khai báo thông tin kết nối:
            //var connectionString = "server=35.194.166.58;port=3306;user=nvmanh;password=12345678@Abc;database=MISADemo_NVMANH";
            // Khởi tạo đối tượng kết nối với Database:
            //var mySqlConnection = new MySqlConnection(connectionString);
            // Khởi tạo đối tượng tương tác với Db:
            //var mySqlCommand = mySqlConnection.CreateCommand();
            // Khai báo câu lệnh thao với DB (Thêm/sửa/xóa):
            //mySqlCommand.CommandText = "SELECT * FROM Position";
            // Thực hiện mở kết nối tới Database:
            //mySqlConnection.Open();
            // Thực hiện tương tác với Database:
            //MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            //while (mySqlDataReader.Read())
            //{
            //    var position = new Position();
            //    yield return position;
            //}

        }
    }
}
