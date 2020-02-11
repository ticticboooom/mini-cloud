using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MiniCloud.Main.DataAccess.Model;

namespace MiniCloud.Main.DataAccess.Repository.User
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public AccountRepository(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task CreateAccount(Account account)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                await conn.ExecuteAsync("INSERT INTO accounts (first_name, last_name, username, password_hash) VALUES (@FirstName, @LastName, @Username, @PasswordHash);", account);
            }
        }
    }
}
