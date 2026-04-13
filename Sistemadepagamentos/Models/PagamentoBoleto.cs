namespace Sistemadepagamentos.Models;

public class PagamentoBoleto : Pagamento
{
    public string CodigoBarras { get; set; }

    public PagamentoBoleto(decimal valor, string codigoBarras) : base(valor)
    {
        CodigoBarras = codigoBarras;
    }

    public override void ProcessarPagamento()
    {
        Console.WriteLine(ObterResume());
    }

    public override string ObterResume()
    {
        return $"Processando pagamento de R$ {Valor:F2} via Boleto (Cod Barra: {CodigoBarras}) na data {Data:dd/MM/yyyy}.";
    }
}
