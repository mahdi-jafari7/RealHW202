using Domain.AppService;
using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.AppServices;
using Domain.Core._02_Contracts.Repositories;
using Domain.Core._02_Contracts.Services;
using Domain.Service;
using Infra.db.Common;
using Infra.db.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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
builder.Services.Configure<SiteSetting>(builder.Configuration.GetSection("SiteSetting"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
