using TwinFlow.Core.Models.Enums;

namespace TwinFlow.Core.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public DateTime? LockedUntil { get; set; }

    public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
}
