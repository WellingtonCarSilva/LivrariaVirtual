using LivrariaVirtual.Dominio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Repositories
{
    public interface ILivroRepository
    {
        Task InsereLivro(Livro livro);
        Task<IEnumerable<Livro>> BuscaLivroPorTitulo(string titulo);
        Task<IEnumerable<Livro>> BuscaLivroPorAno(int ano);
        Task<IEnumerable<Livro>> BuscaLivroPorGenero(string genero);
        Task<IEnumerable<Livro>> BuscaLivroPorAutor(string autor);
        Task<bool> ValidaDisponibilidadeAsync(int id);
    }
}
