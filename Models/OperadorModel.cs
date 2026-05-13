namespace lanchonete_api.Models;

public class Operador
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string Cpf { get; set; } = null!;
}
