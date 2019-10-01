using LivrariaVirtual.Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LivrariaVirtual.Dominio.Models;

namespace Repository
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly IDbConnection connection;

        public ComentarioRepository(IDbConnection connection)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public async Task InsereComentario(Comentario comentario)
        {
            var query = @"INSERT INTO Comentario 
                          VALUES(@Id, @IdLivro, @Mensagem)";

            await connection.ExecuteAsync(query, comentario);
        }
    }
}
