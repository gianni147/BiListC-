using ASPNET;
using ASPNET.Contexts;
using ASPNET.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepo, MysqlRepo>();

String _connectionstring = "server=localhost:3306;database=bilist;user=bilist_user;password=bilist_pass;";
Console.WriteLine(_connectionstring);
builder.Services.AddDbContext<BiListContext>(opt => opt.UseMySql(_connectionstring, ServerVersion.AutoDetect(_connectionstring)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
