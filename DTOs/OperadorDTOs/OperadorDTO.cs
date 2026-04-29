using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
namespace lanchonete_api.DTOs.OperadorDTOs;

public class OperadorDTO
{
  [Required]
  public PrimaryKeyAttribute? Id { get; set; }

  [Required]
  [StringLength(60, MinimumLength = 4)]
  public string? Nome { get; set; }

  [Required]
  [StringLength(14, MinimumLength = 11)]
  [NotNull]
  public string? Cpf { get; set; }
}
