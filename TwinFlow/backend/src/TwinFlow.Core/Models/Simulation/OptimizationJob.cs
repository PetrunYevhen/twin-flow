using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class OptimizationJob
{
    public int Id { get; set; }
    public string ConfigJson { get; set; } = "{}";
    public OptimizationAlgorithm Algorithm { get; set; }
    public double Progress { get; set; }
    public string ParetoJson { get; set; } = "[]";
}
