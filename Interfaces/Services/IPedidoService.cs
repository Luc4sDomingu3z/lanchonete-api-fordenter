using lanchonete_api.DTOs.PedidoDTOs;

namespace lanchonete_api.Interfaces.Services;

public interface IPedidoService
{
    IEnumerable<PedidoDTO>? GetPedidos();
    Task<PedidoDTO?> GetPedidoAsync(int pedidoId);
    PedidoDTO? GetPedido(int pedidoId);
    bool PedidoExists(int pedidoId);
    bool CreatePedido(PedidoDTO pedido);
    bool UpdatePedido(PedidoDTO pedido);
    bool DeletePedido(PedidoDTO pedido);
    bool Save();
}
