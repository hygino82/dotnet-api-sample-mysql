using Microsoft.EntityFrameworkCore;
using MySqlAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionMySql = builder.Configuration.GetConnectionString("ConnectionMySql");
builder.Services.AddDbContext<APIDbContext>(options => options.UseMySql(
    connectionMySql,
    ServerVersion.Parse("8.0.27-mysql")
    )
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
