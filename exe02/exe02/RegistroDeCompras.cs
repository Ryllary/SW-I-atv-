using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02
{
    class RegistroDeCompras
    {
        // Definição dos atributos 
        private DateTime data;
        private string produto;
        private decimal valor;

        // Lista para armazenar as compras
        // list é uma lista  que podemos manipulá-los conforme necessário, apenas o que esta dentro
        private List<RegistroDeCompras> compras;

        // Construtor da classe
        public RegistroDeCompras(DateTime data, string produto, decimal valor)
        {
            // this  referência para o objeto atual, tbm para identificar os objetos
            this.data = data;
            this.produto = produto;
            this.valor = valor;
            this.compras = new List<RegistroDeCompras>();
        }

        // Método para adicionar uma compra à lista
        public void AdicionarCompra(DateTime data, string produto, decimal valor)
        { // add é para adicionar 
            compras.Add(new RegistroDeCompras(data, produto, valor));
        }

        // Método para listar todas as compras registradas
        public void ListarCompras()
        {
            // foreach, você pode acessar e manipular cada elemento de uma lista, não deixando o código poluido
            foreach (var compra in compras)
            {
                Console.WriteLine($"Data: {compra.data}, Produto: {compra.produto}, Valor: {compra.valor}");
            }
        }
    }
}
