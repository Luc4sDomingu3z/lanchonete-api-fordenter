using lanchonete_api.Data;
using lanchonete_api.Models;
using lanchonete_api.Interfaces;
namespace lanchonete_api.Repository;

public class ClienteRepository(LanchoneteApiDbContext context) : IClienteRepository
{
    private readonly LanchoneteApiDbContext _context = context;

    public ICollection<Cliente>? GetClientes()
    {
        return _context.Clientes?.OrderBy(c => c.Id).ToList();
    }

    public async Task<Cliente?> GetClienteAsync(int clienteId)
    {
        Cliente? cliente = await _context.Clientes!.FindAsync(clienteId);
        return cliente;
    }

    public Cliente? GetCliente(int clienteId)
    {
        Cliente? cliente = _context.Clientes?.Find(clienteId);
        return cliente;
    }

    public bool ClienteExists(int clienteId)
    {
        Cliente? cliente = _context.Clientes?.Find(clienteId);
        if (cliente != null)
            return true;
        return false;
    }
}
