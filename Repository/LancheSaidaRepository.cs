using lanchonete_api.Data;
using lanchonete_api.Interfaces;
using lanchonete_api.Models;

namespace lanchonete_api.Repository;

public class LancheSaidaRepository(LanchoneteApiDbContext context) : ILancheSaidaRepository
{
    private readonly LanchoneteApiDbContext _context = context;

    public ICollection<LancheSaida>? GetLancheSaidas()
    {
        return _context.LancheSaidas?.OrderBy(ls => ls.Id).ToList();
    }

    public async Task<LancheSaida?> GetLancheSaidaAsync(int saidaId)
    {
        return await _context.LancheSaidas!.FindAsync(saidaId);
    }

    public LancheSaida? GetLancheSaida(int saidaId)
    {
        return _context.LancheSaidas?.Find(saidaId);
    }

    public bool LancheSaidaExists(int saidaId)
    {
        LancheSaida? lancheSaida = _context.LancheSaidas?.Find(saidaId);
        return (lancheSaida != null);
    }
}
