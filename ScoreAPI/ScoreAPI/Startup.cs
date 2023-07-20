using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using ScoreAPI.Controllers;

namespace ScoreAPI;

public class Startup
{
    private readonly IConfigurationRoot _configuration;

    public Startup(IWebHostEnvironment env)
    {
        _configuration = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", false, true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
            .AddEnvironmentVariables()
            .Build();
    }

    // This method gets called by a runtime.
    // Use this method to add services to the container
    public void ConfigureServices(IServiceCollection services)
    {


        services.AddSingleton<IConfiguration>(_configuration);

        services.AddControllers()
            .AddApplicationPart(typeof(AssemblyMarker).Assembly);

        services.AddServiceHostModule();

        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressConsumesConstraintForFormFileParameters = true;
            options.SuppressInferBindingSourcesForParameters = true;
            options.SuppressModelStateInvalidFilter = true;
        });

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v3.0.0",
                new OpenApiInfo { Title = "ScoreAPI", Description = "A RESTful API.", Version = "3.0.0" });
            c.SupportNonNullableReferenceTypes();
            c.UseInlineDefinitionsForEnums();
            c.CustomSchemaIds(type => type.ToString());
        });
    }

    // Configure is called after ConfigureServices is called.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v3.0.0/swagger.json", "ScoreAPI - v3.0.0"));
    }
}
