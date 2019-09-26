using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Services
{
    public interface IPedidoService
    {
        /// <summary>
        /// Obtem todos os pedidos ativos e não pagos.
        /// </summary>
        /// <param name="idUsuario">Identificador do usuário.</param>
        /// <returns></returns>
        Task<IEnumerable<Pedido>> ObtemPedidosCarrinho(int idUsuario);

        /// <summary>
        /// Realiza o pedido de um livro.
        /// </summary>
        /// <param name="idLivro"></param>
        /// <returns>Retorna o Id do pedido.</returns>
        Task<int> PedidoAsync(int idLivro);

        /// <summary>
        /// Busca informações sobre a entrega de determinado pedido
        /// </summary>
        /// <param name="idPedido"></param>
        /// <returns>Objeto com dados do pedido.</returns>
        Task<PedidoDto> DadosEntregaPedido(int idPedido);

    }
}
