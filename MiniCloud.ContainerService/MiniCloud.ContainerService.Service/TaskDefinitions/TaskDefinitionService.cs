using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MiniCloud.ContainerService.DataAccess.Model;
using MiniCloud.ContainerService.DataAccess.Repository.TaskDefinition;
using MiniCloud.ContainerService.Service.TaskDefinitions.Enumeration;
using MiniCloud.ContainerService.Service.TaskDefinitions.Model;
using MiniCloud.Packages.Identification;
using TaskDefinitionQuartzCron = MiniCloud.ContainerService.DataAccess.Model.TaskDefinitionQuartzCron;
using TaskDefinitionReplicatedServer = MiniCloud.ContainerService.DataAccess.Model.TaskDefinitionReplicatedServer;

namespace MiniCloud.ContainerService.Service.TaskDefinitions
{
    public class TaskDefinitionService : ITaskDefinitionService
    {
        private readonly ITaskDefinitionRepository _taskDefinitionRepository;

        public TaskDefinitionService(ITaskDefinitionRepository taskDefinitionRepository)
        {
            _taskDefinitionRepository = taskDefinitionRepository;
        }

        public async Task CreateTaskDefinition(TaskDefinitionModel model, int accId)
        {
            var id = IdGeneratorHelper.GenerateId("td", accId.ToString());
            await _taskDefinitionRepository.CreateTaskDefinition(new TaskDefinition()
            {
                Name = model.Name,
                Id = id,
                ContainerImageName = model.ContainerImageName,
                GroupId = model.GroupId,
                MaxVcpu = model.MaxVcpu,
                MinVcpu = model.MinVcpu,
                TaskType = (int)model.TaskType
            });

            if (model.TaskType == TaskDefinitionType.QuartzCron)
            {
                await _taskDefinitionRepository.CreateTaskDefinitionQuartzCron(new TaskDefinitionQuartzCron()
                {
                    Id = IdGeneratorHelper.GenerateId("td-qc", accId.ToString()),
                    QuartzExpression = model.QuartzCron.QuartzExpression,
                    TaskDefinitionId = id
                });
            }
            else if (model.TaskType == TaskDefinitionType.ReplicatedServer)
            {
                await _taskDefinitionRepository.CreateTaskDefinitionReplicaServer(new TaskDefinitionReplicatedServer()
                {
                    Id = IdGeneratorHelper.GenerateId("td-qc", accId.ToString()),
                    MaximumCount = model.ReplicaServer.MaximumCount,
                    MinimumCount = model.ReplicaServer.MinimumCount,
                    TaskDefinitionId = id
                });
            }
        }
    }
}
