using lanchonete_api.DTOs.BebidaSaidaDTOs;

namespace lanchonete_api.Interfaces.Services;

public interface IBebidaSaidaService
{
    IEnumerable<BebidaSaidaDTO>? GetBebidaSaidas();
    Task<BebidaSaidaDTO?> GetBebidaSaidaAsync(int bebidaSaidaId);
    BebidaSaidaDTO? GetBebida(int bebidaSaidaId);
    bool BebidaSaidaExists(int bebidaSaidaId);
    bool CreateBebidaSaida(BebidaSaidaDTO bebidaSaida);
    bool UpdateBebidaSaida(BebidaSaidaDTO bebidaSaida);
    bool DeleteBebidaSaida(BebidaSaidaDTO bebidaSaida);
    bool Save();
}
