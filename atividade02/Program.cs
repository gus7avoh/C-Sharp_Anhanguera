using System;

class Program
{
    static void Main()
    {
        double nota;
        double soma = 0;
        

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite a nota: ");
             nota = Convert.ToDouble(Console.ReadLine());
            soma += nota;
            Console.Clear();
           
        }
        Console.WriteLine("A media dia eh: " + soma/3);
    }
}