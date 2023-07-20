using Microsoft.Extensions.DependencyInjection;

namespace ScoreAPI.DataLayer
{
    public static class DataLayerModule
    {
        public static IServiceCollection AddDataLayerModule(this IServiceCollection services)
        {
            //services.AddSingleton<ICacheProvider>(GetRedisCacheProvider);

            return services;
        }
    }
}
