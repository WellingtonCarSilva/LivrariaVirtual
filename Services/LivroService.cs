using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Repositories;
using LivrariaVirtual.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            this.livroRepository = livroRepository ?? throw new ArgumentNullException(nameof(livroRepository));
        }
        public async Task CadastroAsync(Livro livro)
        {
            await livroRepository.InsereLivro(livro);
        }

        public Task ComentarioAsync(string comentario, int idLivro)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Livro>> PesquisaPorAnoAsync(int ano)
        {
            return await livroRepository.BuscaLivroPorAno(ano);
        }

        public async Task<IEnumerable<Livro>> PesquisaPorAutorAsync(string autor)
        {
            return await livroRepository.BuscaLivroPorAutor(autor);
        }

        public async Task<IEnumerable<Livro>> PesquisaPorGeneroAsync(string genero)
        {
            return await livroRepository.BuscaLivroPorGenero(genero);
        }

        public async Task<IEnumerable<Livro>> PesquisaPorTituloAsync(string titulo)
        {
            return await livroRepository.BuscaLivroPorTitulo(titulo);
        }

        public async Task<bool> ValidaDisponibilidadeAsync(int idLivro)
        {
            return await livroRepository.ValidaDisponibilidadeAsync(idLivro);
        }
    }
}
