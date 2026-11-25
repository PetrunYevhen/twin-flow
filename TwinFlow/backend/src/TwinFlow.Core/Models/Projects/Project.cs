namespace TwinFlow.Core.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string TimeZone { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string Units { get; set; } = string.Empty;
    public int? CalendarId { get; set; }
    public string SlaTargetsJson { get; set; } = "{}";
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Calendar? Calendar { get; set; }
    public ICollection<ProcessModel> ProcessModels { get; set; } = new List<ProcessModel>();
    public ICollection<Dataset> Datasets { get; set; } = new List<Dataset>();
}
