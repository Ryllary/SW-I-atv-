namespace exe09
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria um livro
            Livro livro = new Livro();

            // ta tentando colocar o titulo vazio
            try
            {
                livro.Titulo = "";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            /*tenta atribuir um valor inválido à propriedade Autor do objeto livro, 
             * e caso isso gere uma exceção, captura essa exceção e imprime a mensagem 
             * associada a ela*/
            try
            {
                livro.Autor = "";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            // agr valores q de certo
            livro.Titulo = "Dom Quixote";
            livro.Autor = "Miguel de Cervantes";

            // mostrando as informaçoes
            Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}");
        }
    }
}