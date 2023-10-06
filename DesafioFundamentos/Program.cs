using DesafioFundamentos.Models;

Console.Clear();
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("\t------------------------------------------------");
Console.Write
("\t| Seja bem vindo ao sistema de estacionamento! |\n" +
 "\t -----------------------------------------------" +
"\nDigite o preço inicial: R$ ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: R$ ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("-------------------------");
    Console.WriteLine("| Digite a sua opção:   |");
    Console.WriteLine("|-----------------------|");
    Console.WriteLine("| 1 - Cadastrar veículo |");
    Console.WriteLine("|-----------------------|");
    Console.WriteLine("| 2 - Remover veículo   |");
    Console.WriteLine("|-----------------------|");
    Console.WriteLine("| 3 - Listar veículos   |");
    Console.WriteLine("|-----------------------|");
    Console.WriteLine("| 4 - Encerrar          |");
    Console.WriteLine("-------------------------");

    Console.Write(" >> ");
    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente Novamente em 2 segundos.");
            Thread.Sleep(1_500);
            break;
    }
    if (exibirMenu)
    {
        Console.Write(" >>> Pressione uma tecla para continuar! <<<   ");
        Console.ReadKey();

    }
}
Console.Clear();
Console.WriteLine(">>> O programa foi encerrado");
