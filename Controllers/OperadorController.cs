using Microsoft.AspNetCore.Mvc;
using lanchonete_api.Models;
using lanchonete_api.Interfaces;

namespace lanchonete_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OperadorController(IOperadorRepository operadorRepository) : Controller
{
    private readonly IOperadorRepository _operadorRepository = operadorRepository;

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Operador>))]
    public IActionResult GetOperadores()
    {
        var operadores = _operadorRepository.GetOperadores();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        return Ok(operadores);
    }
}
