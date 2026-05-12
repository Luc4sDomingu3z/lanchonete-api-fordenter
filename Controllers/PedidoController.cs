using lanchonete_api.Interfaces;
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
}
