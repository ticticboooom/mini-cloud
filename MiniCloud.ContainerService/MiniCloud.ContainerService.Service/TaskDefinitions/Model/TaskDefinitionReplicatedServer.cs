using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCloud.ContainerService.Service.TaskDefinitions.Model
{
    public class TaskDefinitionReplicatedServer
    {
        public string TaskDefinitionId { get; set; }
        public int MinimumCount { get; set; }
        public int MaximumCount { get; set; }
    }
}
