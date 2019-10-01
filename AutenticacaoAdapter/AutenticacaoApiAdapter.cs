using AutenticacaoAdapter.Dto;
using LivrariaVirtual.Dominio.Adapters;
using LivrariaVirtual.Dominio.Dto;
using System;
using System.Threading.Tasks;

namespace AutenticacaoAdapter
{
    public class AutenticacaoApiAdapter : IAutenticacaoApiAdapter
    {
        private readonly IAutenticacao autenticacao;

        public AutenticacaoApiAdapter(IAutenticacao autenticacao)
        {
            this.autenticacao = autenticacao ?? throw new ArgumentNullException(nameof(autenticacao));
        }

        public async Task<UsusarioDto> Autentica(string cpf, string senha)
        {
            var usuarioPost = new UserPost
            {
                CPF = cpf,
                Password = senha
            };

            await autenticacao.Autenticacao(usuarioPost);

            return null;
        }
    }
}
