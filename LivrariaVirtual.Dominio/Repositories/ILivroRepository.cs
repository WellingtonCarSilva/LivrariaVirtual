using LivrariaVirtual.Dominio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Repositories
{
    public interface ILivroRepository
    {
        Task InsereLivro(Livro livro);
        Task<IEnumerable<Livro>> BuscaLivro(Livro livro);
        Task<bool> ValidaLivroExistenteAsync(int id);
    }
}
