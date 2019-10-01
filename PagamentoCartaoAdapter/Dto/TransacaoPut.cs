using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoCartaoAdapter.Dto
{
    public class TransacaoPut
    {
        public int NumeroCartao { get; set; }
        public int CodigoSeguranca { get; set; }
        public double Valor { get; set; }
        public int QuantidadeParcela { get; set; }
    }
}
