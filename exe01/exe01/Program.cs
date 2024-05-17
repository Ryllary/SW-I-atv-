namespace exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Produto
            Produto produto1 = new

            Produto("Camiseta", 29.99, 50);

            produto1.MostrarInformacoes();
            produto1.AdicionarEstoque(10);
            produto1.RemoverEstoque(5);
            //produto1.RemoverEstoque(60); código para remover do estoque mais do que tem

            Console.WriteLine("\nAtualizando informações do produto após operações:");
            produto1.MostrarInformacoes();
        }
    }
}

