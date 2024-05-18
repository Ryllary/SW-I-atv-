using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe08
{
    public class Produto
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
                else
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio.");
                }
            }
        }
        public Fabricante Fabricante { get; set; }
        private decimal preco;
        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    throw new ArgumentException("O preço do produto deve ser positivo.");
                }
            }
        }
    }
}
