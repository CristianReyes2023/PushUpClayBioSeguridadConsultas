using System.Reflection;
using API.Extensions;
using AspNetCoreRateLimit;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistence.Data;

var builder = WebApplication.CreateBuilder(args);
// var logger = new LoggerConfiguration()
// 					.ReadFrom.Configuration(builder.Configuration)
// 					.Enrich.FromLogContext()
// 					.CreateLogger();

// Add services to the container.

builder.Services.AddControllers(options => {
    options.RespectBrowserAcceptHeader = true;
}).AddXmlSerializerFormatters();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureCors();
builder.Services.AddApplicationServices();
builder.Services.ConfigureRateLimiting();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());

builder.Services.AddDbContext<BioseguridadContext>(options =>
{
    string  connectionString = builder.Configuration.GetConnectionString("MySqlConex");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try{
        var context = services.GetRequiredService<BioseguridadContext>();
        await context.Database.MigrateAsync();
    }
    catch(Exception ex)
    {
        var _logger = loggerFactory.CreateLogger<BioseguridadContext>();
        _logger.LogError(ex, "Ocurrio un error durante la migracion");
    }
}


app.UseIpRateLimiting();
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();