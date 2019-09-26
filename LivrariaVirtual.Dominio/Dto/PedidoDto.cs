using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Dto
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public string Livro { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime PrevisaoEntrega { get; set; }
        public string Status { get; set; }
    }
}
