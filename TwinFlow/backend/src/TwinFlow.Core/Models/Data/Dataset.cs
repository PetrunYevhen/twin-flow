using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class Dataset
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DatasetOrigin Origin { get; set; }
    public int? ParentDatasetId { get; set; }
    public string QualityReportJson { get; set; } = "{}";

    public Project Project { get; set; } = null!;
    public Dataset? ParentDataset { get; set; }
    public ICollection<Event> Events { get; set; } = new List<Event>();
}
