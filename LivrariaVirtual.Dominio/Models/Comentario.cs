using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }
        public int IdLivro { get; set; }
    }
}
