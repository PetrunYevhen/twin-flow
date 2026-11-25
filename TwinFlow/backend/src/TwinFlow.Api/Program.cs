var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/api/v1/health", () => Results.Ok(new
{
    status = "ok",
    service = "TwinFlow.Api",
    timeUtc = DateTime.UtcNow
}));

app.Run();
