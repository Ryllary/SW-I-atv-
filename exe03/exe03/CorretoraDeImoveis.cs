using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03
{
    public class CorretoraDeImoveis
    {
        // Lista de imóveis armazenados pela corretora
        private List<Imovel> listaDeImoveis = new List<Imovel>(); // lista

        // Método para inserir um novo imóvel na lista
        public void InserirImovel(string endereco, double preco, string tipo)
        {
            // Criar um novo objeto Imovel com os parâmetros fornecidos
            Imovel imovel = new Imovel(endereco, preco, tipo);
            // Adicionar o imóvel à lista
            listaDeImoveis.Add(imovel);
            // Exibir mensagem de sucesso
            Console.WriteLine("Imóvel inserido com sucesso!");
        }

        // Método para alterar o preço de um imóvel existente
        public void AlterarPrecoDoImovel(string enderecoInformado, double novoPreco)
        {
            // Buscar o imóvel na lista pelo endereço informado
            // find é usado para encontrar o primeiro elemento na lista que corresponde a determinado critério.
            // i representa cada objeto Imovel na lista enquanto o método Find itera sobre eles.
            Imovel imovel = listaDeImoveis.Find(i => i.endereco == enderecoInformado);

            // Se o imóvel for encontrado
            if (imovel != null) // nulo
            {
                // Alterar o preço do imóvel
                imovel.preco = novoPreco;
                // Exibir mensagem de sucesso
                Console.WriteLine("Preço do imóvel alterado com sucesso!");
            }
            else
            {
                // Se o imóvel não for encontrado, exibir mensagem de erro
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        // Método para listar todos os imóveis disponíveis
        public void ListarImoveis()
        {
            // Exibir cabeçalho
            Console.WriteLine("Imóveis disponíveis:");

            // Iterar sobre cada imóvel na lista
            foreach (Imovel imovel in listaDeImoveis)
            {
                // Exibir detalhes do imóvel (endereço, tipo e preço)
                Console.WriteLine($"Endereço: {imovel.endereco}, Tipo: {imovel.tipo}, Preço: R${imovel.preco.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

        // Método para calcular o valor médio dos imóveis
        public double CalcularValorMedio()
        {
            // Se não houver imóveis na lista, retornar 0
            if (listaDeImoveis.Count == 0)
            {
                return 0;
            }

            // Calcular a soma dos preços de todos os imóveis
            double somaPrecos = listaDeImoveis.Sum(imovel => imovel.preco);
            // Calcular o valor médio dos imóveis
            somaPrecos.ToString("F2", CultureInfo.InvariantCulture);
            return somaPrecos / listaDeImoveis.Count;
        }
    }
}

