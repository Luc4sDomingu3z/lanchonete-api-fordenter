using lanchonete_api.DTOs.OperadorDTOs;

namespace lanchonete_api.Interfaces.Services;

public interface IOperadorService
{
    IEnumerable<OperadorDTO>? GetOperadores();
    Task<OperadorDTO?> GetOperadorAsync(int operadorId);
    OperadorDTO? GetOperador(int operadorId);
    bool OperadorExists(int operadorId);
    bool CreateOperador(OperadorDTO operador);
    bool UpdateOperador(OperadorDTO operador);
    bool DeleteOperador(OperadorDTO operador);
    bool Save();
}
