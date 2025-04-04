using System;
using System.Collections.Generic;
using System.Linq;

public class Program{
    public static void Main(){
        List<string> nomes = new List<string>();

        for (int i = 0; i < 5; i++){
            Console.Write($"Digite o {i+1}º nome: ");
            nomes.Add(Console.ReadLine().ToLower());
        }

        int contador = 1;
        Console.WriteLine("\nLista de nomes:");
        foreach (string name in nomes){
            Console.WriteLine($"{contador} - {name}");
            contador++;
        }

        Console.Write("\nDigite o nome que deseja pesquisar: ");
        string nomePesquisa = Console.ReadLine().ToLower();

        var resultado = nomes.Where(palavra => palavra.Contains(nomePesquisa)).ToList();

        if (resultado.Count > 0){
            Console.WriteLine("\nNomes encontrados:");
            foreach(string p in resultado){
                Console.WriteLine(p);
            }
        } else {
            Console.WriteLine("\nNenhuma palavra encontrada!!");
        }
    }
}
