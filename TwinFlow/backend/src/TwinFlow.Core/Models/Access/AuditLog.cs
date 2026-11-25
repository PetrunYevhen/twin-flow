namespace TwinFlow.Core.Models;

public class AuditLog
{
    public int Id { get; set; }
    public int? UserId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
    public string Ip { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }

    public User? User { get; set; }
}
