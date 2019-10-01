using Dapper;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly IDbConnection connection;

        public LivroRepository(IDbConnection connection)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public async Task<IEnumerable<Livro>> BuscaLivro(Livro livro)
        {
            var parameter = new DynamicParameters();

            var query = @"SELECT Id, Ano, Titulo, Genero, Autor 
                          FROM Livro 
                          WHERE 1 = 1";

            if (livro.Ano > 0)
            {
                query += " AND Ano = @Ano";
                parameter.Add("@Ano", livro.Ano);
            }

            if (!string.IsNullOrEmpty(livro.Titulo))
            {
                query += " Titulo like '%' +  @Titulo + '%'";
                parameter.Add("@Titulo", livro.Titulo);
            }

            if (!string.IsNullOrEmpty(livro.Genero))
            {
                query += " AND Genero LIKE '%' +  @Genero + '%'";
                parameter.Add("@Genero", livro.Genero);
            }

            if (!string.IsNullOrEmpty(livro.Autor))
            {
                query += " AND Autor LIKE '%' +  @Autor + '%'";
                parameter.Add("@Autor", livro.Autor);
            }

            if (livro.Id > 0)
            {
                query += " AND Id = @Id ";
                parameter.Add("@Id", livro.Id);
            }

            return await connection.QueryAsync<Livro>(query, parameter);
        }

        public async Task InsereLivro(Livro livro)
        {
            var query = @"INSERT INTO Livro 
                          VALUES(@Ano, @Titulo, @Genero, @Autor)";

            await connection.ExecuteAsync(query, livro);
        }

        public async Task<bool> ValidaLivroExistenteAsync(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);

            var query = @"SELECT COUNT(1) 
                          FROM Livro 
                          WHERE Id = @Id";

            return await connection.QueryFirstOrDefaultAsync<bool>(query, parameter);
        }
    }
}
