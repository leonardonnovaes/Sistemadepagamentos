namespace Sistemadepagamentos.Services;

public static class Menu
{
    public static void ExibirMenu()
    {
        Console.WriteLine("***** Sistema de Processamento de Pagamentos *****");
        Console.WriteLine();
        Console.WriteLine("********** Escolha a forma de pagamento **********");
        Console.WriteLine("1 - Cartão");
        Console.WriteLine("2 - Boleto");
        Console.WriteLine("3 - Sair");
        Console.WriteLine();
    }

    public static string LerOpcao()
    {
        Console.Write("Escolha uma opção: ");
        return Console.ReadLine() ?? "";
    }
}
