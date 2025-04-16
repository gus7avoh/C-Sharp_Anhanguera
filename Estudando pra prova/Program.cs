using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        List<string> nomes = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o nome: ");
            nomes.Add(Console.ReadLine());
        }

        Console.WriteLine("\nLista completa:");
        foreach (string name in nomes)
        {
            Console.WriteLine(name);
        }

        Console.Write("\nDigite o nome para pesquisar: ");
        string NomePesquisa = Console.ReadLine().ToLower();

        var pesquisa = nomes.Where(n => n.ToLower().Contains(NomePesquisa)).ToList();

        int indice = 0;
        if (pesquisa.Count == 0)
        {
            Console.WriteLine("Nenhum nome encontrado.");
        }
        else{
            Console.WriteLine("Nomes encontrados:");
            foreach (string n in pesquisa){
                Console.WriteLine(indice+"-"+n);
                indice++;
            }
        }

        if (pesquisa.Count > 0){
                Console.WriteLine("Digite o Indice para deletar: ");
                int deletar = Convert.ToInt32(Console.ReadLine());

                
        }


        
    }
}
