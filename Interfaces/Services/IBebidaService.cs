using lanchonete_api.DTOs.BebidaDTOs;

namespace lanchonete_api.Interfaces.Services;

public interface IBebidaService
{
    IEnumerable<BebidaDTO>? GetBebidas();
    Task<BebidaDTO?> GetBebidaAsync(int bebidaId);
    BebidaDTO? GetBebida(int bebidaId);
    bool BebidaExists(int bebidaId);
    bool CreateBebida(BebidaDTO bebida);
    bool UpdateBebida(BebidaDTO bebida);
    bool DeleteBebida(BebidaDTO bebida);
    bool Save();
}
