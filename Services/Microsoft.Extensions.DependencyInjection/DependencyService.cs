using LivrariaVirtual.Dominio.Services;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyService
    {
        public static IServiceCollection AddDependencyService(this IServiceCollection services)
        {
            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<ICarrinhoService, CarrinhoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            
            return services;
        }
    }
}
