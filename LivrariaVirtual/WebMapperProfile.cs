using AutoMapper;
using LivrariaVirtual.Dominio.Dto;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaVirtual
{
    public class WebMapperProfile : Profile
    {
        public WebMapperProfile()
        {
            CreateMap<PedidoGetResult, PedidoDto>();
            CreateMap<Livro, LivroDto>();
            CreateMap<LivroGetResult, Livro>();
            CreateMap<Livro, LivroGetResult>();
            CreateMap<LivroDto, Livro>();
        }
    }
}
