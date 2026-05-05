using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.ClienteDTOs;

public class ClienteCreateDTO
{
    [Required(ErrorMessage = "Nome do cliente necessário.")]
    [StringLength(60, MinimumLength = 4, ErrorMessage = "Nome do cliente precisa ter no mínimo 4 caracteres, maximo 60.")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "Idade do cliente necessária.")]
    [Range(1, 120, ErrorMessage = "Idade de cliente excede o máximo - 120.")]
    public int Idade { get; set; }
}
