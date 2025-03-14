using System;
using System.Collections.Generic;
using System.Linq;

public class Contatos
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contatos(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}

class Program
{
    static void Main()
    {
        List<Contatos> ListaContatos = new List<Contatos>();
        bool run = true;

        while (run)
        {
            Console.WriteLine("\n");
            Console.WriteLine("1 - Adicionar Contato");
            Console.WriteLine("2 - Exibir contatos");
            Console.WriteLine("3 - Remover contatos");
            Console.WriteLine("4 - Buscar contatos");
            Console.WriteLine("5 - Sair\n");
            Console.Write("--> ");

            int resposta;
            if (!int.TryParse(Console.ReadLine(), out resposta))
            {
                Console.WriteLine("Opção inválida! Digite um número.");
                continue;
            }

            switch (resposta)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Digite o nome da pessoa: ");
                    string name = Console.ReadLine();

                    Console.Write("Digite o telefone da pessoa: ");
                    string number = Console.ReadLine();

                    Console.Write("Digite o email da pessoa: ");
                    string mail = Console.ReadLine();

                    ListaContatos.Add(new Contatos(name, number, mail));
                    Console.WriteLine("\nContato adicionado com sucesso!");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Os contatos adicionados são:\n");

                    if (ListaContatos.Count == 0)
                    {
                        Console.WriteLine("Nenhum contato encontrado.");
                    }
                    else
                    {
                        int contador = 1;
                        foreach (Contatos contato in ListaContatos)
                        {
                            Console.WriteLine($"{contador}° Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
                            contador++;
                        }
                    }
                    break;

                case 3:
                    Console.Clear();

                    Console.Write("1 - Remover o nome \n");
                    Console.Write("2 - Remover o telefone\n");
                    Console.Write("-->");
                    int pergunta = Convert.ToInt32(Console.ReadLine());

                    switch (pergunta){
                        case 1:
                            Console.Write("Digite o nome do contato que deseja remover: ");
                            string nomeRemover = Console.ReadLine().ToLower();

                            int removidos = ListaContatos.RemoveAll(contato => contato.Nome.ToLower() == nomeRemover);

                            if (removidos > 0)
                            {
                                Console.WriteLine($"Contato {nomeRemover} removido com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Contato não encontrado.");
                            }
                            break;
      
                        case 2:
                            Console.Write("Digite o numero do contato: ");
                            string numeroRemover = Console.ReadLine();

                            int NumRemovidos = ListaContatos.RemoveAll(contato => contato.Telefone == numeroRemover);

                            if (NumRemovidos > 0)
                            {
                                Console.WriteLine($"Contato com numero {numeroRemover} removido com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Contato não encontrado.");
                            }
                            break;
                    }
                    break;
                case 4:
                    
                    Console.Write("1 - Pesquisar por Nome: \n");
                    Console.Write("2 - Pesquisar Por telefone\n");
                    Console.Write("-->");
                    int p = Convert.ToInt32(Console.ReadLine());

                    switch (p){
                        case 1:
                            Console.Write("Digite o nome: ");
                            string nomePesquisa = Console.ReadLine();
                            var resultadoNome = ListaContatos.Where(contato => contato.Nome.ToLower().Contains(nomePesquisa.ToLower()));
                            int cont = 0;
                            foreach (var contato in resultadoNome)
                            {
                                Console.WriteLine($"{cont}° Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
                                cont++;
                            }
                            break;
  
                        case 2:
                            Console.Write("Digite o Numero: ");
                            string NumeroPesquisa = Console.ReadLine();
                            var resultadoNumero = ListaContatos.Where(contato => contato.Nome.ToLower().Contains(NumeroPesquisa.ToLower()));
                            int c = 0;
                            foreach (var contato in resultadoNumero)
                            {
                                Console.WriteLine($"{c}° Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
                                c++;
                            }
                            break;
                    }
                    break;
                case 5:
                    run = false;
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!!");
                    break;
            }
        }
    }
}
