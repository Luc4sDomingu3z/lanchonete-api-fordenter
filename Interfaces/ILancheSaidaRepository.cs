using lanchonete_api.Models;

namespace lanchonete_api.Interfaces;

public interface ILancheSaidaRepository
{
  ICollection<LancheSaida>? GetLancheSaidas();
  Task<LancheSaida?> GetLancheSaidaAsync(int lancheSaidaId);
  LancheSaida? GetLancheSaida(int lancheSaidaId);
  bool LancheSaidaExists(int lancheSaidaId);
}
