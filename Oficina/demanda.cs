using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Threading;
public class Demanda
{
    public string horas { get; set; }
    public string nomeProfessor { get; set; }
    public string salaProfessor { get; set; }
    public string nomeTarefa { get; set; }
    public int tarefaQuantidade { get; set; }

    public static void CriarDemanda(List<Demanda> demandas, List<Professor> professores, List<Tarefa> tarefas){
        string teacherName = "";
        string sala = "";
        string nomeTarefa = "";

        while (true){
            Console.Write("Digite o nome do professor: ");
            teacherName = Console.ReadLine().Trim();

            var resultadoNome = ValidarProfessor(professores, teacherName);

            if (resultadoNome.Count == 1){
                
                sala = resultadoNome[0].turma;
                teacherName = resultadoNome[0].nome;
            }
            else{
                continue; // Volta pro começo do loop
            }

            Console.Write("Digite o nome da tarefa: ");
            nomeTarefa = Console.ReadLine().Trim();

            var resultadoTarefa = ValidarTarefa(tarefas, nomeTarefa);

            if (resultadoTarefa.Count == 1){
                nomeTarefa = resultadoTarefa[0].nome;
            }
            else{
                continue; 
            }

            Console.Write("Quando vai ser a demanda (Ex: 14:00): ");
            string time = Console.ReadLine();

            Console.Write("Digite a Quantidade referente à tarefa: ");
            int quantidade;

            while (!int.TryParse(Console.ReadLine().Trim(), out quantidade)){
                Console.WriteLine("Quantidade inválida! Digite um número válido:");
            }

            demandas.Add(new Demanda{
                horas = time,
                nomeProfessor = teacherName,
                salaProfessor = sala,
                nomeTarefa = nomeTarefa,
                tarefaQuantidade = quantidade
            });
            break; 
        }
    }

    public static List<Professor> ValidarProfessor(List<Professor> professores, string nomeProfessor){
        var resultado = professores
            .Where(prof => prof.nome.ToLower().Contains(nomeProfessor.ToLower()))
            .ToList();

        if (resultado.Count == 0){
            Console.Clear();
            Console.WriteLine("Nenhum professor encontrado com esse nome.");
            Console.WriteLine("Cadastre o professor ou tente novamente.\n");
            
            Thread.Sleep(1000);
        }
        else if (resultado.Count > 1){
            Console.Clear();
            Console.WriteLine("Vários professores encontrados com esse nome. Por favor, seja mais específico!\n");
            Thread.Sleep(1000);
        }

        return resultado;
    }

    public static List<Tarefa> ValidarTarefa(List<Tarefa> tarefas, string nomeTarefa){
        var resultado = tarefas
            .Where(tare => tare.nome.ToLower().Contains(nomeTarefa.ToLower()))
            .ToList();

        if (resultado.Count == 0){
            Console.Clear();
            Console.WriteLine("Nenhuma tarefa encontrada com esse nome.");
            Console.WriteLine("Cadastre a tarefa ou tente novamente.");
            Thread.Sleep(1000);
        }
        else if (resultado.Count > 1){
            Console.Clear();
            Console.WriteLine("Várias tarefas encontradas com esse nome. Por favor, seja mais específico!");
            Thread.Sleep(1000);
        }
        return resultado;
    }
}
