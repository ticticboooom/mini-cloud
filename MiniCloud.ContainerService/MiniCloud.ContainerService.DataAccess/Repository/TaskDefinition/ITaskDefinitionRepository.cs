using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MiniCloud.ContainerService.DataAccess.Repository.TaskDefinition
{
    public interface ITaskDefinitionRepository
    {
        Task CreateTaskDefinition(Model.TaskDefinition model);
        Task CreateTaskDefinitionQuartzCron(Model.TaskDefinitionQuartzCron model);
        Task CreateTaskDefinitionReplicaServer(Model.TaskDefinitionReplicatedServer model);
    }
}
