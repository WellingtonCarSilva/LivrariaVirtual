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
        Task CadastroAsync(Livro livro);

        /// <summary>
        /// Realiza uma pesquisa na base de livros de acordo com o título.
        /// </summary>
        /// <param name="titulo"> título do livro para pesquisa. </param>
        /// <returns>Retorna uma lista com todos os livros encontrados para os filtros realizados. </returns>
        Task<IEnumerable<Livro>> PesquisaPorTituloAsync(string titulo);

        /// <summary>
        /// Realiza uma pesquisa na base de livros de acordo com o genero.
        /// </summary>
        /// <param name="genero"> genero do livro para pesquisa. </param>
        /// <returns>Retorna uma lista com todos os livros encontrados para os filtros realizados. </returns>
        Task<IEnumerable<Livro>> PesquisaPorGeneroAsync(string genero);

        /// <summary>
        /// Realiza uma pesquisa na base de livros de acordo com ano de publicação.
        /// </summary>
        /// <param name="livro"> Ano da publicação enviadas para pesquisa. </param>
        /// <returns>Retorna uma lista com todos os livros encontrados para os filtros realizados. </returns>
        Task<IEnumerable<Livro>> PesquisaPorAnoAsync(int ano);

        /// <summary>
        /// Realiza uma pesquisa na base de livros de acordo com o nome do autor.
        /// </summary>
        /// <param name="autor"> Nome do autor utilizado para pesquisa. </param>
        /// <returns>Retorna uma lista com todos os livros encontrados para os filtros realizados. </returns>
        Task<IEnumerable<Livro>> PesquisaPorAutorAsync(string autor);

        /// <summary>
        /// Realiza um comentário para o livro em questão
        /// </summary>
        /// <param name="comentario"></param>
        /// <param name="idLivro"></param>
        /// <returns></returns>
        Task ComentarioAsync(string comentario, int idLivro);

        /// <summary>
        /// Verifica disponibilidade do livro.
        /// </summary>
        /// <param name="idLivro"></param>
        /// <returns>Retorna um booleano indicando se está disponível ou não.</returns>
        Task<bool> ValidaDisponibilidadeAsync(int idLivro);
    }
}
