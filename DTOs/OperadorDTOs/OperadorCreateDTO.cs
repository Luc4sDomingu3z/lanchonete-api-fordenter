using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.OperadorDTOs;

public class OperadorCreateDTO
{
  [Required(ErrorMessage = "Nome de operador necessario.")]
  [StringLength(60, MinimumLength = 4, ErrorMessage = "Nome do operador deve ter no minimo 4 characteres.")]
  public string? Nome { get; set; }

  [Required(ErrorMessage = "Cpf do operador necessario.")]
  [StringLength(14, MinimumLength = 11, ErrorMessage = "O cpf pode estar invalido.")]
  public string Cpf { get; set; } = null!;
}
