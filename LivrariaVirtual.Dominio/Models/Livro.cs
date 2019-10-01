using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public double Valor { get; set; }
    }
}
