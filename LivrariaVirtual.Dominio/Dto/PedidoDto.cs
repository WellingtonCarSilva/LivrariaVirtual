using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Dto
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public string Livro { get; set; }
        public DateTimeOffset DataPedido { get; set; }
        public DateTimeOffset PrevisaoEntrega { get; set; }
        public string Status { get; set; }
    }
}
