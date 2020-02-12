using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MiniCloud.ContainerService.DataAccess.Repository.TaskDefinitionGroup
{
    public interface ITaskDefinitionGroupRepository
    {
        Task CreateTaskDefinitionGroup(Model.TaskDefinitionGroup model);
    }
}
