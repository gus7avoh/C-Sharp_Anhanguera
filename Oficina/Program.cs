using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

class Program
{
    public static void Main(){
        List<Professor> professores = new List<Professor>();
        List<Tarefa> tarefas = new List<Tarefa>();
        List<Demanda> demandas = new List<Demanda>();

            bool run = true;
            while(run == true){
                Console.Clear();  
                int indice = Menus.Mostrar_menu();
            switch (indice){
                case 1:
                    Console.Clear();
                    Console.Write("Acessando o painel de demandas\n\n");
                    Loop_Demanda(professores, demandas, tarefas);
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Acessando o Cadastro de Tarefa\n");
                    Tarefa.CadastrarTarefas(tarefas);
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Acessando o Cadastro de professor\n");
                    Professor.CadastrarProfessor(professores);
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Saindo\n");
                    run = false;
                    break;
                default:
                    Console.Clear();
                    Console.Write("Indice invalido!");
                    break;
            }
        }
    }
    public static void Loop_Demanda(List<Professor>professores, List<Demanda>demandas, List<Tarefa>tarefas){
        bool run_demandas = true;

        while(run_demandas == true){
            Console.Clear();
            int indice = Menus.Mostrar_Demandas();
            switch(indice){
                case 1:
                    Console.Clear();
                    Console.Write("Demandas do dia\n\n");
                    int contador = 1;
                    foreach(Demanda D in demandas){
                        if(D.tarefaQuantidade > 0){
                            Console.Write($"{contador}° - Horario: {D.horas} Tarefa: {D.nomeTarefa} Professor: {D.nomeProfessor} Sala: {D.salaProfessor} Quantidade: {D.tarefaQuantidade}\n");
                        }else{
                            Console.Write($"{contador}° - Horario: {D.horas} Tarefa: {D.nomeTarefa} Professor: {D.nomeProfessor} Sala: {D.salaProfessor}\n");
                        } 
                        contador ++;
                    }
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Criando uma nova demanda\n\n");
                    Demanda.CriarDemanda(demandas, professores, tarefas);
                    Console.WriteLine("\nDemanda criada com sucesso!\n");
                    break;
                case 3:
                    Console.WriteLine("\nRemovendo demanda");
                    Console.WriteLine("Digite o id da tarefa que deseja remover: ");

                    int id;
                    while (true){
                        Console.Write("--> ");
                        if (!int.TryParse(Console.ReadLine(), out id)){
                            Console.WriteLine("Digite um número válido!!");
                        }
                        else if (id < 1 || id >= demandas.Count){
                            Console.WriteLine("ID não encontrado! Tente novamente.");
                        }
                        else{
                            break;
                        }
                    }
                    demandas.RemoveAt(id-1);
                    Console.WriteLine("Demanda removida com sucesso!");
                    break;
                case 4 :
                    Console.Clear();
                    Console.WriteLine("Buscar demandas\n");
                    Console.Write("Digite o indice da demanda que deseja inspecionar: ");
                    int BuscarID;
                    while(true){
                            if(!int.TryParse(Console.ReadLine(), out BuscarID)){
                                Console.WriteLine("Digite um id valido!! ");
                            }else if (BuscarID <  1 || BuscarID > demandas.Count){
                                Console.Clear();
                                Console.WriteLine("O id não existe na lista!! ");
                                Console.WriteLine("--> ");
                            }else{
                                break;
                            }
                        }
                        Console.WriteLine($"Detalhes da demanda - {BuscarID}°\n");
                        Console.WriteLine("Professor\n");
                        Console.Write($"Nome Professor: {demandas[BuscarID-1].nomeProfessor}\n");
                        Console.Write($"Sala: {demandas[BuscarID-1].salaProfessor}\n");
                        Console.Write($"Telefoene: {professores[BuscarID-1].telefone}\n\n");
                        Console.WriteLine("Tarefa\n");
                        Console.Write($"Nome Tarefa: {demandas[BuscarID-1].nomeTarefa}\n");
                        Console.Write($"Quantidade tarefa: {demandas[BuscarID-1].tarefaQuantidade}\n");
                        Console.Write($"Horario: {demandas[BuscarID-1].horas}\n");  
                        Console.Write($"Descrição: {tarefas[BuscarID-1].descricao}\n");

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Saindo..");
                    run_demandas = false;
                    break;
                default:
                    break;
            }
        }
    }
}