using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dto
{
    public class PedidoGetResult
    {
        public int Id { get; set; }
        public string Livro { get; set; }
        public DateTimeOffset DataPedido { get; set; }
        public DateTimeOffset PrevisaoEntrega { get; set; }
        public string Status { get; set; }
    }
}
