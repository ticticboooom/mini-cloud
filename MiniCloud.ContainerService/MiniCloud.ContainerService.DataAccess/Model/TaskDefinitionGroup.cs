using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCloud.ContainerService.DataAccess.Model
{
    public class TaskDefinitionGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ContainerNetworkName { get; set; }
    }
}
