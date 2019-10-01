using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Services
{
    public interface ILivroService
    {
        /// <summary>
        /// Realiza o cadastro de livros
        /// </summary>
        /// <param name="livro"> Objeto contendo as informações do livro.</param>
        Task CadastraAsync(Livro livro);

        /// <summary>
        /// Realiza uma pesquisa na base de livros de acordo com o nome do autor.
        /// </summary>
        /// <param name="livro"> Objeto com dados para pesquisa </param>
        /// <returns>Retorna uma lista com todos os livros encontrados para os filtros realizados. </returns>
        Task<IEnumerable<Livro>> PesquisaAsync(Livro livro);

        /// <summary>
        /// Realiza um comentário para o livro em questão
        /// </summary>
        /// <param name="mensagem"></param>
        /// <param name="idLivro"></param>
        /// <returns></returns>
        Task ComentaAsync(string mensagem, int idLivro);

        /// <summary>
        /// Verifica disponibilidade do livro.
        /// </summary>
        /// <param name="idLivro"></param>
        /// <returns>Retorna um booleano indicando se está disponível ou não.</returns>
        Task<bool> ValidaLivroExistenteAsync(int idLivro);
    }
}
