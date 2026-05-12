using lanchonete_api.Data;
using lanchonete_api.Models;

namespace lanchonete_api.Repository
{
    public class PedidoRepository(LanchoneteApiDbContext context)
    {
        // DBContext
        private readonly LanchoneteApiDbContext _context = context;

        public ICollection<Pedido>? GetPedidos()
        {
            return _context.Pedidos?.OrderBy(p => p.Id).ToList();
        }

        public Pedido? GetPedido(int pedidoId)
        {
            return _context.Pedidos?.Find(pedidoId);
        }
    }
};
