//6) Crie um programa em C# que simule as operações básicas de um caixa eletrônico.
//O programa deve permitir ao usuário consultar saldo, realizar saques e depósitos.
//Inicialmente, o saldo deve ser definido pelo usuário e o programa deve garantir que
//saques não ultrapassem o valor disponível na conta.

using System;
using System.Threading;

class Banco{
    // Atributos
    public double Saldo;

    // Construtor
    public Banco(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    // Método

    public void AdicionarSaldo(){
        double acrescimo;

        while (true) // Loop infinito até que um valor válido seja inserido
        {
            Console.Write("Digite o valor que deseja depositar: R$ ");
            
            // Tenta converter a entrada do usuário
            if (double.TryParse(Console.ReadLine(), out acrescimo) && acrescimo > 0){
                break;
            }

            Console.WriteLine("Valor inválido! Digite um número positivo.");
        }

        Saldo += acrescimo;
        Console.WriteLine($"Depósito realizado! Novo saldo: R$ {Saldo:F2}");
    }

    public void RemoverSaldo(){

        double sacar;
        while (true){
            
            Console.Write("Digite o valor que deseja depositar: R$ ");

            if (double.TryParse(Console.ReadLine(), out sacar) && sacar <= Saldo){
                break;
            }
            Console.Write($"Não é possivel sacar essa quantidade\nSeu saldo: R${Saldo}");
        }
            
        Saldo-=sacar;
        Console.WriteLine($"Saque realizado! Novo saldo: R$ {Saldo:F2}");
        
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"O saldo atual é de R${Saldo}");
    }

    public string menu(){
        Console.Clear();
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Banco do Brasil");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Ver saldo");
        Console.WriteLine(new string('-', 30));


        string opcao;
        while (true) {

            Console.Write("\nDigite a opção: ");
            opcao = Console.ReadLine();
            if(opcao == "1" || opcao == "2" || opcao=="3"){
                break;
            }
            Console.WriteLine("Opção invalida");
            Thread.Sleep(500);
            Console.Clear();
        }
        return opcao;
    }
}

class Program
{
    static void Main()
    {
        // Criando um objeto 
        Banco Gustavo = new Banco(0);
        Console.Clear();

        string pergunta;

        do {
            Console.Clear();
            int op = Convert.ToInt32(Gustavo.menu());
            switch(op){
                case 1:
                    Console.Clear();
                    Gustavo.AdicionarSaldo();
                    break;
                case 2:
                    Console.Clear();
                    Gustavo.RemoverSaldo();
                    break ;
                case 3:
                    Console.Clear();
                    Gustavo.ExibirInformacoes();
                    break ;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção Invalida!!");
                    break ;
            }

        Console.Write("\nQuer realizar outra operação? ");
        pergunta = Console.ReadLine();

        }while(pergunta == "sim");
        
    }
}
