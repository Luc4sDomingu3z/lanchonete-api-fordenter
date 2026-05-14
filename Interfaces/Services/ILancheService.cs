using lanchonete_api.Models;

namespace lanchonete_api.Interfaces.Services;

public interface ILancheService
{
    ICollection<Lanche>? GetLanches();
    Task<Lanche?> GetLancheAsync(int lancheId);
    Lanche? GetLanche(int lancheId);
    bool LancheExists(int lancheId);
    // bool CreateLanche(Lanche lanche);
    // bool UpdateLanche(Lanche lanche);
    // bool DeleteLanche(Lanche lanche);
    // bool Save();
}
