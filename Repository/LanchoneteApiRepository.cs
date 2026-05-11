using lanchonete_api.Data;
using lanchonete_api.Models;

namespace lanchonete_api.Repository
{
    public class LanchoneteApiRepository(LanchoneteApiDbContext context)
    {
        private readonly LanchoneteApiDbContext _context = context;

        public ICollection<Cliente>? GetClientes()
        {
            return _context.Clientes?.OrderBy(c => c.Id).ToList();
        }
    }
};
