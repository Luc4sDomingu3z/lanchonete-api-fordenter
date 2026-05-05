namespace lanchonete_api.DTOs.BebidaDTOs;

public class BebidaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public int Volume { get; set; }
    public bool Disponivel { get; set; }
    public DateTime UltimaEntrada { get; set; }
}
