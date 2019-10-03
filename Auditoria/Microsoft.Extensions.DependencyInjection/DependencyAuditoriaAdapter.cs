using AuditoriaAdapter;
using LivrariaVirtual.Dominio.Adapters;
using Refit;
using System;
using System.Net.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyAuditoriaAdapter
    {
        public static IServiceCollection AddDependencyAuditoriaAdapter(this IServiceCollection services, string urlAuditoria)
        {
            services.AddScoped<IAuditoriaApiAdapter, AuditoriaApiAdapter>();

            services.AddScoped(serviceProvider =>
            {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri(urlAuditoria)
                };

                return RestService.For<IAuditoria>(httpClient);
            });

            return services;
        }
    }
}
