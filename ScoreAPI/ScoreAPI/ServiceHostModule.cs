using ScoreAPI.BusinessLayer;
using ScoreAPI.DataLayer;

namespace ScoreAPI
{
    public static class ServiceHostModule
    {
        public static IServiceCollection AddServiceHostModule(this IServiceCollection services)
        {
            services.AddDataLayerModule();
            services.AddBusinessLayerModule();

            return services;
        }
    }
}
