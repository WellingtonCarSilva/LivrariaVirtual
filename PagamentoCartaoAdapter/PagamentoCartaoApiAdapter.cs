using LivrariaVirtual.Dominio.Adapters;
using LivrariaVirtual.Dominio.Dto;
using PagamentoCartaoAdapter.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoCartaoAdapter
{
    public class PagamentoCartaoApiAdapter : IPagamentoCartaoApiAdapter
    {
        private readonly IPagamentoCartao pagamentoCartao;

        public PagamentoCartaoApiAdapter(IPagamentoCartao pagamentoCartao)
        {
            this.pagamentoCartao = pagamentoCartao ?? throw new ArgumentNullException(nameof(pagamentoCartao));
        }

        public async Task RealizaPagamentoAsync(Cartao cartao, double valor)
        {
            var transacao = new TransacaoPut
            {
                CodigoSeguranca = cartao.CodigoSeguranca,
                NumeroCartao = cartao.NumeroCartao,
                QuantidadeParcela = cartao.QuantidadeParcela,
                Valor = valor
            };

            await pagamentoCartao.RealizaPagamento(transacao);
        }
    }
}
