using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Customer.Api.Grpc;
using ShoppyEx.Customer.Api.Utility;
using ShoppyEx.Customer.Infrastructure.DataSeed;
using ShoppyEx.Customer.Infrastructure.IoC;
using ShoppyEx.Customer.Infrastructure.Persistence;
using ShoppyEx.SharedKernel.SeedWork.Extensions;
using ShoppyEx.SharedKernel.SeedWork.FluentValidation;
using ShoppyEx.SharedKernel.SeedWork.MediatR;
using System.Net;
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
});

builder.Services.AddGrpc(options =>
{
    options.EnableDetailedErrors = true;
})
       .Services
       .AddAutoMapper(Assembly.GetExecutingAssembly())
       .AddCustomMediatR<Program>()
       .AddCustomValidators<Program>()
       .AddSingleton(typeof(ILogger<>), typeof(Logger<>))
       .RegisterServices();

builder.Services.AddHealthChecks();

//builder.WebHost.AddKestrel(builder.Configuration);

var app = builder.Build();
app.Services.Run<ApplicationDbContext>(false);
app.Services.SeedCustomerApi(false);

app.UseRouting();
app.UseEndpoints(endpoint =>
{  
    endpoint.MapGrpcService<CustomerService>();
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


