using lanchonete_api.Data;
using lanchonete_api.Models;
using lanchonete_api.Interfaces.Repositories;

namespace lanchonete_api.Repository;

public class BebidaRepository(LanchoneteApiDbContext context) : IBebidaRepository
{
    private readonly LanchoneteApiDbContext _context = context;

    public ICollection<Bebida>? GetBebidas()
    {
        return _context.Bebidas?.OrderBy(b => b.Id).ToList();
    }

    public async Task<Bebida?> GetBebidaAsync(int bebidaId)
    {
        return await _context.Bebidas!.FindAsync(bebidaId);
    }

    public Bebida? GetBebida(int bebidaId)
    {
        return _context.Bebidas?.Find(bebidaId);
    }

    public bool BebidaExists(int bebidaId)
    {
        Bebida? bebida = _context.Bebidas?.Find(bebidaId);
        if (bebida == null)
            return false;
        return true;
    }
}
