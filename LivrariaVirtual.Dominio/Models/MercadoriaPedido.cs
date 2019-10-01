using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class MercadoriaPedido
    {
        public int Id { get; set; }
        public int IdLivro { get; set; }
        public int IdPedido { get; set; }
    }
}
