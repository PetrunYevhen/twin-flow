using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class SimulationRun
{
    public int Id { get; set; }
    public int ModelVersionId { get; set; }
    public int? ScenarioId { get; set; }
    public string ParamsJson { get; set; } = "{}";
    public long Seed { get; set; }
    public string CodeVersion { get; set; } = string.Empty;
    public JobStatus Status { get; set; }
    public string ResultsJson { get; set; } = "{}";

    public ModelVersion ModelVersion { get; set; } = null!;
    public Scenario? Scenario { get; set; }
}
