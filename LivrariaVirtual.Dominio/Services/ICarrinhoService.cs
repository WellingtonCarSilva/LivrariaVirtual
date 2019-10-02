using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
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
        Task<ItemCarrinhoDto> ObtemItensCarrinhoAsync(int idUsuario);

        Task RealizaPagamentoAsync(Pagamento pagamento);
    }
}
