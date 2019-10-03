using AuditoriaAdapter.Dto;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriaAdapter
{
    public interface IAuditoria
    {
        [Post("/Auditoria")]
        Task Autenticacao([Body] AuditoriaPost auditoria);
    }
}
