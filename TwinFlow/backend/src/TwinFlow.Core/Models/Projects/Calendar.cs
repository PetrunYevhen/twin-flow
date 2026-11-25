namespace TwinFlow.Core.Models;

public class Calendar
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string ShiftsJson { get; set; } = "[]";
    public string ExceptionsJson { get; set; } = "[]";
}
