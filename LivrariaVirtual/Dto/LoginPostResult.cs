using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaVirtual.Dto
{
    public class LoginPostResult
    {
        public int IdUsuario { get; set; }
        public string Token { get; set; }
    }
}
