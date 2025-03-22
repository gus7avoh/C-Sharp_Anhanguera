using System.Drawing;
using System.Dynamic;

public class Demanda{
    public string horas {get; set;}
    public string nomeProfessor {get; set; }

    public string salaProfessor { get; set; }

    public string nomeTarefa {get; set;}

    public int tarefaQuantidade {get; set;}

    
    public static void CriarDemanda(List<Demanda> demandas, List<Professor> professores){
        Console.Write("Quando vai ser a demanda (Ex: 14:00): ");
        string time = Console.ReadLine();

        string teacherName = "";
        string sala = "";

        while (true)
        {
            Console.Write("Digite o nome do professor: ");
            teacherName = Console.ReadLine();

            var resultadoNome = professores
                .Where(prof => prof.nome.ToLower().Contains(teacherName.ToLower()))
                .ToList();

            if (resultadoNome.Count == 1){

                sala = resultadoNome[0].turma;
                teacherName = resultadoNome[0].nome;
                break; 
            }
            else if (resultadoNome.Count > 1){
                Console.Clear();
                Console.WriteLine("\nForam encontrados vários professores com esse nome. Por favor, seja mais específico!");
            }
            else{
                Console.Clear();
                Console.WriteLine("\nNenhum professor encontrado com esse nome. Tente novamente.");
            }
        }

        Console.Write("\nDigite o nome da tarefa: ");
        string nomeTarefa = Console.ReadLine().Trim();
        nomeTarefa = Validar.NomeValido(nomeTarefa);

        Console.Write("\nDigite a Quantidade referente à tarefa: ");
        int quantidade;
        
        while (!int.TryParse(Console.ReadLine().Trim(), out quantidade)){
            Console.WriteLine("Quantidade inválida! Digite um número válido:");
        }

        demandas.Add(new Demanda
        {
            horas = time,
            nomeProfessor = teacherName,
            salaProfessor = sala,
            nomeTarefa = nomeTarefa,
            tarefaQuantidade = quantidade
        });

        Console.WriteLine("\nDemanda criada com sucesso!\n");

    }
}