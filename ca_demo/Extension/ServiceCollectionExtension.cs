using Application.Common;
using Application.UseCases;
using EFRepository;
using System.Security.AccessControl;

namespace ca_demo.Extension
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterUseCase(this IServiceCollection services)
        {
            return services
                .AddScoped<PlayerJoinGameUseCase>();
        }

        public static IServiceCollection RegisterRepository(this IServiceCollection services)
        {
            return services
                .AddScoped<IRepository, GameRepository>();
        }
    }
}
