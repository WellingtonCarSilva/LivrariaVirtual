using AutenticacaoAdapter;
using LivrariaVirtual.Dominio.Adapters;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyAutenticacaoAdapter
    {
        public static IServiceCollection AddDependencyAutenticacaoAdapter(this IServiceCollection services, string urlAutenticacao)
        {
            services.AddScoped<IAutenticacaoApiAdapter, AutenticacaoApiAdapter>();

            services.AddScoped(serviceProvider =>
            {
                var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
                var httpClient = httpClientFactory.CreateClient("");
                httpClient.BaseAddress = new Uri(urlAutenticacao);

                return RestService.For<IAutenticacao>(httpClient);
            });

            return services;
        }
    }
}
