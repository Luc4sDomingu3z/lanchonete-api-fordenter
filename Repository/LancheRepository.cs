using lanchonete_api.Models;
using lanchonete_api.Data;
using lanchonete_api.Interfaces;
namespace lanchonete_api.Repository;

public class LancheRepository(LanchoneteApiDbContext context) : ILancheRepository
{
    private readonly LanchoneteApiDbContext _context = context;

    public ICollection<Lanche>? GetLanches()
    {
        return _context.Lanches?.OrderBy(l => l.Id).ToList();
    }

    public async Task<Lanche?> GetLancheAsync(int lancheId)
    {
        return await _context.Lanches!.FindAsync(lancheId);
    }

    public Lanche? GetLanche(int lancheId)
    {
        return _context.Lanches?.Find(lancheId);
    }

    public bool LancheExists(int lancheId)
    {
        Lanche? lanche = _context.Lanches?.Find(lancheId);
        if (lanche == null) return false;
        return true;
    }
}
