using System.Security.Cryptography.X509Certificates;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            veiculos.Add("AAA-1111");
            veiculos.Add("BBB-2222");
            veiculos.Add("CCC-2222");
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();

            Console.WriteLine("\t------------------------");
            Console.WriteLine("\t| Adicionando veículos |");
            Console.WriteLine("\t------------------------");

            Console.WriteLine("_________________________________________________________");
            Console.Write("Digite a placa do veículo para estacionar (ex.: ABC-1234)\n >> ");
            veiculos.Add(Console.ReadLine().ToUpper());
            Console.WriteLine("Veículo estacionado com sucesso!\n");

        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover: ");
            Console.Write(" >> ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Por quantas horas o veículo ficou estacionado? \n >> ");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal:F2} \n");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();

            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                Console.WriteLine("\t----------------");
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"\t| {i + 1} | {veiculos[i]} |");
                    Console.WriteLine("\t----------------");
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.\n");
            }
        }
    }
}
