using lanchonete_api.Models;

namespace lanchonete_api.Interfaces.Repositories;

public interface IPedidoRepository
{
    ICollection<Pedido>? GetPedidos();
    Task<Pedido?> GetPedidoAsync(int pedidoId);
    Pedido? GetPedido(int pedidoId);
    bool PedidoExists(int pedidoId);
    // bool CreatePedido(Pedido pedido);
    // bool UpdatePedido(Pedido pedido);
    // bool DeletePedido(Pedido pedido);
    // bool Save();
}
