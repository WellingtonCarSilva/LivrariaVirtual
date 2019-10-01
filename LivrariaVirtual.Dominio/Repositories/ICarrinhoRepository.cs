using LivrariaVirtual.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Repositories
{
    public interface ICarrinhoRepository
    {
        Task<Carrinho> BuscaCarrinhoAtivoPorUsuarioAsync(int idUsuario);
        Task<IEnumerable<ItemCarrinho>> BuscaItensCarrinhoAsync(int idUsuario);
        Task AdicionaItemCarrinhoUsuarioAsync(int idUsuario, int idCarrinho, int idLivro);
        Task CriarCarrinhoUsuario(Carrinho carrinho);
    }
}
