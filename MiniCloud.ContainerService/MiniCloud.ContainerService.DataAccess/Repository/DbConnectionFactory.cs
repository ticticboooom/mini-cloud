using System.Data;
using Microsoft.Extensions.Options;
using MiniCloud.ContainerService.DataAccess.Config;
using Npgsql;

namespace MiniCloud.ContainerService.DataAccess.Repository
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
