namespace exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            //chama a class
            Fabricante fabricante = new Fabricante
            {
                Nome = "Empresa XYZ",
                Endereco = "Rua ABC, 123",
                Cidade = "Cidade A"
            };

            Produto produto = new Produto
            {
                Nome = "Celular",
                Fabricante = fabricante,
                Preco = 999.99m
            };

            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
            Console.WriteLine($"Preço: R${produto.Preco}");
        }
    }
}