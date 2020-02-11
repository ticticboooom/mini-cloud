using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MiniCloud.Main.Service.Account.Model;

namespace MiniCloud.Main.Service.Account
{
    public interface IAccountService
    {
        Task Register(RegisterModel model);
        Task<string> Login(LoginModel model);
    }
}
