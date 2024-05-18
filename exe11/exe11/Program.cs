namespace exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new("Fusca", 1970);

            //chama o metodo q acelera
            meuCarro.Acelerar();
            meuCarro.Acelerar();

            Console.WriteLine("Velocidade após acelerar: " + meuCarro.velocidade);

            // vai frear o carro
            meuCarro.Frear();

            Console.WriteLine("Velocidade após frear: " + meuCarro.velocidade);
        }
    }
}