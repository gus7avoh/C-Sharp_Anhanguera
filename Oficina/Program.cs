using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

class Program
{

    public class Professor{
        public string nome { get; set;}
        public string telefone { get;set; }
        public string turma { get; set; }

        public Professor(string Nome, string Telefone, string Turma){

            telefone = Telefone;
            nome = Nome;
            turma = Turma;
            
        }

    }

    public class Tarefa{
        public string nome { get; set;}

        public string horario { get; set;}

        public string quantidade { get; set; }

    }
    
    public static void Main(){
        List<Professor> professores = new List<Professor>();
        //Adicioar os professore
        //cadastro de demanda 
        /*atividades diarias -  o sistema deve ser capaz de me informar as demandas do dia e quais
        professores estao vinculadas a essas demandas, mostrando a sala de aula e informacoes pertinetes*/

        
        
    }

    static int Mostrar_menu(){
        Console.Write("1 - Acessar o painel de demandas");
        Console.Write("2 - Cadastrar Tarefa");
        Console.Write("3 - Cadastrar professor");
        Console.Write("4 - Sair");
        Console.Write("-->");
        int resposta = Convert.ToInt32(Console.ReadLine());

        return resposta;
    }

    static void CadastrarTarefas(){
        Console.Write("Cadastrando Tarefas");
    }

    static void CadastrarProfessor(List<Professor> professores){
        Console.Write("Cadastrando Professor\n\n");
        Console.Write("Digite o Nome do professor: ");
        string nome = Console.ReadLine().Trim();
        nome = NomeValido(nome);

        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine().Trim();
        
        telefone = IsTelefoneValido(telefone);

        Console.Write("Digite o Nome do professor: ");
        string turma = Console.ReadLine().Trim();

        professores.Add(new Professor(nome, telefone, turma));
    }

    static string IsTelefoneValido(string telefone)
    {
        string number = telefone;

        while (true)
        {
            number = number.Replace(".", "") 
                           .Replace("(", "") 
                           .Replace(")", "")
                           .Replace("-", "")
                           .Replace(" ", "");

            if (!number.Any() || !number.All(char.IsDigit))
            {
                Console.Clear();
                Console.WriteLine("Número inválido, digite novamente!\n");
                Console.Write("Digite o telefone da pessoa: ");
                number = Console.ReadLine().Trim();
            }
            else
            {
                break;
            }
        }
        return number;
    }

    static string NomeValido(string nome)
    {
        string nomeDigitado = nome;

        while (string.IsNullOrWhiteSpace(nomeDigitado))
        {
            Console.Clear();
            Console.WriteLine("Nome inválido! O nome não pode ser vazio ou conter apenas espaços.");
            Console.Write("Digite o nome da pessoa: ");
            nomeDigitado = Console.ReadLine().Trim();
        }

        return nomeDigitado;
    }


    static int Mostrar_Demandas(){
        Console.Write("1 - Visualisar as demandas do dia");
        Console.Write("2 - Adicionar demanda");
        Console.Write("3 - Remover demanda");
        Console.Write("4 - Modificar demanda");// permite buscar pela demanda na lista de demandas diarias e modificar a demanda necessaria.
        Console.Write("5 - Sair");
        Console.Write("-->");
        int resposta = Convert.ToInt32(Console.ReadLine());

        return resposta;
    }

    static bool validarIndice(string indice, int IndiceFinal){
        bool Enumero = int.TryParse(indice, out int resposta);
        if(!Enumero){
            return false;
        }
        for (int i = 1; i <= IndiceFinal; i++ ){
            if(resposta == i){
                return true;
            }
        }
        return false;
    }




}