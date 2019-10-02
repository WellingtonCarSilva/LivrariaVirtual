using AutenticacaoAdapter.Dto;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutenticacaoAdapter
{
    public interface IAutenticacao
    {
        [Post("/users/authenticate")]
        Task<UserPostResult> Autenticacao([Body]UserPost userPost);
    }
}
