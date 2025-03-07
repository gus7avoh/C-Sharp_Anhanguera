using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());
        int[] numeros = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Clear();
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Clear();
        Console.WriteLine("Números inseridos:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"{numeros[i]} ");
        }

        Console.WriteLine();
    }
}
