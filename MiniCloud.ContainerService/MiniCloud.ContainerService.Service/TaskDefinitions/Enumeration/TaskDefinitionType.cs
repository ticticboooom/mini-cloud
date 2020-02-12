using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCloud.ContainerService.Service.TaskDefinitions.Enumeration
{
    public enum TaskDefinitionType
    {
        SingularServer,
        ReplicatedServer,
        QuartzCron,
    }
}
