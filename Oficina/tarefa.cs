public class Tarefa{
        public string nome { get; set;}

        public string descricao { get; set;}

        public string quantidade { get; set; }

    
        static void CadastrarTarefas(List<Tarefa> tarefas){
            Console.Write("Cadastrando Tarefas");
            Console.Write("Digite o nome da tarefa: ");
            string nome = Console.ReadLine().Trim();
            nome = Validar.NomeValido(nome);

            Console.Write("Digite a Quantidade referente a tarefa: ");
            string quantidade = Console.ReadLine().Trim();


            Console.Write("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine().Trim();

            tarefas.Add(new Tarefa{
                nome = nome,
                quantidade = quantidade,
                descricao = descricao
            });
        }
    }