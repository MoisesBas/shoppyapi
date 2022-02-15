
var builder = WebApplication.CreateBuilder(args);
builder.Services
       .AddCors(options =>
       {
           options.AddPolicy("CorsPolicy", cors =>
                   cors.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader());
       })
       .AddOptions()
       .Configure<UrlsConfig>(builder.Configuration.GetSection("urls"))
       .AddMvcCore()
       .AddApiExplorer()
       .Services
       .AddAppApiVersioning()
       .AddSwagger(builder.Configuration)
       .AddGrpcServices()
       .AddHealthChecks();

var app = builder.Build();
    app.UseSwaggerInDevAndStaging();

app.UseRouting();
app.UseCors("CorsPolicy");
app.UseEndpoints(endpoint =>
{
    endpoint.MapDefaultControllerRoute();
    endpoint.MapControllers();
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
