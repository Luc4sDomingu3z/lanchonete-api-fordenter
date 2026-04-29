namespace lanchonete_api.DTOs.LancheDTOs;

public class LancheDTO
{
  public int Id { get; set; }
  public string? LancheNome { get; set; }
  public decimal Unidade { get; set; }
  public int Quantidade { get; set; }
  public DateTime UltimaEntrada { get; set; }
}
