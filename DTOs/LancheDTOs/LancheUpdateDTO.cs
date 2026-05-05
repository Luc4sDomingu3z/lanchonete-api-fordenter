using System.ComponentModel.DataAnnotations;

namespace lanchonete_api.DTOs.LancheDTOs
{
    public class LancheUpdateDTO
    {
        [Required(ErrorMessage = "id de lanche necessário.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lanche de nome necessário")]
        [StringLength(70, MinimumLength = 4, ErrorMessage = "Nome de lanche precisa no minimo de 4 characteres e maximo de 70.")]
        public string? LancheNome { get; set; }

        [Required(ErrorMessage = "Valor unitario de lanche necessário.")]
        [Range(0.01, 9999.00, ErrorMessage = "Valor unitario deve estar no alcance correto.")]
        public decimal Unidade { get; set; }

        [Required(ErrorMessage = "Quantidade de lanche necessaria.")]
        [Range(1, 99999, ErrorMessage = "Quantidade excede o maximo.")]
        public int Quantidade { get; set; }

        public DateTime UltimaEntrada { get; set; }
    }
}
