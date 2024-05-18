namespace exe03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Exibe o cabeçalho do programa
            Console.WriteLine(" Corretora De Imóveis ");

            // Cria uma instância da classe CorretoraDeImoveis
            CorretoraDeImoveis corretora = new CorretoraDeImoveis();

            // Loop principal do programa
            while (true)
            {
                int opcao;

                // Exibe o menu de opções
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Inserir imóvel");
                Console.WriteLine("2. Alterar preço do imóvel");
                Console.WriteLine("3. Listar imóveis");
                Console.WriteLine("4. Calcular valor médio dos imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("\nOpção Escolhida: ");

                // Verifica se a entrada do usuário é um número inteiro
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    // Se a entrada não for um número inteiro, exibe uma mensagem de erro e continua o loop
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                // Processa a opção escolhida pelo usuário
                switch (opcao)
                {
                    case 1:
                        // Opção para inserir um novo imóvel
                        Console.Write("Endereço do imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do imóvel: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo do imóvel: ");
                        string tipo = Console.ReadLine();
                        corretora.InserirImovel(endereco, preco, tipo);
                        break;

                    case 2:
                        // Opção para alterar o preço de um imóvel
                        Console.Write("Endereço do imóvel a ser alterado: ");
                        string enderecoAlterar = Console.ReadLine();
                        Console.Write("Novo preço: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPrecoDoImovel(enderecoAlterar, novoPreco);
                        break;

                    case 3:
                        // Opção para listar todos os imóveis disponíveis
                        corretora.ListarImoveis();
                        break;

                    case 4:
                        // Opção para calcular o valor médio dos imóveis
                        double valorMedio = corretora.CalcularValorMedio();
                        Console.WriteLine($"O valor médio dos imóveis é: R${valorMedio}");
                        break;

                    case 5:
                        // Opção para sair do programa
                        Console.WriteLine("Saindo do programa.");
                        return;

                    default:
                        // Se a opção escolhida não estiver entre 1 e 5, exibe uma mensagem de erro
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            }
        }
    }
}
