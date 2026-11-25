namespace TwinFlow.Core.Models;

public class ModelVersion
{
    public int Id { get; set; }
    public int ProcessModelId { get; set; }
    public int Number { get; set; }
    public string GraphJson { get; set; } = "{}";
    public string Comment { get; set; } = string.Empty;
    public int CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }

    public ProcessModel ProcessModel { get; set; } = null!;
    public ICollection<ResourcePool> ResourcePools { get; set; } = new List<ResourcePool>();
}
