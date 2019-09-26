using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dto
{
    public class LivroGetResult
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
    }
}
