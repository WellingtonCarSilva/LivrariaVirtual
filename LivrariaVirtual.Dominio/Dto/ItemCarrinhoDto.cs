using LivrariaVirtual.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Dto
{
    public class ItemCarrinhoDto
    {
        public int Id { get; set; }
        public int IdCarrinho { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}
