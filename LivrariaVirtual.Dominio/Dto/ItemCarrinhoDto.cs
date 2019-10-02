using LivrariaVirtual.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Dto
{
    public class ItemCarrinhoDto
    {
        public int IdCarrinho { get; set; }
        public List<Livro> Livros { get; set; }
        public double ValorTotal { get; set; }
    }
}
