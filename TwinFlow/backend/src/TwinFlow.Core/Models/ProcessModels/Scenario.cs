namespace TwinFlow.Core.Models;

public class Scenario
{
    public int Id { get; set; }
    public int ProcessModelId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ChangesJson { get; set; } = "{}";
    public string Notes { get; set; } = string.Empty;

    public ProcessModel ProcessModel { get; set; } = null!;
}
