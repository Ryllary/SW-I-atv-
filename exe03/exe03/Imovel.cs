using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03
{
    public class Imovel
    {
        // Atributos da classe Imovel
        public string endereco; // Armazena o endereço do imóvel
        public double preco;    // Armazena o preço do imóvel
        public string tipo;     // Armazena o tipo do imóvel (por exemplo: casa, apartamento, etc.)

        // Construtor da classe Imovel
        public Imovel(string endereco, double preco, string tipo)
        {
            // Atribui os valores passados como argumentos aos atributos da classe
            this.endereco = endereco; // Endereço do imóvel
            this.preco = preco;       // Preço do imóvel
            this.tipo = tipo;         // Tipo do imóvel
        }
    }
}

