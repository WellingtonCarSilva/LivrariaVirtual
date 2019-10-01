using LivrariaVirtual.Dominio.Repositories;
using Repository;
using System.Data;
using System.Data.SqlClient;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyRepository
    {
        public static IServiceCollection AddDependencyRepository(this IServiceCollection services, string connectionString )
        {
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<IComentarioRepository, ComentarioRepository>();
            services.AddScoped<IDbConnection>(d =>
            {
                return new SqlConnection(connectionString);
            });
            return services;
        }
    }
}
