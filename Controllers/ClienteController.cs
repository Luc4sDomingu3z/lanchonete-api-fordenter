using lanchonete_api.Interfaces.Repositories;
using lanchonete_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace lanchonete_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClienteController(IClienteRepository clienteRepository) : Controller
{
    private readonly IClienteRepository _clienteRepository = clienteRepository;

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Cliente>))]
    public IActionResult GetClientes()
    {
        var clientes = _clienteRepository.GetClientes();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        return Ok(clientes);
    }
}
