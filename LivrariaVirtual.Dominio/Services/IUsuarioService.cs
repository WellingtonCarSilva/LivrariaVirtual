using LivrariaVirtual.Dominio.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Services
{
    public interface IUsuarioService
    {
        Task<UsusarioDto> ValidaUsuarioAsync(string cpf, string senha);
    }
}
