using System;
using System.Collections.Generic;
class Program{
    public static void Main(){

        Stack<int> numeros = new Stack<int>();

        for(int i = 0; i <= 5;  i++){
            numeros.Push(i);
        }
        Console.WriteLine($"O ultimo elemento eh: {numeros.Peek()}\n");

        foreach(int num in numeros){
            Console.WriteLine(num); 
        }

        while(numeros.Count() > 0){
            Console.WriteLine($"Removendo: {numeros.Pop()}");
        }
    }
}
public class Pessoa{
    public string Nome {get; set;}
    public string Telefone {get;  set;}

    Pessoa (string nome, String telefone){
        Nome = nome;
        Telefone = telefone;
    }
}