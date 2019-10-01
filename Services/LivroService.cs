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
        private readonly IComentarioRepository comentarioRepository;

        public LivroService(ILivroRepository livroRepository, IComentarioRepository comentarioRepository)
        {
            this.livroRepository = livroRepository ?? throw new ArgumentNullException(nameof(livroRepository));
            this.comentarioRepository = comentarioRepository 
                ?? throw new ArgumentNullException(nameof(comentarioRepository));
        }

        public async Task CadastraAsync(Livro livro)
        {
            await livroRepository.InsereLivro(livro);
        }

        public async Task ComentaAsync(string mensagem, int idLivro)
        {
            if (string.IsNullOrEmpty(mensagem))
                throw new ArgumentNullException(nameof(mensagem));

            if (!await ValidaLivroExistenteAsync(idLivro))
                throw new ArgumentNullException(nameof(idLivro));//

            var comentario = new Comentario
            {
                IdLivro = idLivro,
                Mensagem = mensagem
            };

            await comentarioRepository.InsereComentario(comentario);
        }

        public async Task<IEnumerable<Livro>> PesquisaAsync(Livro livro)
        {
            return await livroRepository.BuscaLivro(livro);
        }

        public async Task<bool> ValidaLivroExistenteAsync(int idLivro)
        {
            return await livroRepository.ValidaLivroExistenteAsync(idLivro);
        }
    }
}
