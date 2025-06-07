using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddScoped<ITermAndConditionService, TermAndConditionService>();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("TermsDatabase")));

builder.Services.AddCors(x =>
{
    x.AddPolicy("AllowFrontend", x =>
    {
        x.WithOrigins("https://https://icy-pebble-08fddfa03.6.azurestaticapps.net")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();
app.UseCors("AllowFrontend");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
