using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class Twin
{
    public int Id { get; set; }
    public int ModelVersionId { get; set; }
    public string Source { get; set; } = string.Empty;
    public TwinStatus Status { get; set; }
    public string WindowConfigJson { get; set; } = "{}";
    public double HealthIndex { get; set; }

    public ModelVersion ModelVersion { get; set; } = null!;
    public ICollection<TwinState> States { get; set; } = new List<TwinState>();
    public ICollection<CalibrationCandidate> CalibrationCandidates { get; set; } = new List<CalibrationCandidate>();
    public ICollection<DriftAlert> DriftAlerts { get; set; } = new List<DriftAlert>();
    public ICollection<Forecast> Forecasts { get; set; } = new List<Forecast>();
    public ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation>();
}
