using MISA.Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Demo2
{
    public interface ILoginService
    {
        Task<bool> Login(User user);
    }
}
