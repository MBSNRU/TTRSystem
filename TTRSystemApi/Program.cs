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
builder.Services.AddScoped<IStationRepo, StationRepo>();
builder.Services.AddScoped<IStationLogic, StationLogic>();
builder.Services.AddScoped<ITrainRepo, TrainRepo>();
builder.Services.AddScoped<ITrainLogic, TrainLogic>();
builder.Services.AddScoped<ICoachRepo, CoachRepo>();
builder.Services.AddScoped<ICoachLogic, CoachLogic>();
builder.Services.AddScoped<ISeatRepo, SeatRepo>();
builder.Services.AddScoped<ISeatLogic, SeatLogic>();
builder.Services.AddScoped<ITrainStationRepo, TrainStationRepo>();
builder.Services.AddScoped<ITrainStationLogic, TrainStationLogic>();
builder.Services.AddScoped<IBookingRepo, BookingRepo>();
builder.Services.AddScoped<IBookingLogic, BookingLogic>();


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
