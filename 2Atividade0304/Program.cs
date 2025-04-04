using System;

public class Program{
	public static void Main(){
		
		bool play = true;
		while ( play == true){
			List<string> tarefas = new List<string>();
			Console.WriteLine("1 - Adicionar Tarefa");
			Console.WriteLine("2 - Listar todas as tarefas");
			Console.WriteLine("3 - Remover Tarefa");
			Console.WriteLine("4 - Sair");
			int resposta = Convert.ToInt32(Console.ReadLine());
			
			switch(resposta){
				case 1: 	
					Console.Clear();
					Console.WriteLine("Adicionando Tarefa");	
					Console.Write("Digite a tarefa: ");
					tarefas.Add(Console.ReadLine().ToLower());
					
					break;
				case 2: 
					Console.Clear();
					Console.WriteLine("Listando");
					int contador = 1;
					foreach( string tar in tarefas){
						Console.WriteLine($"{contador} {tar}");
						contador ++;
					}
					break;
				case 3: 
					Console.Clear();
					Console.WriteLine("Remover Elemento");
					Console.Write("Digite o indice da tarefa que deseja remover: ");
					int number = Convert.ToInt32(Console.ReadLine());
					tarefas.RemoveAt(number);
					
					break;
				case 4: 
					Console.Clear();
					Console.Write("Saindo...");
					play = false;
					break;
			}
		}
	}

}