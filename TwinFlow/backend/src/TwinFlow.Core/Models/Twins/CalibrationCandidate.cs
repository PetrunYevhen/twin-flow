using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class CalibrationCandidate
{
    public int Id { get; set; }
    public int TwinId { get; set; }
    public DateTime WindowStart { get; set; }
    public DateTime WindowEnd { get; set; }
    public string ParamsDiffJson { get; set; } = "{}";
    public string KpiImpactJson { get; set; } = "{}";
    public CalibrationStatus Status { get; set; }

    public Twin Twin { get; set; } = null!;
}
