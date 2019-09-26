using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class PedidoService : IPedidoService
    {
        public Task<PedidoDto> DadosEntregaPedido(int idPedido)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ObtemPedidosCarrinho(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> PedidoAsync(int idLivro)
        {
            throw new NotImplementedException();
        }
    }
}
