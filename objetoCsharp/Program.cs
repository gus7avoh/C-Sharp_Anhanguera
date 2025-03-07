using System;
using System.Collections.Generic;
using System.Linq;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}


class Program
{
    static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        while (true)
        {
            Console.Write("Digite o nome da pessoa ou 'sair' para encerrar: ");
            string nome = Console.ReadLine();
            if (nome.ToLower() == "sair") break;

            Console.Write("Digite a idade da pessoa: ");
            bool isAgeValid = int.TryParse(Console.ReadLine(), out int idade);
            if (!isAgeValid)
            {
                Console.WriteLine("Idade inválida. Por favor, tente novamente.");
                continue;
            }

            pessoas.Add(new Pessoa(nome, idade));
        }

        Console.WriteLine("\nLista de Pessoas:");
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }

        // Pesquisa
        Console.Write("\nDeseja fazer uma pesquisa? (Sim/Não): ");
        string pesquisa = Console.ReadLine().ToLower();
        if (pesquisa == "sim")
        {
            Console.Write("Pesquisar por (Nome/Idade): ");
            string tipoPesquisa = Console.ReadLine().ToLower();

            if (tipoPesquisa == "nome")
            {
                Console.Write("Digite o nome: ");
                string nomePesquisa = Console.ReadLine();
                var resultadoNome = pessoas.Where(p => p.Nome.ToLower().Contains(nomePesquisa.ToLower()));
                foreach (var pessoa in resultadoNome)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
                }
            }
            else if (tipoPesquisa == "idade")
            {
                Console.Write("Digite a idade: ");
                bool isSearchAgeValid = int.TryParse(Console.ReadLine(), out int idadePesquisa);
                if (!isSearchAgeValid)
                {
                    Console.WriteLine("Idade inválida.");
                }
                else
                {
                    var resultadoIdade = pessoas.Where(p => p.Idade == idadePesquisa);
                    foreach (var pessoa in resultadoIdade)
                    {
                        Console.WriteLine($"Nome: {pessoa.Nome}, Idade {pessoa.Idade}");
                    }
                }
            }
        }else{
            Console.WriteLine("Opção de pesqsuisaa inválida.");
        }
    }
}

