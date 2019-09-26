using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public IEnumerable<int> IdPedido { get; set; }
        public int IdEnderecoCliente { get; set; }
        public DateTimeOffset DataEntrega { get; set; }
        public bool Realizada { get; set; }
    }
}
