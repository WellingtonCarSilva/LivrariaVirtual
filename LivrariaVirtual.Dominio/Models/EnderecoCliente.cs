﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaVirtual.Dominio.Models
{
    public class EnderecoCliente
    {
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int IdCliente { get; set; }
    }
}
