using LivrariaVirtual.Dominio.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Adapters
{
    public interface IAutenticacaoApiAdapter
    {
        Task<UsusarioDto> Autentica(string cpf, string senha);
    }
}
