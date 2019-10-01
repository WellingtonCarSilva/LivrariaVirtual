using LivrariaVirtual.Dominio.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Services
{
    public interface ICarrinhoService
    {
        /// <summary>
        /// Realiza o pedido de um livro.
        /// </summary>
        /// <param name="idLivro"></param>
        /// <param name="idUsuario"></param>
        /// <returns>Retorna o Id do pedido.</returns>
        Task InsereItemCarrinhoAsync(int idLivro, int idUsuario);

        /// <summary>
        /// Realiza o pedido de um livro.
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Retorna o Id do pedido.</returns>
        Task<IEnumerable<ItemCarrinhoDto>> ObtemItensCarrinhoAsync(int idUsuario);
    }
}
