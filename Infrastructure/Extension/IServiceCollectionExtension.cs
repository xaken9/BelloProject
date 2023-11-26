using Application.Interface;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extension
{
    public static class IServiceCollectionExtension
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>();
        }
    }
}
