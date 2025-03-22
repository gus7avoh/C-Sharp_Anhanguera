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
                    break;
                case 2:
                    Console.Write("Criando uma nova demanda");
                    Demanda.CriarDemanda(demandas, professores);
                    break;
                case 3:
                    break;
                case 4:
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