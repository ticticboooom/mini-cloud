using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniCloud.ContainerService.DataAccess.Repository.TaskDefinitionGroup;
using MiniCloud.ContainerService.Service.TaskDefinitionGroups;
using MiniCloud.ContainerService.Service.TaskDefinitionGroups.Model;
using MiniCloud.ContainerService.Service.TaskDefinitions.Model;

namespace MiniCloud.ContainerService.Controllers
{
    [Route("api/taskdefinition")]
    public class TaskDefinitionController : BaseController
    {
        private readonly ITaskDefinitionGroupService _taskDefinitionGroupService;

        public TaskDefinitionController(ITaskDefinitionGroupService taskDefinitionGroupService)
        {
            _taskDefinitionGroupService = taskDefinitionGroupService;
        }

        [HttpPost("group")]
        public async Task<IActionResult> CreateTaskDefinitionGroup([FromBody]TaskDefinitionGroupModel model)
        {
            await _taskDefinitionGroupService.CreateTaskDefinitionGroup(model, AccountId);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTaskDefinition([FromBody] TaskDefinitionModel model)
        {
            await _taskDefinitionGroupService
        }
    }
}
