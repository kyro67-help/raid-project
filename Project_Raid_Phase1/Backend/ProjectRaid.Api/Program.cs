var builder = WebApplication.CreateBuilder(args);
builder.Services.AddProblemDetails();
var app = builder.Build();
app.UseExceptionHandler();
app.MapGet("/", () => Results.Ok(new { name = "Project Raid API", game = "Chapter 3 Season 1-inspired preservation project", status = "online", phase = 1 }));
app.MapGet("/health", () => Results.Ok(new { status = "healthy", service = "project-raid-api", timestampUtc = DateTimeOffset.UtcNow }));
app.Run();
