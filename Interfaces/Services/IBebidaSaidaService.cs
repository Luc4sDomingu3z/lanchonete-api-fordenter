using lanchonete_api.Models;

namespace lanchonete_api.Interfaces.Services;

public interface IBebidaSaidaService
{
    ICollection<BebidaSaida>? GetBebidaSaidas();
    Task<BebidaSaida?> GetBebidaSaidaAsync(int bebidaSaidaId);
    BebidaSaida? GetBebida(int bebidaSaidaId);
    bool BebidaSaidaExists(int bebidaSaidaId);
    // bool CreateBebidaSaida(BebidaSaida bebidaSaida);
    // bool UpdateBebidaSaida(BebidaSaida bebidaSaida);
    // bool DeleteBebidaSaida(BebidaSaida bebidaSaida);
    // bool Save();
}
