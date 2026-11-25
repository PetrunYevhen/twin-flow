using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class Recommendation
{
    public int Id { get; set; }
    public int TwinId { get; set; }
    public string Detector { get; set; } = string.Empty;
    public string ActionJson { get; set; } = "{}";
    public string EffectJson { get; set; } = "{}";
    public RecommendationStatus Status { get; set; }
    public string Comment { get; set; } = string.Empty;

    public Twin Twin { get; set; } = null!;
}
