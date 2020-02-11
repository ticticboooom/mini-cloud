using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MiniCloud.Main.DataAccess.Model;

namespace MiniCloud.Main.DataAccess.Repository.User
{
    public interface IAccountRepository
    {
        Task CreateAccount(Account account);
    }
}
