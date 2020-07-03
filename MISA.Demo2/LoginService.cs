using MISA.Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Demo2
{
    public class LoginService : ILoginService
    {
        public async Task<bool> Login(User user)
        {
            await Task.Delay(2000);
            var userCheck = User.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
            if (userCheck != null)
                return true;
            else
                return false;
        }
    }
}
