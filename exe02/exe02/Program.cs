namespace exe02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe RegistroDeCompras
            RegistroDeCompras registro = new RegistroDeCompras(DateTime.Now, "Camiseta", 29.99m);
            registro.AdicionarCompra(DateTime.Now.AddDays(-1), "Calça", 49.99m); // // Subtrai um dia da data atual
            registro.AdicionarCompra(DateTime.Now.AddDays(-2), "Tênis", 99.99m);

            // Listar todas as compras
            registro.ListarCompras();
        }
    }
}