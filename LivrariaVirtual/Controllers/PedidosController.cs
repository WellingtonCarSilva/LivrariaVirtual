using AutoMapper;
using LivrariaVirtual.Dominio.Services;
using LivrariaVirtual.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        //private readonly IPedidoService pedidoService;
        //private readonly ILivroService livroService;
        //private readonly IMapper mapper;

        //public PedidosController(IPedidoService pedidoService, ILivroService livroService, IMapper mapper)
        //{
        //    this.pedidoService = pedidoService ?? throw new ArgumentNullException(nameof(pedidoService));
        //    this.livroService = livroService ?? throw new ArgumentNullException(nameof(livroService));
        //    this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        //}

        ///// <summary>
        ///// Obtem os pedidos ativos e não pagos do usuário.
        ///// </summary>
        ///// <param name="idUsuario"></param>
        ///// <returns></returns>
        //[ProducesResponseType(typeof(IEnumerable<PedidoGetResult>), 200)]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(500)]
        //[HttpGet]
        //public async Task<IActionResult> ObetemDadosCarrinhoAsync([FromHeader]int idUsuario)
        //{
        //    var pedidos = await pedidoService.ObtemPedidosCarrinho(idUsuario);

        //    if(!pedidos.Any())
        //        return NotFound();

        //    var carrinho = mapper.Map<IEnumerable<PedidoGetResult>>(pedidos);

        //    return Ok(carrinho);
        //}

        

        ///// <summary>
        ///// Obtem detalhes da entrega do pedido
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[ProducesResponseType(typeof(PedidoGetResult), 200)]
        //[ProducesResponseType(typeof(string), 400)]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(500)]
        //[HttpGet("{id}/Entrega")]
        //public async Task<ActionResult> DadosEntregaPedido([FromRoute] int id)
        //{
        //    var pedido = await pedidoService.DadosEntregaPedido(id);

        //    if (pedido == null)
        //        return NotFound();

        //    var pedidoResult = mapper.Map<PedidoGetResult>(pedido);

        //    return Ok(pedidoResult);
        //}
    }
}