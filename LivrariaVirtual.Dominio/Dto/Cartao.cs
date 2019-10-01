using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Dto
{
    public class Cartao
    {
        public int NumeroCartao { get; set; }
        public int CodigoSeguranca { get; set; }
        public int QuantidadeParcela { get; set; }
    }
}
