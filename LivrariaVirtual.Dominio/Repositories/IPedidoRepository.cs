using LivrariaVirtual.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Repositories
{
    public interface IPedidoRepository
    {
        /// <summary>
        /// Insere um registro de pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        Task InserePedido(Pedido pedido);
    }
}
