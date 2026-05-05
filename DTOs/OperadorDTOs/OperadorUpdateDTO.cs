using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.OperadorDTOs;

public class OperadorUpdateDTO
{
    [Required(ErrorMessage = "id de operador necessário.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome de operador necessário.")]
    [StringLength(60, MinimumLength = 4, ErrorMessage = "Minimo 4 e maximo 60 caracteres.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Cpf de operador necessário.")]
    [StringLength(14, MinimumLength = 11, ErrorMessage = "CPF invalido.")]
    public string Cpf { get; set; } = null!;
}
