using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Extensions.Options;
using MiniCloud.Main.DataAccess.Config;
using Npgsql;

namespace MiniCloud.Main.DataAccess.Repository
{
    public class DbConnectionFactory
    {
        private readonly IOptions<DbConfig> _config;

        public DbConnectionFactory(IOptions<DbConfig> config)
        {
            _config = config;
        }

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_config.Value.ConnectionString);
        }
    }
}
