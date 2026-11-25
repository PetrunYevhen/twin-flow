using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class DriftAlert
{
    public int Id { get; set; }
    public int TwinId { get; set; }
    public DateTime Timestamp { get; set; }
    public AlertLevel Level { get; set; }
    public string Metric { get; set; } = string.Empty;
    public string SuspectedCause { get; set; } = string.Empty;
    public AlertStatus Status { get; set; }

    public Twin Twin { get; set; } = null!;
}
