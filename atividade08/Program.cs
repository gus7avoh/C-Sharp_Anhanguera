//8) Crie um programa em C# que leia um valor em horas e o converta para segundos.
//O programa deve considerar que cada hora tem 3600 segundos e exibir o valor final
//convertido.
using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        Console.Write("Digite quantas horas: ");
        
        // Lê a entrada e converte corretamente usando o ponto como separador decimal
        float horas = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"\nA quantidade de segundos é: {horas * 3600}");
    }
}
