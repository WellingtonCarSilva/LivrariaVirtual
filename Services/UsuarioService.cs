using LivrariaVirtual.Dominio.Adapters;
using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IAutenticacaoApiAdapter autenticacao;

        public UsuarioService(IAutenticacaoApiAdapter autenticacao)
        {
            this.autenticacao = autenticacao ?? throw new ArgumentNullException(nameof(autenticacao));
        }

        public async Task<UsusarioDto> ValidaUsuarioAsync(string cpf, string senha)
        {
            return await autenticacao.Autentica(cpf, senha);
        }
    }
}
