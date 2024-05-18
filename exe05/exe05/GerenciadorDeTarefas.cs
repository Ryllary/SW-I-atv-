using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe05
{
    public class Tarefa
    {
        public string descricao;
        public DateTime dataVencimento;

        // Construtor da classe Tarefa que inicializa os atributos com os valores fornecidos
        public Tarefa(string descricao, DateTime dataVencimento)
        {
            this.descricao = descricao;
            this.dataVencimento = dataVencimento;
        }

        // Método para verificar se a tarefa deve ser executada hoje com base na sua data de vencimento
        public bool DeveSerExecutadaHoje()
        {
            // Retorna verdadeiro se a data de vencimento da tarefa for igual à data atual
            return dataVencimento.Date == DateTime.Today;
        }
    }

    // Definição da classe GerenciadorDeTarefa, responsável por gerenciar as tarefas
    public class GerenciadorDeTarefa
    {
        // Lista privada para armazenar as tarefas
        private List<Tarefa> ListaDeTarefas;

        // Construtor da classe GerenciadorDeTarefa que inicializa a lista de tarefas
        public GerenciadorDeTarefa()
        {
            ListaDeTarefas = new List<Tarefa>();
        }

        // Método para adicionar uma nova tarefa à lista
        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            // Cria uma nova instância da classe Tarefa com os dados fornecidos e a adiciona à lista
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
            ListaDeTarefas.Add(novaTarefa);
        }

        // Método para remover uma tarefa da lista pelo nome da descrição
        public void RemoverTarefa(string descricaoInformada)
        {
            // Busca a tarefa na lista pelo nome da descrição e a remove, se encontrada
            Tarefa tarefaParaRemover = ListaDeTarefas.Find(t => t.descricao == descricaoInformada);
            if (tarefaParaRemover != null)
            {
                ListaDeTarefas.Remove(tarefaParaRemover);
            }
        }

        // Método para listar todas as tarefas cadastradas
        public List<Tarefa> ListarTarefas()
        {
            return ListaDeTarefas;
        }

        // Método para listar as tarefas que devem ser executadas hoje
        public List<Tarefa> TarefasParaExecutarHoje()
        {
            // Filtra a lista de tarefas para incluir apenas as que devem ser executadas hoje
            return ListaDeTarefas.FindAll(tarefas => tarefas.DeveSerExecutadaHoje());
        }
    }
}
