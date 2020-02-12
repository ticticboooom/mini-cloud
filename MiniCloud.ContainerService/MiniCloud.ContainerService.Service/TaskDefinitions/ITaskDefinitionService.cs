using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MiniCloud.ContainerService.Service.TaskDefinitions.Model;

namespace MiniCloud.ContainerService.Service.TaskDefinitions
{
    public interface ITaskDefinitionService
    {
        Task CreateTaskDefinition(TaskDefinitionModel model, int accId);
    }
}
