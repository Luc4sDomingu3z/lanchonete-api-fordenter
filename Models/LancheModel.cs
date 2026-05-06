namespace lanchonete_api.Models;

public class Lanche
{
    public int Id { get; set; }
    public string? LancheNome { get; set; }
    public decimal Unidade { get; set; }
    public int Quantidade { get; set; }
    public DateTime UltimaEntrada { get; set; }
    public ICollection<LancheSaida> Saidas { get; set; } = [];
}
