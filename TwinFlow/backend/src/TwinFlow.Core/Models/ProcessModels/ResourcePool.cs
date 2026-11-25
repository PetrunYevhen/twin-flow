namespace TwinFlow.Core.Models;

public class ResourcePool
{
    public int Id { get; set; }
    public int ModelVersionId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public int? CalendarId { get; set; }
    public decimal CostPerHour { get; set; }
    public double Efficiency { get; set; } = 1.0;
    public double? Mtbf { get; set; }
    public double? Mttr { get; set; }

    public ModelVersion ModelVersion { get; set; } = null!;
    public Calendar? Calendar { get; set; }
}
