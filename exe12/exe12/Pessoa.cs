using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe12
{
    class Pessoa
    {
        //criando atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        //construtor para arrumar em variaveis o q recebemos
        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        //esta transformando tudo para string, pq esta concatenando os atributos
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}";
        }
    }
}
