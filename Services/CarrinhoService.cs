using LivrariaVirtual.Dominio.Adapters;
using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Repositories;
using LivrariaVirtual.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoRepository carrinhoRepository;
        private readonly ILivroService livroService;
        private readonly IPagamentoCartaoApiAdapter pagamentoAdapter;
        private readonly IAuditoriaApiAdapter auditoriaApiAdapter;

        public CarrinhoService(ICarrinhoRepository carrinhoRepository, ILivroService livroService, 
            IPagamentoCartaoApiAdapter pagamentoAdapter, IAuditoriaApiAdapter auditoriaApiAdapter)
        {
            this.carrinhoRepository = carrinhoRepository ?? throw new ArgumentNullException(nameof(carrinhoRepository));
            this.livroService = livroService ?? throw new ArgumentNullException(nameof(livroService));
            this.pagamentoAdapter = pagamentoAdapter ?? throw new ArgumentNullException(nameof(pagamentoAdapter));
            this.auditoriaApiAdapter = auditoriaApiAdapter ?? throw new ArgumentNullException(nameof(auditoriaApiAdapter));
        }

        public async Task InsereItemCarrinhoAsync(int idLivro, int idUsuario)
        {
            var carrinho = await carrinhoRepository.BuscaCarrinhoAtivoPorUsuarioAsync(idUsuario);

            if (carrinho == null)
            {
                carrinho = new Carrinho
                {
                    IdUsuario = idUsuario,
                    Ativo = true
                };

                await carrinhoRepository.CriarCarrinhoUsuario(carrinho);
            }

            await carrinhoRepository.AdicionaItemCarrinhoUsuarioAsync(carrinho.Id, idLivro);
        }

        public async Task<ItemCarrinhoDto> ObtemItensCarrinhoAsync(int idUsuario)
        {
            var carrinho = await carrinhoRepository.BuscaCarrinhoAtivoPorUsuarioAsync(idUsuario);

            if (carrinho == null)
                return null;

            return await ObtemCarrinhoAsync(carrinho.Id);
        }

        public async Task RealizaPagamentoAsync(Pagamento pagamento)
        {
            Cartao cartao = new Cartao
            {
                CodigoSeguranca = pagamento.CodigoSeguranca,
                NumeroCartao = pagamento.NumeroCartao,
                QuantidadeParcela = pagamento.QuantidadeParcela
            };

            var itensCarinho = await ObtemCarrinhoAsync(pagamento.IdCarrinho);
            var idTransacao = await pagamentoAdapter.RealizaPagamentoAsync(cartao, itensCarinho.ValorTotal);

            await FinalizaCarrinho(pagamento.IdCarrinho, idTransacao);
            await auditoriaApiAdapter.AuditaSucessoTransacao("Pagamento", "1", DateTime.Now);
        }

        private async Task<ItemCarrinhoDto> ObtemCarrinhoAsync(int idCarrinho)
        {
            var itemCarrinho = await carrinhoRepository.BuscaItensCarrinhoAsync(idCarrinho);

            var itensCarrinho = new ItemCarrinhoDto
            {
                Livros = new List<Livro>()
            };

            foreach (var item in itemCarrinho)
            {
                var livro = await livroService.PesquisaAsync(new Livro { Id = item.IdLivro });
                itensCarrinho.Livros.Add(livro.FirstOrDefault());
                itensCarrinho.IdCarrinho = item.IdCarrinho;
                itensCarrinho.ValorTotal += livro.FirstOrDefault()?.Valor ?? 0.0;
            }

            return itensCarrinho;
        }

        private async Task FinalizaCarrinho(int idCarrinho, Guid idTransacao)
        {
            await carrinhoRepository.FinalizaCarrinho(idCarrinho, idTransacao);
        }
    }
}
