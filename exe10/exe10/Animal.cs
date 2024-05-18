using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe10
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public void EmitirSom() 
        {
            Console.WriteLine($"O {Especie} {Nome} está emitindo um som");
        }
    }
}
