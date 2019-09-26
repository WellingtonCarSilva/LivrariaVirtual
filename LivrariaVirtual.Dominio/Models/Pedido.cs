using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataPedido { get; set; }
        public StatusPedido Status { get; set; }
        public int IdCliente { get; set; }
    }
}
