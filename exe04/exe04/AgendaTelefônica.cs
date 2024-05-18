using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe04
{
    public class Contato
    {
        public string nome;
        public string telefone;
        public string email;

        // Construtor da classe Contato que recebe e inicializa os atributos com os valores fornecidos
        public Contato(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
    }

    //  gerencia os contatos na agenda
    public class AgendaTelefonica
    {
        // Lista privada para armazenar os contatos
        private List<Contato> listaDeContatos;

        // Construtor da classe AgendaTelefonica que inicializa a lista de contatos
        public AgendaTelefonica()
        {
            listaDeContatos = new List<Contato>();
        }

        // Método para adicionar um novo contato à lista
        public void AdicionarContato(Contato contatoInformado)
        {
            listaDeContatos.Add(contatoInformado);
        }

        // remove um contato da lista
        public void RemoverContato(Contato contatoInformado)
        {
            listaDeContatos.Remove(contatoInformado);
        }

        // busca um contato na lista pelo nome
        public Contato BuscarContato(string nomeInformado)
        {
            // Utiliza o método Find da lista para buscar um contato pelo nome
            // Retorna o primeiro contato encontrado com o nome informado, ou null se nenhum for encontrado
            return listaDeContatos.Find(c => c.nome == nomeInformado);
        }
    }

}
