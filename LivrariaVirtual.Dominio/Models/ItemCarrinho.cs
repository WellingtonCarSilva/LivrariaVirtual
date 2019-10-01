using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class ItemCarrinho
    {
        public int Id { get; set; }
        public int IdCarrinho { get; set; }
        public int IdLivro { get; set; }
    }
}
