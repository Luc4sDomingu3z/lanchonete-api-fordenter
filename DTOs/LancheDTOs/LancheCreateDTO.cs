using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.LancheDTOs;

public class LancheCreateDTO
{
  [Required(ErrorMessage = "Nome de lanche necessario.")]
  [StringLength(70, MinimumLength = 4, ErrorMessage = "Nome de lanche precisa no minimo de 4 characteres.")]
  public string? LancheNome { get; set; }

  [Required(ErrorMessage = "Unidade do lanche necessario.")]
  [Range(0.01, 9999.00, ErrorMessage = "Valor unitario deve estar no alcance correto.")]
  public decimal Unidade { get; set; }

  [Required(ErrorMessage = "Quantidade de lanche necessaria.")]
  [Range(1, 99999, ErrorMessage = "Quantidade excede o maximo.")]
  public int Quantidade { get; set; }
}
