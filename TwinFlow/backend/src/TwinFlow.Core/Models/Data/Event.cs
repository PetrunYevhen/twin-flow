namespace TwinFlow.Core.Models;

public class Event
{
    public long Id { get; set; }
    public int DatasetId { get; set; }
    public string CaseId { get; set; } = string.Empty;
    public string Activity { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public string? Resource { get; set; }
    public string? Lifecycle { get; set; }
    public string AttributesJson { get; set; } = "{}";

    public Dataset Dataset { get; set; } = null!;
}
