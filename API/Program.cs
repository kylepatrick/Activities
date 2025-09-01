using System.Net.WebSockets;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
 

var app = builder.Build();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod()
.WithOrigins("http://localhost:3000","https://localhost:3000"));

app.MapControllers();
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
try
{
    var context = services.GetRequiredService<AppDbContext>();
    await context.Database.MigrateAsync();
    await DBInitializer.SeedData(context);

}
catch (Exception ex)
{   
var logger=services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex,"Migration error");
    
}
app.Run();
