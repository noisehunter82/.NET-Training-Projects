using LocalisedAPI.Controllers;
using LocalisedAPI.Services;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddKeyedSingleton<IScripService, ScripServiceEMEA>("emea");
builder.Services.AddKeyedSingleton<IScripService, ScripServiceNA>("na");
builder.Services.AddKeyedSingleton<IScripService, ScripServiceAU>("au");

builder.Services.AddControllers().AddJsonOptions(options =>
{
    // Serialises enum names as strings to be displayed as dropdown values in Swagger UI. Without this the displayed values would be numbers.
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.MapType<Region>(() => new OpenApiSchema
    {
        Type = "string",
        Enum = typeof(Region)
        .GetEnumValues()
        .Cast<object>()
        .Select(value => (IOpenApiAny)new OpenApiString(value.ToString()))
        .ToList()
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
