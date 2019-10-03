using System;
using System.Collections.Generic;
using System.Text;

namespace AuditoriaAdapter.Dto
{
    public class AuditoriaPost
    {
        public string Acao { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public bool Sucesso { get; set; }
    }
}
