using lanchonete_api.Models;

namespace lanchonete_api.Interfaces.Services;

public interface IBebidaService
{
    ICollection<Bebida>? GetBebidas();
    Task<Bebida?> GetBebidaAsync(int bebidaId);
    Bebida? GetBebida(int bebidaId);
    bool BebidaExists(int bebidaId);
    // bool CreateBebida(Bebida bebida);
    // bool UpdateBebida(Bebida bebida);
    // bool DeleteBebida(Bebida bebida);
    // bool Save();
}
