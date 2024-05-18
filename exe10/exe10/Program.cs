namespace exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria animal
            Animal animal = new Animal
            {
                Nome = "Rex",
                Especie = "Cachorro",
                Idade = 5
            };

            // puxa para emitir o som
            animal.EmitirSom();
        }
    }
}