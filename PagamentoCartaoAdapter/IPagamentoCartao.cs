using PagamentoCartaoAdapter.Dto;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoCartaoAdapter
{
    public interface IPagamentoCartao
    {
        [Put("/Transacoes")]
        Task<Guid> RealizaPagamento([Body]TransacaoPut transacaoPut);
    }
}
