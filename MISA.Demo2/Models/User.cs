using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Demo2.Models
{
    public class User
    {
        public User()
        {

        }
        public User(string userName, string pw)
        {
            this.UserName = userName;
            Password = pw;
        }
        // Fix danh sách User:
        public static List<User> Users = new List<User>()
        {
            new User("nvmanh","12345678"),
            new User ("admin","12345678")
        };

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
