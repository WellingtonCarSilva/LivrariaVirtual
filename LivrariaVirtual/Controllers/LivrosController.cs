using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Services;
using LivrariaVirtual.Dto;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService livroService;
        private readonly IMapper mapper;

        public LivrosController(ILivroService livroService, IMapper mapper)
        {
            this.livroService = livroService ?? throw new ArgumentNullException(nameof(livroService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Realiza o cadastro de um livro.
        /// </summary>
        /// <param name="livroPost"></param>
        /// <returns></returns>
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [HttpPost]
        public async Task<ActionResult> CadastroAsync([FromBody]LivroDto livroPost)
        {
            var livro = mapper.Map<Livro>(livroPost);

            await livroService.CadastraAsync(livro);

            return Ok();
        }

        /// <summary>
        /// Cadastra um comentário para determinado livro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="comentario"></param>
        /// <returns></returns>
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [HttpPost("{id}/Comentario")]
        public async Task<ActionResult> ComentarioAsync([FromRoute] int id, [FromBody]string comentario)
        {
            await livroService.ComentaAsync(comentario, id);

            return Ok();
        }

        /// <summary>
        /// Pesquisa por livros de acordo com os parâmetros preenchidos.
        /// </summary>
        /// <param name="livroPost"></param>
        /// <returns> Lista com todos os livros que correspondem com os critérios enviados.</returns>
        [ProducesResponseType(typeof(IEnumerable<LivroGetResult>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet]
        public async Task<ActionResult> PesquisaAsync([FromQuery]LivroDto livroDto)
        {
            var livro = mapper.Map<Livro>(livroDto);

            var livros = await livroService.PesquisaAsync(livro);

            var livroGetResult = mapper.Map<IEnumerable<LivroGetResult>>(livros);

            if (!livroGetResult.Any())
                return NotFound();

            return Ok(livroGetResult);
        }

        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPost("{idLivro}/Carrinho")]
        public async Task<ActionResult> AdicionarAoCarrinhoAsync([FromRoute] int idLivro, [FromBody] int idUsuario)
        {
            return Ok();
        }
    }
}