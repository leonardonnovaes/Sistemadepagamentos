using Sistemadepagamentos.Models;
using Sistemadepagamentos.Services;

bool executando = true;

while (executando)
{
    Menu.ExibirMenu();
    string opcao = Menu.LerOpcao();

    switch (opcao)
    {
        case "1":
            ProcessarPagamentoCartao();
            break;
        case "2":
            ProcessarPagamentoBoleto();
            break;
        case "3":
            executando = false;
            Console.WriteLine("Encerrando a aplicação...");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

    if (executando)
    {
        Console.WriteLine();
    }
}

static void ProcessarPagamentoCartao()
{
    Console.Write("Informe o valor do pagamento: R$ ");
    if (decimal.TryParse(Console.ReadLine(), out decimal valor))
    {
        Console.Write("Informe o número do cartão: ");
        string numeroCartao = Console.ReadLine() ?? "";

        if (!string.IsNullOrWhiteSpace(numeroCartao))
        {
            Pagamento pagamento = new PagamentoCartao(valor, numeroCartao);
            pagamento.ProcessarPagamento();
        }
        else
        {
            Console.WriteLine("Número do cartão inválido!");
        }
    }
    else
    {
        Console.WriteLine("Valor inválido!");
    }
}

static void ProcessarPagamentoBoleto()
{
    Console.Write("Informe o valor do pagamento: R$ ");
    if (decimal.TryParse(Console.ReadLine(), out decimal valor))
    {
        Console.Write("Informe o código de barras: ");
        string codigoBarras = Console.ReadLine() ?? "";

        if (!string.IsNullOrWhiteSpace(codigoBarras))
        {
            Pagamento pagamento = new PagamentoBoleto(valor, codigoBarras);
            pagamento.ProcessarPagamento();
        }
        else
        {
            Console.WriteLine("Código de barras inválido!");
        }
    }
    else
    {
        Console.WriteLine("Valor inválido!");
    }
}
