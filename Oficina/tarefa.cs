public class Tarefa{
        public string nome { get; set;}

        public string descricao { get; set;}

        public static void CadastrarTarefas(List<Tarefa> tarefas){
            Console.WriteLine("Cadastrando Tarefas");
            Console.Write("\nDigite o nome da tarefa: ");
            string nome = Console.ReadLine().Trim();
            nome = Validar.NomeValido(nome);

            Console.Write("\nDigite a descrição da tarefa: ");
            string descricao = Console.ReadLine().Trim();

            tarefas.Add(new Tarefa{
                nome = nome,
               
                descricao = descricao
            });
        }
    }