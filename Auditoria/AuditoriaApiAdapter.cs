using AuditoriaAdapter.Dto;
using LivrariaVirtual.Dominio.Adapters;
using System;
using System.Threading.Tasks;

namespace AuditoriaAdapter
{
    public class AuditoriaApiAdapter : IAuditoriaApiAdapter
    {
        private readonly IAuditoria auditoria;

        public AuditoriaApiAdapter(IAuditoria auditoria)
        {
            this.auditoria = auditoria ?? throw new ArgumentNullException(nameof(auditoria));
        }

        public async Task AuditaSucessoTransacao(string acao, string usuario, DateTime data)
        {
            var auditoriaPost = new AuditoriaPost
            {
                Sucesso = true,
                Acao = acao,
                Data = data,
                Usuario = usuario
            };

            await auditoria.Autenticacao(auditoriaPost);
        }
    }
}
