namespace exe06
{
    internal class Program
    {
        // Método principal da aplicação
        private static void Main(string[] args)
        {
            Console.WriteLine("Gerenciador de Produtos");

            // Cria uma nova instância da classe GerenciadorDeProduto para gerenciar os produtos
            GerenciadorDeProduto gerenciador = new GerenciadorDeProduto();

            // Loop infinito para exibir o menu de opções e processar as escolhas do usuário
            while (true)
            {
                // Exibe as opções disponíveis no menu
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Consultar Produto por Código");
                Console.WriteLine("4 - Sair");

                Console.Write("Escolha uma opção: ");
                // Lê a opção escolhida pelo usuário
                int escolha = int.Parse(Console.ReadLine());

                // Estrutura de controle switch para determinar a ação a ser executada com base na opção escolhida
                switch (escolha)
                {
                    case 1:
                        // Adiciona um novo produto
                        Console.Write("Informe o código do produto: ");
                        int codigo = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());

                        Console.Write("Quantidade em Estoque: ");
                        int quantidadeEmEstoque = int.Parse(Console.ReadLine());

                        // Chama o método AdicionarProduto do gerenciador para adicionar o novo produto
                        gerenciador.AdicionarProduto(codigo, nome, preco, quantidadeEmEstoque);
                        Console.WriteLine("Produto adicionado com sucesso.");
                        break;

                    case 2:
                        // Lista todos os produtos cadastrados
                        Console.WriteLine("LISTA DE PRODUTOS");
                        var listaDeProdutos = gerenciador.ListarProdutos();
                        foreach (var produto in listaDeProdutos)
                        {
                            // Exibe as informações de cada produto na lista
                            Console.WriteLine($"Código: {produto.codigo}, Nome: {produto.nome}, Preço: {produto.preco:C}, Quantidade em Estoque: {produto.quantidadeEmEstoque}");
                        }
                        break;

                    case 3:
                        // Consulta um produto pelo seu código
                        Console.Write("Informe o código do produto a ser consultado: ");
                        int codigoConsulta = int.Parse(Console.ReadLine());

                        // Chama o método BuscarProdutoPorCodigo do gerenciador para consultar o produto
                        Produto produtoConsultado = gerenciador.BuscarProdutoPorCodigo(codigoConsulta);

                        if (produtoConsultado != null)
                        {
                            Console.WriteLine($"Produto encontrado: Código: {produtoConsultado.codigo}, Nome: {produtoConsultado.nome}, Preço: {produtoConsultado.preco:C}, Quantidade em Estoque: {produtoConsultado.quantidadeEmEstoque}");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o programa.");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

    }
}