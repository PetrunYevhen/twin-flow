namespace TwinFlow.Core.Models;

public class Report
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string ParamsJson { get; set; } = "{}";
    public string FilePath { get; set; } = string.Empty;

    public Project Project { get; set; } = null!;
}
