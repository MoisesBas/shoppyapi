using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShoppyEx.Identity.Api;
using ShoppyEx.Identity.Api.Services;
using ShoppyEx.Identity.Api.Utility;
using ShoppyEx.Identity.Infrastructure.Identity;
using ShoppyEx.Identity.Infrastructure.IoC;
using ShoppyEx.Identity.Infrastructure.Persistence;
using ShoppyEx.SharedKernel.SeedWork;
using ShoppyEx.SharedKernel.SeedWork.Extensions;
using ShoppyEx.SharedKernel.SeedWork.FluentValidation;
using ShoppyEx.SharedKernel.SeedWork.MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    ApplicationName = typeof(Program).Assembly.FullName,
    ContentRootPath = Directory.GetCurrentDirectory(),
    EnvironmentName = Environments.Development,
});

builder.Services.AddDbContext<ApplicationDbContext>(X =>
{
    X.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    X.EnableSensitiveDataLogging();
});

builder.Services
       .AddGrpc()
       .Services
       .AddAutoMapper(Assembly.GetExecutingAssembly())
       .AddCustomMediatR<Program>()
       .AddCustomValidators<Program>()
       .AddSingleton(typeof(ILogger<>), typeof(Logger<>))
       .AddOptions()
       .Configure<UrlsConfig>(builder.Configuration.GetSection("urls"))
       .AddCustomIdentity()
       .AddGrpcServices()
       .RegisterServices();



builder.Services.AddHealthChecks();

//builder.WebHost.AddKestrel(builder.Configuration);
var app = builder.Build();
app.Services.Run<ApplicationDbContext>(false);
app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapGrpcService<UserService>();   
    endpoint.MapHealthChecks("/hc", new HealthCheckOptions()
    {
        Predicate = _ => true,
        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
    });
    endpoint.MapHealthChecks("/liveness", new HealthCheckOptions
    {
        Predicate = r => r.Name.Contains("self")
    });

});
app.Run();