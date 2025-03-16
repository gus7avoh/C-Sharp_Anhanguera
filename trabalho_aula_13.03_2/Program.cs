/*Crie um programa em C# que:
1. Peça ao utilizador para inserir 5 nomes e os armazene numa lista.
2. Exiba todos os nomes inseridos.
3. Peça ao utilizador para informar um nome para pesquisar.
4. Verifique se o nome está na lista e exiba uma mensagem informando se foi encontrado
ou não.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program 
{
    public static void Main() 
    {
        List<string> Nomes = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1} nome: ");
            string nome = Console.ReadLine().Trim();
            Nomes.Add(nome);
        }
        Console.WriteLine("");
        int indice = 0;
        foreach (string nome in Nomes)
        {
            Console.WriteLine($"{indice + 1} Nome: {nome}");
            indice++;
        }
        Console.WriteLine("");
        Console.Write("Digite um Nome para pesquisa: ");
        string NomePesquisa = Console.ReadLine().Trim().ToLower(); 

    
        var resultadoNome = Nomes.Where(name => name.ToLower().Contains(NomePesquisa));
        if (resultadoNome.Any()){
            Console.Write($"\nO nome {NomePesquisa} foi encontrado!!\n");       
        }else{
            Console.WriteLine("\nO nome não foi encontrado!!");
        }
    }
}