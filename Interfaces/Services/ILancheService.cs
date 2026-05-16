using lanchonete_api.DTOs.LancheDTOs;

namespace lanchonete_api.Interfaces.Services;

public interface ILancheService
{
    IEnumerable<LancheDTO>? GetLanches();
    Task<LancheDTO?> GetLancheAsync(int lancheId);
    LancheDTO? GetLanche(int lancheId);
    bool LancheExists(int lancheId);
    bool CreateLanche(LancheDTO lanche);
    bool UpdateLanche(LancheDTO lanche);
    bool DeleteLanche(LancheDTO lanche);
    bool Save();
}
