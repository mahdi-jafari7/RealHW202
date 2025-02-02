using Domain.AppService;
using Domain.Core._02_Contracts.AppServices;
using Domain.Core._02_Contracts.Repositories;
using Domain.Core._02_Contracts.Services;
using Domain.Service;
using Infra.db.Common;
using Infra.db.DataAccess.Repositories;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAdminAppService, AdminAppService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();


builder.Services.AddScoped<ICarInspectAppService, CarInspectAppService>();
builder.Services.AddScoped<ICarInspectService, CarInspectService>();
builder.Services.AddScoped<ICarInspectRepository, CarInspectRepository>();


builder.Services.AddScoped<IRejectedLogsAppService, RejectedLogsAppService>();
builder.Services.AddScoped<IRejectedLogsService, RejectedLogsService>();
builder.Services.AddScoped<IRejectedLogsRepository, RejectedLogsRepository>();


builder.Services.AddScoped<ICarModelAppService, CarModelAppService>();
builder.Services.AddScoped<ICarModelService, CarModelService>();
builder.Services.AddScoped<ICarModelRepository, CarModelRepository>();


builder.Services.AddDbContext<InspectionDbContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
