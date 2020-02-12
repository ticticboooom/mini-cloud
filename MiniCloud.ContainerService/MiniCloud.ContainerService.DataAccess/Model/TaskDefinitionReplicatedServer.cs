namespace MiniCloud.ContainerService.DataAccess.Model
{
    public class TaskDefinitionReplicatedServer
    {
        public string Id { get; set; }
        public string TaskDefinitionId { get; set; }
        public int MinimumCount { get; set; }
        public int MaximumCount { get; set; }
    }
}
