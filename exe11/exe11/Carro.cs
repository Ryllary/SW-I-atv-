using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe11
{
    class Carro
    {
        // sao os atributos do objeto
        public string modelo;
        public int ano;
        public int velocidade;

        // esse é o construtor
        public Carro(string modelo, int ano)
        {
            this.modelo = modelo;
            this.ano = ano;
            this.velocidade = 0; // quando um carro é criado a sua velocidade é 0
        }

        // acelera o carro
        public void Acelerar()
        {
            velocidade += 10;
        }

        // freia o carro
        public void Frear()
        {
            if (velocidade >= 10) // verifica a velocidade para nao ficar negativa
            {
                velocidade -= 10;
            }
            else
            {
                velocidade = 0; // se for menor coloca como 0
            }
        }
    }
}
