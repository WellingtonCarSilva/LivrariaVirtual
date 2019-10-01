using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Repositories;
using LivrariaVirtual.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoRepository carrinhoRepository;
        private readonly ILivroService livroService;

        public CarrinhoService(ICarrinhoRepository carrinhoRepository, ILivroService livroService)
        {
            this.carrinhoRepository = carrinhoRepository ?? throw new ArgumentNullException(nameof(carrinhoRepository));
            this.livroService = livroService ?? throw new ArgumentNullException(nameof(livroService));
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

            await carrinhoRepository.AdicionaItemCarrinhoUsuarioAsync(idUsuario, 1, idLivro);

        }

        public async Task<IEnumerable<ItemCarrinhoDto>> ObtemItensCarrinhoAsync(int idUsuario)
        {
            var carrinho = await carrinhoRepository.BuscaItensCarrinhoAsync(idUsuario);

            if (carrinho.Any())
            {
                foreach (var item in carrinho)
                {
                    await livroService.PesquisaAsync(new Livro { Id = item.Id });
                }
            }
            return null;
        }
    }
}
