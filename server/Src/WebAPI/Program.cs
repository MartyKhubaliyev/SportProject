using Microsoft.AspNetCore.Builder;
using WebAPI.Configurations;

WebApplication.CreateBuilder(args)
    .ConfigureControllers()
    .Build()
    .UseConfiguredControllers()
    .UseConfiguredRouting()
    .Run();
