using lanchonete_api.Data;
using lanchonete_api.Interfaces.Services;
using lanchonete_api.DTOs.OperadorDTOs;

namespace lanchonete_api.Services;

public class OperadorService(LanchoneteApiDbContext context) : IOperadorService 
{
  private readonly LanchoneteApiDbContext _context = context;
  
  public IEnumerable<OperadorDTO>? GetOperadores()
  {
    var operadores = _context.Operadores?.Select(o => new OperadorDTO{
        Id = o.Id,
        Cpf = o.Cpf,
        Nome = o.Nome
        });
  }
}
