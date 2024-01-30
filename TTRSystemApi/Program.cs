using Microsoft.EntityFrameworkCore;
using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Logic;
using TTRSystemApi.Models;
using TTRSystemApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injecting DbContext
builder.Services.AddDbContext<TtrsContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("TtrsDbConnectionString")));

//Injecting Repository Pattern and Business Logic
builder.Services.AddScoped<IRegisterRepo, RegisterRepo>();
builder.Services.AddScoped<IRegisterLogic, RegisterLogic>();


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
