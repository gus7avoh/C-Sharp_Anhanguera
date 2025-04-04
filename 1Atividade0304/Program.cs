using System;
using System.Collections.Generic; // Importação necessária para Stack<T>

public class Program{
    public static void Main(){
        Stack<char> nome = new Stack<char>();

        Console.Clear();
        Console.Write("Digite a palavra: ");
        string Palavra = Console.ReadLine();

        
        foreach (char letra in Palavra){
            nome.Push(letra);  
        }
        
        Console.Write("Nome: ");
        foreach (char letra in Palavra){
            Console.Write($"{letra} ");
        }
        Console.WriteLine();
        
        Console.Write("Nome ao contrário: ");
        foreach (char letra in nome){
            Console.Write($"{letra} ");
        }
    }
}