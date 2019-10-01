using System;
using System.Collections.Generic;
using System.Text;

namespace AutenticacaoAdapter.Dto
{
    public class UserPost
    {
        public int IDUser { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string CPF { get; set; }

        public string Password { get; set; }
    }
}
