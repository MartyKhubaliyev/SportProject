using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Configurations
{
    public static class ControllersConfiguration
    {
        public static WebApplicationBuilder ConfigureControllers(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            return builder;
        }

        public static WebApplication UseConfiguredControllers(this WebApplication app)
        {
            app.MapControllers();

            return app;
        }
    }
}
