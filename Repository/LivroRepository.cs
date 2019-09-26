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

        public async Task<IEnumerable<Livro>> BuscaLivroPorAno(int ano)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Ano", ano);

            var query = @"SELECT Id, Ano, Titulo, Genero, Autor 
                          FROM Livro 
                          WHERE Ano = @Ano";

            return await connection.QueryAsync<Livro>(query, parameter);
        }

        public async Task<IEnumerable<Livro>> BuscaLivroPorAutor(string autor)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Autor", autor);

            var query = @"SELECT Id, Ano, Titulo, Genero, Autor 
                          FROM Livro 
                          WHERE Autor LIKE '%' +  @Autor + '%'";

            return await connection.QueryAsync<Livro>(query, parameter);
        }

        public async Task<IEnumerable<Livro>> BuscaLivroPorGenero(string genero)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Genero", genero);

            var query = @"SELECT Id, Ano, Titulo, Genero, Autor 
                          FROM Livro 
                          WHERE Genero LIKE '%' +  @Genero + '%'";

            return await connection.QueryAsync<Livro>(query, parameter);
        }

        public async Task<IEnumerable<Livro>> BuscaLivroPorTitulo(string titulo)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Titulo", titulo);

            var query = @"SELECT Id, Ano, Titulo, Genero, Autor 
                          FROM Livro 
                          WHERE Titulo like '%' +  @Titulo + '%'";

            return await connection.QueryAsync<Livro>(query, parameter);
        }

        public async Task InsereLivro(Livro livro)
        {
            var query = @"INSERT INTO Livro 
                          VALUES(@Ano, @Titulo, @Genero, @Autor)";

            await connection.ExecuteAsync(query, livro);
        }

        public async Task<bool> ValidaDisponibilidadeAsync(int id)
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
