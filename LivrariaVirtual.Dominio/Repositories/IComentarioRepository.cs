using LivrariaVirtual.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Repositories
{
    public interface IComentarioRepository
    {
        /// <summary>
        /// Insere um comentário para determinado livro.
        /// </summary>
        /// <param name="comentario"></param>
        /// <returns></returns>
        Task InsereComentario(Comentario comentario);
    }
}
