namespace lanchonete_api.DTOs.LancheSaidaDTOs;

public class LancheSaidaDTO
{
    public int Id { get; set; }

    // De LancheModel
    public string? LancheNome { get; set; }
    public decimal LancheValor { get; set; }

    public int Quantidade { get; set; }
    public decimal TotalPagar { get; set; }
    public DateTime Momento { get; set; }
}
