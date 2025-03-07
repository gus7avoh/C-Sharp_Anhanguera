using System;

public class HelloWorld
{
    static double salario = 0; // Variável de classe

    public static void depositar()
    {   
        Console.Write("Digite o valor que deseja depositar: ");
        double deposito = Convert.ToDouble(Console.ReadLine());
        if(deposito > 0){
        salario += deposito;
        
        }else{
            Console.Write("Valor inválido!");   
        }
    }


    public static void sacar()
    {
        Console.Write("Digite o valor que deseja sacar: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        if (saque <= salario)
        {
            salario -= saque;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!\n");
        }
    }


    public static void verSaldo(){
        Console.Write($"Saldo atual: {salario}\n");
    }  


    public static void Main()
    {
        Console.Clear();
        Console.Write("Digite o seu salario: ");
        salario = Convert.ToDouble(Console.ReadLine());

        string pergunta;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Ver o saldo");
            Console.WriteLine("4 - Sair\n\n");
            Console.Write("Opção: ");
            pergunta = Console.ReadLine();

            switch (pergunta)
            {
                case "1":
                    Console.Clear();
                    depositar();
                    break;
                case "2":
                    Console.Clear();
                    sacar();
                    break;
                case "3":
                    Console.Clear();
                    verSaldo();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (pergunta != "4");
    }
}
