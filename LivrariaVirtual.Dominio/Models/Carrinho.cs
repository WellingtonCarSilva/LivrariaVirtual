using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public bool Ativo { get; set; }
        public Guid? IdTransacao { get; set; }
    }
}
