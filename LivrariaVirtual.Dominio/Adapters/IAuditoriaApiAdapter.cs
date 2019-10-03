using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dominio.Adapters
{
    public interface IAuditoriaApiAdapter
    {
        Task AuditaSucessoTransacao(string acao, string usuario, DateTime data);
    }
}
