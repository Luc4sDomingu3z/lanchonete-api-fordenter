using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.BebidaDTOs
{
    public class BebidaUpdateDTO
    {
        [Required(ErrorMessage = "Id de bebida necessário.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome de bebida é necessário.")]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Nome de bebida minimo e maximo de 4 - 60 caract.")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "Quantidade de bebida necessária.")]
        [Range(0, 9999, ErrorMessage = "Quantidade de bebida inválida.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Valor de bebida necessário.")]
        [Range(0.00, 9999.00, ErrorMessage = "Preço de bebida inválido.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Volume da bebida (ml) necessário.")]
        [Range(25, 2500, ErrorMessage = "Mililitros inválido.")]
        public int Volume { get; set; }

        [Required(ErrorMessage = "Disponibilidade de bebida necessária.")]
        public bool Disponivel { get; set; }

        public DateTime UltimaEntrada { get; set; }
    }
}
