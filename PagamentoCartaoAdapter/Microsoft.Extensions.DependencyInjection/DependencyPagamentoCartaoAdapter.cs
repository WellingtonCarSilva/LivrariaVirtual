using LivrariaVirtual.Dominio.Adapters;
using PagamentoCartaoAdapter;
using Refit;
using System;
using System.Net.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyPagamentoCartaoAdapter
    {
        public static IServiceCollection AddDependencyPagamentoCartaoAdapter(this IServiceCollection services, string urlPagamento)
        {
            services.AddScoped<IPagamentoCartaoApiAdapter, PagamentoCartaoApiAdapter>();

            services.AddScoped(serviceProvider =>
            {
                //var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
                //httpClientFactory.CreateClient("");

                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri(urlPagamento)
                };

                return RestService.For<IPagamentoCartao>(httpClient);
            });

            return services;
        }
    }
}
