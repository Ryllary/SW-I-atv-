using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe08
{
    public class Fabricante
    {
        private string nome;
        public string Nome
        {
            //ao inves de ja colocar get e set, aqui acaba sendo assim por causa das excessoes
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
                else
                {
                    throw new ArgumentException("O nome do fabricante não pode ser vazio.");
                }
            }
        }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }
}
