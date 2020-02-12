namespace MiniCloud.ContainerService.DataAccess.Model
{
    public class TaskDefinitionQuartzCron
    {
        public string Id { get; set; }
        public string TaskDefinitionId { get; set; }
        public string QuartzExpression { get; set; }
    }
}
