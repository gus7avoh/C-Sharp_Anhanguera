using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<string> tarefas = new List<string>(); 
        bool run = true;
        
        while (run)
        {
            int resposta = 0;
            Console.WriteLine("");
            Console.WriteLine($"Tarefas: {tarefas.Count}");
            Console.WriteLine("1 - Adicionar uma nova tarefa");
            Console.WriteLine("2 - Exibir tarefas");
            Console.WriteLine("3 - Remover uma tarefa");
            Console.WriteLine("4 - Sair");
            Console.Write("--> ");

            bool entradaValida = int.TryParse(Console.ReadLine().Trim(), out resposta);

            if (!entradaValida || !new List<int> { 1, 2, 3, 4 }.Contains(resposta))
            {
                Console.WriteLine("Digite um valor válido");
            }
            else
            {
                switch (resposta)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite a tarefa: ");
                        tarefas.Add(Console.ReadLine().Trim());
                        Console.WriteLine("Tarefa adicionada.");
                        break;

                    case 2:
                        Console.Clear();
                        if (tarefas.Count == 0)
                        {
                            Console.WriteLine("Nenhuma tarefa para exibir.");
                        }
                        else
                        {
                            int contador = 1;
                            foreach (string t in tarefas)
                            {
                                Console.WriteLine($"{contador}° {t}");
                                contador++;
                            }
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (tarefas.Count == 0)
                        {
                            Console.WriteLine("Nenhuma tarefa para remover.");
                        }
                        else
                        {
                            Console.Write("Digite o índice da tarefa a ser removida: ");
                            int indice;
                            if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= tarefas.Count)
                            {
                                tarefas.RemoveAt(indice - 1); 
                                Console.WriteLine("Tarefa removida.");
                            }
                            else
                            {
                                Console.WriteLine("Índice inválido.");
                            }
                        }
                        break;

                    case 4:
                        run = false;    
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
