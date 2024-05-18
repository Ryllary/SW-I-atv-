namespace exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            //chama a class
            Agenda agenda = new Agenda();
            string opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                //armazena a opcao
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        //chama o metodo q adiciona e passa os parametros
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;

                    case "2":
                        Console.Write("Nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        //chama o metodo q remove e passa o parametro do nome para remover q recebeu
                        agenda.RemovePessoa(nomeRemover);
                        break;

                    case "3":
                        Console.Write("Nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine("Pessoa encontrada: " + pessoaEncontrada);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;

                    case "4":
                        agenda.ImprimeAgenda();
                        break;

                    case "5":
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != "5"); //enquanto a opcao for diferente de 5
        }
    }
}