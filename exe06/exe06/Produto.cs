using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe06
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        // Construtor da classe Produto que inicializa os atributos com os valores fornecidos
        public Produto(int codigo, string nome, double preco, int quantidadeEmEstoque)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }
    }

    // responsável por gerenciar os produtos
    public class GerenciadorDeProduto
    {
        // Lista privada para armazenar os produtos
        private List<Produto> listaDeProdutos;

        // Construtor da classe GerenciadorDeProduto que inicializa a lista de produtos
        public GerenciadorDeProduto()
        {
            listaDeProdutos = new List<Produto>();
        }

        // Método para adicionar um novo produto à lista
        public void AdicionarProduto(int codigo, string nome, double preco, int quantidadeEmEstoque)
        {
            // Cria uma nova instância da classe Produto com os dados fornecidos e a adiciona à lista
            Produto novoProduto = new Produto(codigo, nome, preco, quantidadeEmEstoque);
            listaDeProdutos.Add(novoProduto);
        }

        // remove um produto da lista pelo seu código
        public void RemoverProduto(int codigoInformado)
        {
            // Busca o produto na lista pelo código e o remove se encontrar
            Produto produtoParaRemover = listaDeProdutos.Find(p => p.codigo == codigoInformado);

            if (produtoParaRemover != null)
            {
                listaDeProdutos.Remove(produtoParaRemover);
            }
        }

        // Método para listar todos os produtos cadastrados
        public List<Produto> ListarProdutos()
        {
            // Retorna a lista de produtos completa
            return listaDeProdutos;
        }

        // Método para buscar um produto na lista pelo seu código
        public Produto BuscarProdutoPorCodigo(int codigoInformado)
        {
            // Retorna o produto encontrado na lista pelo código, se existir
            return listaDeProdutos.Find(p => p.codigo == codigoInformado);
        }
    }

}
