namespace exe05
{
    internal class Program
    {
        // Método principal da aplicação
        private static void Main(string[] args)
        {
            // Exibe o título do gerenciador de tarefas
            Console.WriteLine("Gerenciador De Tarefa");

            // Cria uma nova instância da classe GerenciadorDeTarefa para gerenciar as tarefas
            GerenciadorDeTarefa gerenciador = new GerenciadorDeTarefa();

            // Loop infinito para exibir o menu de opções e processar as escolhas do usuário
            while (true)
            {
                // Exibe as opções disponíveis no menu
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas para Hoje");
                Console.WriteLine("3 - Listar Todas as Tarefas");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                // Lê a opção escolhida pelo usuário
                string opcao = Console.ReadLine();

                Console.WriteLine();

                // Estrutura de controle switch para determinar a ação a ser executada com base na opção escolhida
                switch (opcao)
                {
                    case "1":
                        // Adiciona uma nova tarefa
                        Console.Write("Informe a descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Informe a data de vencimento (exemplo: 2024-07-29): ");
                        // Tenta converter a entrada do usuário em uma data válida
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataVencimento))
                        {
                            // Chama o método AdicionarTarefa do gerenciador para adicionar a nova tarefa
                            gerenciador.AdicionarTarefa(descricao, dataVencimento);
                            Console.WriteLine("Tarefa adicionada com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Data inválida. A tarefa não foi adicionada.");
                        }
                        break;
                    case "2":
                        // Lista as tarefas que devem ser executadas hoje
                        List<Tarefa> tarefasHoje = gerenciador.TarefasParaExecutarHoje();
                        Console.WriteLine("Tarefas para hoje:");
                        foreach (Tarefa tarefa in tarefasHoje)
                        {
                            Console.WriteLine($"{tarefa.descricao} - {tarefa.dataVencimento}");
                        }
                        break;
                    case "3":
                        // Lista todas as tarefas cadastradas
                        List<Tarefa> todasAsTarefas = gerenciador.ListarTarefas();
                        Console.WriteLine("Todas as tarefas:");
                        foreach (Tarefa tarefa in todasAsTarefas)
                        {
                            Console.WriteLine($"{tarefa.descricao} - {tarefa.dataVencimento}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

    }
}