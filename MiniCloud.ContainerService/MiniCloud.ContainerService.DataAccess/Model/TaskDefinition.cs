using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCloud.ContainerService.DataAccess.Model
{
    public class TaskDefinition
    {
        public string Id { get; set; }
        public string GroupId { get; set; }
        public string Name { get; set; }
        public string ContainerImageName { get; set; }
        public decimal MinVcpu { get; set; }
        public decimal MaxVcpu { get; set; }
        public int TaskType { get; set; }
    }
}
