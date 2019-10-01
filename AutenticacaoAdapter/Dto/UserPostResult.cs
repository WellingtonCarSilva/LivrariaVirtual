using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutenticacaoAdapter.Dto
{
    public class UserPostResult
    {
        public int Id { get; set; }

        [JsonProperty("Username")]
        public string Nome { get; set; }

        public string Token { get; set; }
    }
}
