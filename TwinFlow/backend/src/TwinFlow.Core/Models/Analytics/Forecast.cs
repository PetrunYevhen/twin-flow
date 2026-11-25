using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class Forecast
{
    public int Id { get; set; }
    public int TwinId { get; set; }
    public ForecastKind Kind { get; set; }
    public TimeSpan Horizon { get; set; }
    public string ResultsJson { get; set; } = "{}";
    public double? Accuracy { get; set; }

    public Twin Twin { get; set; } = null!;
}
