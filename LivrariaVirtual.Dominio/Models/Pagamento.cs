using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class Pagamento
    {
        public int IdCarrinho { get; set; }
        public int NumeroCartao { get; set; }
        public int CodigoSeguranca { get; set; }
        public int QuantidadeParcela { get; set; }
    }
}
