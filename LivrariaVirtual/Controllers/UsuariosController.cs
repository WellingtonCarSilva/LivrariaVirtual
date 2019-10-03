using System;
using System.Threading.Tasks;
using AutoMapper;
using LivrariaVirtual.Dominio.Models;
using LivrariaVirtual.Dominio.Services;
using LivrariaVirtual.Dto;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace LivrariaVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ICarrinhoService carrinhoService;
        private readonly ILivroService livroService;
        private readonly IUsuarioService usuarioService;
        private readonly IMapper mapper;


        public UsuariosController(ICarrinhoService carrinhoService, ILivroService livroService,
            IUsuarioService usuarioService, IMapper mapper)
        {
            this.carrinhoService = carrinhoService ?? throw new ArgumentNullException(nameof(carrinhoService));
            this.livroService = livroService ?? throw new ArgumentNullException(nameof(livroService));
            this.usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(500)]
        [HttpGet("{idUsuario}/Carrinho")]
        public async Task<IActionResult> ObtemCarrinho([FromRoute]int idUsuario)
        {
            var retorno = await carrinhoService.ObtemItensCarrinhoAsync(idUsuario);

            if (retorno == null)
                return NotFound();

            return Ok(retorno);
        }

        /// <summary>
        /// Realiza o pedido de um determinado livro.
        /// </summary>
        /// <param name="idLivro"></param>
        /// <returns></returns>
        [ProducesResponseType(201)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(500)]
        [HttpPost("{idUsuario}/ItemCarrinho")]
        public async Task<ActionResult> AdicionaItemCarrinhoAsync([FromRoute]int idUsuario, [FromBody] ItemCarrinhoPost itemCarrinhoPost, [FromHeader] string token)
        {
            if (!await livroService.ValidaLivroExistenteAsync(itemCarrinhoPost.IdLivro))
                return BadRequest("Livro indisponível.");

            await carrinhoService.InsereItemCarrinhoAsync(itemCarrinhoPost.IdLivro, idUsuario);

            return Ok();
        }

        [ProducesResponseType(typeof(LoginPostResult), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(500)]
        [HttpGet("Autenticacao")]
        public async Task<ActionResult> ValidaUsuarioAsync([FromRoute]LoginPost loginPost)
        {
            try
            {
                return Ok(await usuarioService.ValidaUsuarioAsync(loginPost.Cpf, loginPost.Senha));
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                    return NotFound();

                return BadRequest("Falha ao validar usuário.");
            }
        }

        [HttpPut("Pagar")]
        public async Task<IActionResult> PagarPedido([FromBody]PagamentoPost pagamentoPost)
        {
            var pagamento = mapper.Map<Pagamento>(pagamentoPost);
            await carrinhoService.RealizaPagamentoAsync(pagamento);
            return Ok();
        }
    }
}