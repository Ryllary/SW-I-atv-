using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe01
{
    public class Produto
    {
        // Atributos

        private string nome;
        private double preco;
        private int quantidadeEmEstoque;

        // metodo construtor: basicamente um conjunto de instruções que dizem ao programa como criar um novo objeto e como configurá-lo corretamente desde o início.
        public Produto(string nome, double preco, int quantidadeInicial)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeInicial;
        }
        // Método para adicionar itens ao estoque
        public void AdicionarEstoque(int quantidade)
        {
            // será executado apenas se a condição dentro dos parênteses for verdadeira.
            if (quantidade > 0)
            {
                quantidadeEmEstoque += quantidade; // aqui seria como quantidadeEmEstoque = quantidadeEmEstoque + quantidade
                Console.WriteLine($"{quantidade} unidades do produto '{nome}' foram adicionadas ao estoque.");
            }
            else // caso for falso, ou seja, o numero for menor ou igual a zero vai executar essa função
            {
                Console.WriteLine("A quantidade a ser adicionada deve ser maior que 0");
            }
        }

        // Método para remover itens do estoque
        public void RemoverEstoque(int quantidade)
        {
            //´&&´ para verificar se duas condições são verdadeiras simultaneamente
            if (quantidade > 0 && quantidade <=  quantidadeEmEstoque)
            {
                // -= vai ser tirado do estoque 
                quantidadeEmEstoque -= quantidade;
                Console.WriteLine($"{quantidade} unidades do produto '{nome}' foram removidas do estoque.");
            }
            else if (quantidade > quantidadeEmEstoque)
            {
                Console.WriteLine($"Não há {quantidade} unidades do produto '{nome}' disponíveis no estoque.");
            }
            else
            {
                Console.WriteLine("A quantidade a ser removida deve ser maior que zero.");
            }
        }

        // Método para exibir informações do produto
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: R${preco:F2}");
            Console.WriteLine($"Quantidade em estoque: { quantidadeEmEstoque} ");

        }
    }
}
