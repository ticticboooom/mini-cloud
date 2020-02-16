using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace MiniCloud.System.ContainerService.DataAccess
{
    public class DbService
    {
        private readonly IConfiguration _config;

        public DbService(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection GetConnection()
        {
            return new NpgsqlConnection(_config.GetConnectionString("ConnectionString"));
        }
    }
}
