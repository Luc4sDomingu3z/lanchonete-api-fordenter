using lanchonete_api.Models;

namespace lanchonete_api.Interfaces.Services;

public interface IOperadorService
{
    ICollection<Operador>? GetOperadores();
    Task<Operador?> GetOperadorAsync(int operadorId);
    Operador? GetOperador(int operadorId);
    bool OperadorExists(int operadorId);
    // bool CreateOperador(Operador operador);
    // bool UpdateOperador(Operador operador);
    // bool DeleteOperador(Operador operador);
    // bool Save();
}
