using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Repositories;
using LivrariaVirtual.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository ?? 
                throw new ArgumentNullException(nameof(pedidoRepository));
        }

        public Task<PedidoDto> DadosEntregaPedido(int idPedido)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ObtemPedidosCarrinho(int idUsuario)
        {
            throw new NotImplementedException();
        }

        //public Task InserePedidoAsync(int idLivro)
        //{

        //    var pedido = new Pedido
        //    {
        //        DataPedido = DateTime.Now,
        //        Status = StatusPedido.Ativo
        //    };

        //    pedidoRepository.InserePedido(pedido);
        //}
    }
}
