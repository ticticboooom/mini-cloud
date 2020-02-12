using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MiniCloud.ContainerService.DataAccess.Model;

namespace MiniCloud.ContainerService.DataAccess.Repository.TaskDefinition
{
    public class TaskDefinitionRepository : ITaskDefinitionRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public TaskDefinitionRepository(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task CreateTaskDefinition(Model.TaskDefinition model)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                await conn.ExecuteAsync(
                    "INSERT INTO task_definition (id, group_id, name, min_vcpu, max_vcpu, container_image_name, task_type) VALUES (@Id, @GroupId, @Name, @MinVcpu, @MaxVcpu, @ContainerImageName, @TaskType);",
                    model);

            }
        }

        public async Task CreateTaskDefinitionQuartzCron(TaskDefinitionQuartzCron model)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                await conn.ExecuteAsync(
                    "INSERT INTO task_definition_quartz_cron (id, task_definition_id, quartz_expression) VALUES (@Id, @TaskDefinitionId, @QuartzExpression);",
                    model);
            }
        }

        public async Task CreateTaskDefinitionReplicaServer(TaskDefinitionReplicatedServer model)
        {
            
            using (var conn = _connectionFactory.CreateConnection())
            {
                await conn.ExecuteAsync(
                    "INSERT INTO task_definition_replica_server(id, task_definition_id, minimum_count, maximum_count) VALUES(@Id, @TaskDefinitionId, @MinimumCount, @MaximumCount);",
                    model);
            }
        }
    }
}
