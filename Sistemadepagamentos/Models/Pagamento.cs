namespace Sistemadepagamentos.Models;

public abstract class Pagamento
{
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    protected Pagamento(decimal valor)
    {
        Valor = valor;
        Data = DateTime.Now;
    }

    public abstract void ProcessarPagamento();
    public abstract string ObterResume();
}
