using lanchonete_api.Models;
namespace lanchonete_api.Interfaces;

public interface IClienteRepository
{
    ICollection<Cliente>? GetClientes();
    Task<Cliente?> GetClienteAsync(int clienteId);
    Cliente? GetCliente(int clienteId);
    bool ClienteExists(int clienteId);
    // bool CreateCliente(Cliente cliente);
    // bool UpdateCliente(Cliente cliente);
    // bool DeleteCliente(Cliente cliente);
    // bool Save();
}
