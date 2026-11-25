using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class Job
{
    public int Id { get; set; }
    public JobType Type { get; set; }
    public JobStatus Status { get; set; }
    public double Progress { get; set; }
    public string PayloadJson { get; set; } = "{}";
    public string? Error { get; set; }
}
