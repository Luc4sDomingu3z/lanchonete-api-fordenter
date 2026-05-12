using Pedido = lanchonete_api.Models.Pedido;
namespace lanchonete_api.DTOs.ClienteDTOs;

public class ClienteDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;

    public int Idade { get; set; }
    public ICollection<Pedido>? Pedidos { get; set; }
}
