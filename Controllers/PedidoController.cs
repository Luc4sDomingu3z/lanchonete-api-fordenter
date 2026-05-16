using lanchonete_api.Interfaces.Repositories;
using lanchonete_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace lanchonete_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PedidoController(IPedidoRepository pedidoRepository) : Controller
{
    private readonly IPedidoRepository _pedidoRepository = pedidoRepository;

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pedido>))]
    public IActionResult GetPedidos()
    {
        var pedidos = _pedidoRepository.GetPedidos();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(pedidos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(Pedido))]
    public async Task<IActionResult> GetPedidoJoinAsync(int id)
    {
        var pedido = await _pedidoRepository.GetPedidoAsync(id);
        return (!ModelState.IsValid) ? BadRequest(ModelState) : Ok(pedido);
    }
}
