using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MiniCloud.ContainerService.DataAccess.Repository.TaskDefinitionGroup
{
    public class TaskDefinitionGroupRepository : ITaskDefinitionGroupRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public TaskDefinitionGroupRepository(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task CreateTaskDefinitionGroup(Model.TaskDefinitionGroup model)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                await conn.ExecuteAsync("INSERT INTO task_definition_group (id, name) VALUES (@Id, @Name);", model);
            }
        }
    }
}
