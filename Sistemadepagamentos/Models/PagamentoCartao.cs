namespace Sistemadepagamentos.Models;

public class PagamentoCartao : Pagamento
{
    public string NumeroCartao { get; set; }

    public PagamentoCartao(decimal valor, string numeroCartao) : base(valor)
    {
        NumeroCartao = numeroCartao;
    }

    public override void ProcessarPagamento()
    {
        Console.WriteLine(ObterResume());
    }

    public override string ObterResume()
    {
        return $"Processando pagamento de R$ {Valor:F2} via Cartão (Número: {NumeroCartao}) na data {Data:dd/MM/yyyy}.";
    }
}
