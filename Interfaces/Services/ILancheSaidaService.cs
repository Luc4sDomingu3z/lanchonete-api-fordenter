using lanchonete_api.DTOs.LancheSaidaDTOs;

namespace lanchonete_api.Interfaces.Services;

public interface ILancheSaidaService
{
    IEnumerable<LancheSaidaDTO>? GetLancheSaidas();
    Task<LancheSaidaDTO?> GetLancheSaidaAsync(int lancheSaidaId);
    LancheSaidaDTO? GetLancheSaida(int lancheSaidaId);
    bool LancheSaidaExists(int lancheSaidaId);
    bool CreateLancheSaida(LancheSaidaDTO lancheSaida);
    bool UpdateLancheSaida(LancheSaidaDTO lancheSaida);
    bool DeleteLancheSaida(LancheSaidaDTO lancheSaida);
    bool Save();
}
