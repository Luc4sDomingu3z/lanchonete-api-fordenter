using lanchonete_api.Data;
using lanchonete_api.Interfaces.Repositories;
using lanchonete_api.Models;

namespace lanchonete_api.Repository
{
    public class PedidoRepository(LanchoneteApiDbContext context) : IPedidoRepository
    {
        // DBContext
        private readonly LanchoneteApiDbContext _context = context;

        public ICollection<Pedido>? GetPedidos()
        {
            return _context.Pedidos?.OrderBy(p => p.Id).ToList();
        }

        public async Task<Pedido?> GetPedidoAsync(int pedidoId)
        {
            Pedido? pedido = await _context.Pedidos!.FindAsync(pedidoId);
            if (pedido == null)
                return null;
            return pedido;
        }

        public Pedido? GetPedido(int pedidoId)
        {
            Pedido? pedido = _context.Pedidos?.Find(pedidoId);
            return pedido;
        }

        public bool PedidoExists(int pedidoId)
        {
            var pedido = _context.Pedidos?.Find(pedidoId);
            if (pedido != null)
                return true;
            return false;
        }
    }
};
