using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.ClienteDTOs;

public class ClienteUpdateDTO
{
    [Required(ErrorMessage = "id de cliente necessário.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome de cliente necessário.")]
    [StringLength(60, MinimumLength = 4, ErrorMessage = "Nome de cliente - minimo 4 e maximo de 60 caracteres.")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "Idade de cliente necessária.")]
    [Range(1, 120, ErrorMessage = "idade minima ou maxima evadida.")]
    public int Idade { get; set; }
}
