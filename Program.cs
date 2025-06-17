using AbstractPatternWebApi.Interfaces;
using AbstractPatternWebApi.MacOS;
using AbstractPatternWebApi.Windows;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/render/{platform}", (string platform) =>
{
    IGuiFactory factory = platform.ToLower() switch
    {
        "windows" => new WindowsFactory(),
        "mac" => new MacFactory(),
        _ => throw new ArgumentException("Unsupported platform")
    };

    var button = factory.CreateButton().Render();
    var checkbox = factory.CreateCheckbox().Check();

    return Results.Ok(new { button, checkbox });
});

app.Run();
