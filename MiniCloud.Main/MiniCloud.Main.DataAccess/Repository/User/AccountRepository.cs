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
                await conn.ExecuteAsync("INSERT INTO accounts (first_name, last_name, email_address, password_hash) VALUES (@FirstName, @LastName, @EmailAddress, @PasswordHash);", account);
            }
        }

        public async Task<Account> GetUserByEmail(string email)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                return await conn.QueryFirstOrDefaultAsync<Account>("SELECT id as Id, first_name as FirstName, last_name as LastName, email_address as EmailAddress, password_hash as PasswordHash from accounts where email_address = @EmailAddress;", new { EmailAddress = email });
            }
        }
    }
}
