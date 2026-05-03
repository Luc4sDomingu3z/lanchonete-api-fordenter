using lanchonete_api.Models;
namespace lanchonete_api.Models;

public class Pedido
{
  public int Id { get; set; }
  // Chave estrangeira
  public int ClienteId { get; set; }
  public Cliente? Cliente { get; set; }
}
