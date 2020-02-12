using System;
using System.Collections.Generic;
using System.Text;
using MiniCloud.ContainerService.Service.TaskDefinitions.Enumeration;

namespace MiniCloud.ContainerService.Service.TaskDefinitions.Model
{
    public class TaskDefinitionModel
    {
        public string Id { get; set; }
        public string GroupId { get; set; }
        public string Name { get; set; }
        public string ContainerImageName { get; set; }
        public decimal MinVcpu { get; set; }
        public decimal MaxVcpu { get; set; }
        public TaskDefinitionType TaskType { get; set; }
        public TaskDefinitionQuartzCron QuartzCron { get; set; }
        public TaskDefinitionReplicatedServer ReplicaServer { get; set; }
    }
}
