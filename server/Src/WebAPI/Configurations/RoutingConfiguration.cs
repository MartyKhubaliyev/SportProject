using Microsoft.AspNetCore.Builder;

namespace WebAPI.Configurations
{
    public static class RoutingConfiguration
    {
        public static WebApplication UseConfiguredRouting(this WebApplication app)
        {
            app.UseRouting();

            app.UseEndpoints(options => options.MapControllers());

            return app;
        }
    }
}
