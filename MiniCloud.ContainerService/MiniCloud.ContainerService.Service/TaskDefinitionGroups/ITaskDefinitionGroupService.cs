using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MiniCloud.ContainerService.Service.TaskDefinitionGroups.Model;
using MiniCloud.ContainerService.Service.TaskDefinitions.Model;

namespace MiniCloud.ContainerService.Service.TaskDefinitionGroups
{
    public interface ITaskDefinitionGroupService
    {
        Task CreateTaskDefinitionGroup(TaskDefinitionGroupModel model, int accId);
        Task CreateTaskDefinition(TaskDefinitionModel model, int accId);
    }
}
