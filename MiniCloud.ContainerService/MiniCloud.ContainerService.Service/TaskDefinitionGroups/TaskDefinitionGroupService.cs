using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MiniCloud.ContainerService.DataAccess.Model;
using MiniCloud.ContainerService.DataAccess.Repository;
using MiniCloud.ContainerService.DataAccess.Repository.TaskDefinitionGroup;
using MiniCloud.ContainerService.Service.TaskDefinitionGroups.Model;
using MiniCloud.Packages.Identification;

namespace MiniCloud.ContainerService.Service.TaskDefinitionGroups
{
    public class TaskDefinitionGroupService : ITaskDefinitionGroupService
    {
        private readonly ITaskDefinitionGroupRepository _taskDefinitionGroupRepository;

        public TaskDefinitionGroupService(ITaskDefinitionGroupRepository taskDefinitionGroupRepository)
        {
            _taskDefinitionGroupRepository = taskDefinitionGroupRepository;
        }

        public async Task CreateTaskDefinitionGroup(TaskDefinitionGroupModel model, int accId)
        {
            var id = IdGeneratorHelper.GenerateId("tdg", accId.ToString());
            var networkId = IdGeneratorHelper.GenerateId("i-cnn", accId.ToString());
            await _taskDefinitionGroupRepository.CreateTaskDefinitionGroup(new TaskDefinitionGroup()
            {
                ContainerNetworkName = networkId,
                Id = id,
                Name = model.Name
            });
        }
    }
}
