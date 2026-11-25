namespace TwinFlow.Core.Models;

public class TwinState
{
    public int Id { get; set; }
    public int TwinId { get; set; }
    public DateTime Timestamp { get; set; }
    public string StateJson { get; set; } = "{}";

    public Twin Twin { get; set; } = null!;
}
