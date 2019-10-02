using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dto
{
    public class PagamentoPost
    {
        public int IdCarrinho { get; set; }
        public int NumeroCartao { get; set; }
        public int CodigoSeguranca { get; set; }
        public int QuantidadeParcela { get; set; }
    }
}
