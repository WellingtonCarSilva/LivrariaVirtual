using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly IDbConnection connection;

        public CarrinhoRepository(IDbConnection connection)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));

        }
        public async Task AdicionaItemCarrinhoUsuarioAsync(int idCarrinho, int idLivro)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@idCarrinho", idCarrinho);
            parameter.Add("@idLivro", idLivro);

            var query = @"insert into ItemCarrinho
                          values(@idCarrinho, @idLivro)";

            await connection.ExecuteAsync(query, parameter);
        }

        public async Task<Carrinho> BuscaCarrinhoAtivoPorUsuarioAsync(int idUsuario)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@IdUsuario", idUsuario);

            var query = @"SELECT Id, IdUsuario, Ativo
                          FROM Carrinho 
                          WHERE IdUsuario = @IdUsuario";

            return await connection.QueryFirstAsync<Carrinho>(query, parameter);
        }

        public async Task<IEnumerable<ItemCarrinho>> BuscaItensCarrinhoAsync(int idCarrinho)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@IdCarrinho", idCarrinho);

            var query = @"SELECT Id, IdCarrinho, IdLivro
                          FROM ItemCarrinho 
                          WHERE idCarrinho = @IdCarrinho";

            return await connection.QueryAsync<ItemCarrinho>(query, parameter);
        }

        public async Task CriarCarrinhoUsuario(Carrinho carrinho)
        {
            var query = @"insert into carrinho
                          values(@IdUsuario, @Ativo)";

            await connection.ExecuteAsync(query, carrinho);
        }

        public async Task FinalizaCarrinho(int idCarrinho)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Ativo", false);
            parameter.Add("@IdCarrinho", idCarrinho);

            var query = @"update carrinho
                          set Ativo = @Ativo
                          where IdCarrinho @IdCarrinho";

            await connection.ExecuteAsync(query, parameter);
        }
    }
}
