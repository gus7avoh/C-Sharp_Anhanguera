using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [] numeros = new int [10];
        int controle = 0;
        
        for (int i=0; i < numeros.Length; i++){
            Console.Write($"Escreva o {i+1} numero: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        Console.Write("Escreva o numero que deseja buscar: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i=0; i < numeros.Length; i++){
            if (numeros[i] == num){
                Console.Write($"O numero {num} esta na posiscao {i}");
                controle = 1;
                break;
            }
        } 
        if (controle == 0){
            Console.Write("Nao foi encontrado");
        }
    }
}
