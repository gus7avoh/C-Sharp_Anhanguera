using System;

class Program
{
    static void Main()
    {
        int idade;
        char sexo;
        int soma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            if (sexo == 'm')
            {
                soma += idade;
            }
        }
        Console.WriteLine("A soma eh: " + soma);
    }
}