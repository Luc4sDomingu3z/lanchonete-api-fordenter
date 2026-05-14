using lanchonete_api.Models;
using lanchonete_api.Data;
using lanchonete_api.Interfaces.Repositories;
namespace lanchonete_api.Repository;

public class BebidaSaidaRepository(LanchoneteApiDbContext context) : IBebidaSaidaRepository
{
    private readonly LanchoneteApiDbContext _context = context;

    public ICollection<BebidaSaida>? GetBebidaSaidas()
    {
        return _context.BebidaSaidas?.OrderBy(bs => bs.Id).ToList();
    }

    public async Task<BebidaSaida?> GetBebidaSaidaAsync(int saidaId)
    {
        return await _context.BebidaSaidas!.FindAsync(saidaId);
    }

    public BebidaSaida? GetBebida(int saidaId)
    {
        return _context.BebidaSaidas?.Find(saidaId);
    }

    public bool BebidaSaidaExists(int saidaId)
    {
        BebidaSaida? bebidaSaida = _context.BebidaSaidas?.Find(saidaId);
        if (bebidaSaida == null) return false;
        return true;
    }
}
