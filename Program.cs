using System.Data.SqlClient;
using System.Data.Common;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<DbConnection>(sp => sp.ConnectionConfiguration.GetConnectionString("DefaultConnection"));
builder.Services.AddScoped</*Interface DAL  obj 1, Class Dal obj 1*/>();
builder.Services.AddScoped</*Interface Bll obj1 , Class Bll obj 1*/>();



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
