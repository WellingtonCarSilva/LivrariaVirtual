using System;
using System.Threading.Tasks;
using LivrariaVirtual.Dominio.Services;
using LivrariaVirtual.Dto;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ICarrinhoService carrinhoService;
        private readonly ILivroService livroService;
        private readonly IUsuarioService usuarioService;

        public UsuariosController(ICarrinhoService carrinhoService, ILivroService livroService,
            IUsuarioService usuarioService)
        {
            this.carrinhoService = carrinhoService ?? throw new ArgumentNullException(nameof(carrinhoService));
            this.livroService = livroService ?? throw new ArgumentNullException(nameof(livroService));
            this.usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
        }

        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(500)]
        [HttpGet("{idUsuario}/Carrinho")]
        public async Task<IActionResult> ObtemCarrinho([FromRoute]int idUsuario)
        {
            await carrinhoService.ObtemItensCarrinhoAsync(idUsuario);

            return Ok();
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
        public async Task<ActionResult> AdicionaItemCarrinhoAsync([FromRoute]int idUsuario, [FromBody] int idLivro, [FromHeader] string token)
        {
            if (!await livroService.ValidaLivroExistenteAsync(idLivro))
                return BadRequest("Livro indisponível.");

            await carrinhoService.InsereItemCarrinhoAsync(idLivro, idUsuario);

            return Ok();
        }

        [ProducesResponseType(typeof(LoginPostResult), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(500)]
        [HttpGet("Autenticacao")]
        public async Task<ActionResult> ValidaUsuarioAsync([FromRoute]LoginPost loginPost)
        {
            return Ok(await usuarioService.ValidaUsuarioAsync(loginPost.Cpf, loginPost.Senha));
        }
    }
}