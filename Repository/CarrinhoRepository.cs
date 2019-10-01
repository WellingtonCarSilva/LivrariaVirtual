using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        public Task AdicionaItemCarrinhoUsuarioAsync(int idUsuario, int idCarrinho, int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<Carrinho> BuscaCarrinhoAtivoPorUsuarioAsync(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemCarrinho>> BuscaItensCarrinhoAsync(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task CriarCarrinhoUsuario(Carrinho carrinho)
        {
            throw new NotImplementedException();
        }
    }
}
