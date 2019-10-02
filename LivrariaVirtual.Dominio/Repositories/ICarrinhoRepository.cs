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
        Task<IEnumerable<ItemCarrinho>> BuscaItensCarrinhoAsync(int IdCarrinho);
        Task AdicionaItemCarrinhoUsuarioAsync(int idCarrinho, int idLivro);
        Task CriarCarrinhoUsuario(Carrinho carrinho);
        Task FinalizaCarrinho(int idCarrinho);
    }
}
