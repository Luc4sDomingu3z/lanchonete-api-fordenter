using lanchonete_api.DTOs.ClienteDTOs;

namespace lanchonete_api.Interfaces.Services;

public interface IClienteService
{
    IEnumerable<ClienteDTO>? GetClientes();
    Task<ClienteDTO?> GetClienteAsync(int clienteId);
    ClienteDTO? GetCliente(int clienteId);
    bool ClienteExists(int clienteId);
    bool CreateCliente(ClienteDTO cliente);
    bool UpdateCliente(ClienteDTO cliente);
    bool DeleteCliente(ClienteDTO cliente);
    bool Save();
}
