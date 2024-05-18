namespace exe04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Agenda Telefônica");
            AgendaTelefonica agenda = new AgendaTelefonica();

            // menu de opções e processar as escolhas do usuário
            while (true)
            {
                // Exibe as opções disponíveis no menu
                Console.WriteLine("Opções:");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Buscar contato");
                Console.WriteLine("3. Remover contato");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                // Lê a opção escolhida pelo usuário
                int opcao = int.Parse(Console.ReadLine());

                // para determinar a ação a ser executada com base na opção escolhida
                switch (opcao)
                {
                    case 1:
                        // Adiciona um novo contato à agenda
                        Console.Write("Nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone do contato: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Email do contato: ");
                        string email = Console.ReadLine();
                        // Cria um novo objeto Contato com os dados fornecidos pelo usuário
                        Contato novoContato = new Contato(nome, telefone, email);
                        // Chama o método AdicionarContato da agenda para adicionar o novo contato
                        agenda.AdicionarContato(novoContato);
                        break;
                    case 2:
                        // Busca um contato na agenda pelo nome
                        Console.Write("Nome do contato a ser buscado: ");
                        string nomeBusca = Console.ReadLine();
                        // Chama o método BuscarContato da agenda para encontrar o contato
                        Contato contatoEncontrado = agenda.BuscarContato(nomeBusca);
                        if (contatoEncontrado != null)
                        {
                            // Exibe as informações do contato encontrado
                            Console.WriteLine($"Contato encontrado: {contatoEncontrado.nome}, {contatoEncontrado.telefone}, {contatoEncontrado.email}");
                        }
                        else
                        {
                            // Exibe uma mensagem indicando que o contato não foi encontrado
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 3:
                        // Remove um contato da agenda pelo nome
                        Console.Write("Nome do contato a ser removido: ");
                        string nomeRemocao = Console.ReadLine();
                        // Chama o método BuscarContato da agenda para encontrar o contato a ser removido
                        Contato contatoRemocao = agenda.BuscarContato(nomeRemocao);
                        if (contatoRemocao != null)
                        {
                            // Chama o método RemoverContato da agenda para remover o contato encontrado
                            agenda.RemoverContato(contatoRemocao);
                            // Exibe uma mensagem indicando que o contato foi removido com sucesso
                            Console.WriteLine("Contato removido com sucesso.");
                        }
                        else
                        {
                            // Exibe uma mensagem indicando que o contato não foi encontrado
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 4:
                        // Encerra a aplicação
                        Environment.Exit(0);
                        break; // sair de loop 
                    default:
                        // Exibe uma mensagem caso a opção escolhida seja inválida
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}