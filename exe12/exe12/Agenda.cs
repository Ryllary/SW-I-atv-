using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe12
{
    class Agenda
    {
        //criando a lista chamando a classe pessoa
        private List<Pessoa> pessoas = new List<Pessoa>();

        //armazena os dados das pessoas e adiciona na lista
        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            //criando um objeto chamando a class pessoa
            Pessoa pessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(pessoa);
        }

        //remove a pessoa pelo nome
        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);
            //se for diferente de num
            if (pessoa != null)
            {
                //lista.Remove(objeto)
                pessoas.Remove(pessoa);
                Console.WriteLine($"Pessoa {nome} removida da agenda.");
            }
            else
            {
                Console.WriteLine($"Pessoa {nome} não encontrada na agenda.");
            }
        }

        //metodo q busca a pessoa
        public Pessoa BuscaPessoa(string nome)
        {
            //seria um percorra a lista pessoas para achar a pessoa da class Pessoa
            foreach (Pessoa pessoa in pessoas)
            {
                //vai validar se o nome do objeto é igual ao nome que vao deletar
                if (pessoa.Nome == nome)
                {
                    //se for sim, vai retornar o objeto q corresponde ao nome
                    return pessoa;
                }
            }
            //senao, estregue null
            return null;
        }

        public void ImprimeAgenda()
        {
            //Count conta o comprimento da lista
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Agenda vazia.");
            }
            else
            {
                Console.WriteLine("Pessoas na agenda:");
                //seria o for, nome da class, nome objeto in nome da lista
                foreach (Pessoa pessoa in pessoas)
                {
                    Console.WriteLine(pessoa);
                }
            }
        }
    }
}
