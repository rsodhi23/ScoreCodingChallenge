using Microsoft.Extensions.DependencyInjection;

namespace ScoreAPI.BusinessLayer
{
    public static class BusinessLayerModule
    {
        public static IServiceCollection AddBusinessLayerModule(this IServiceCollection services)
        {
            services.AddScoped<IScoreHandler, ScoreHandler>();

            return services;
        }
    }
}