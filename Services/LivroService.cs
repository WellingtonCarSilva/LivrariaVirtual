using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class LivroService : ILivroService
    {
        public Task CadastroAsync(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task ComentarioAsync(string comentario, int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> PesquisaPorAnoAsync(int ano)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> PesquisaPorAutorAsync(string autor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> PesquisaPorGeneroAsync(string genero)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> PesquisaPorTituloAsync(string titulo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidaDisponibilidadeAsync(int idLivro)
        {
            throw new NotImplementedException();
        }
    }
}
