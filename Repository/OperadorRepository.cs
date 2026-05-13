using lanchonete_api.Models;
using lanchonete_api.Data;
using lanchonete_api.Interfaces;
namespace lanchonete_api.Repository;

public class OperadorRepository(LanchoneteApiDbContext context) : IOperadorRepository
{
    private readonly LanchoneteApiDbContext _context = context;

    public ICollection<Operador>? GetOperadores()
    {
        return _context.Operadores?.OrderBy(o => o.Id).ToList();
    }

    public async Task<Operador?> GetOperadorAsync(int operadorId)
    {
        Operador? operador = await _context.Operadores!.FindAsync(operadorId);
        return operador;
    }

    public Operador? GetOperador(int operadorId)
    {
        Operador? operador = _context.Operadores?.Find(operadorId);
        return operador;
    }

    public bool OperadorExists(int operadorId)
    {
        Operador? operador = _context.Operadores?.Find(operadorId);
        return (operador != null);
    }

}
