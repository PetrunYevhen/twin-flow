using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class Experiment
{
    public int Id { get; set; }
    public ExperimentKind Kind { get; set; }
    public string ConfigJson { get; set; } = "{}";
    public JobStatus Status { get; set; }
    public string ResultsJson { get; set; } = "{}";
}
