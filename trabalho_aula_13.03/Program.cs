using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

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
    static bool EmailValido(string email)
    {
        try
        {
            var endereco = new MailAddress(email);
            return true;
        }
        catch
        {
            return false;
        }
    }

    static string IsTelefoneValido(string telefone)
    {
        string number = telefone;

        while (true)
        {
            number = number.Replace(".", "")
                           .Replace("(", "")
                           .Replace(")", "")
                           .Replace("-", "")
                           .Replace(" ", "");

            if (!number.Any() || !number.All(char.IsDigit))
            {
                Console.Clear();
                Console.WriteLine("Número inválido, digite novamente!\n");
                Console.Write("Digite o telefone da pessoa: ");
                number = Console.ReadLine().Trim();
            }
            else
            {
                break;
            }
        }
        return number;
    }

    static string NomeValido(string nome)
    {
        string nomeDigitado = nome;

        while (string.IsNullOrWhiteSpace(nomeDigitado))
        {
            Console.Clear();
            Console.WriteLine("Nome inválido! O nome não pode ser vazio ou conter apenas espaços.");
            Console.Write("Digite o nome da pessoa: ");
            nomeDigitado = Console.ReadLine().Trim();
        }

        return nomeDigitado;
    }

    static int ValidarNumero(int numeroEntrada, int opcao1, int? opcao2 = null, int? opcao3 = null, int? opcao4 = null, int? opcao5 = null)
    {
        int numero = numeroEntrada;

        while (true)
        {
            bool valido = (numero == opcao1) ||
                        (opcao2.HasValue && numero == opcao2.Value) ||
                        (opcao3.HasValue && numero == opcao3.Value) ||
                        (opcao4.HasValue && numero == opcao4.Value) ||
                        (opcao5.HasValue && numero == opcao5.Value);

            if (valido)
            {
                break;
            }
            else
            {
                Console.Write("Opção inválida! Digite novamente --> ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out numero))
                {
                    Console.WriteLine("Por favor, digite um número válido!");
                }
            }
        }

        return numero;
    }

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

            string respostaInput = Console.ReadLine();
            if (!int.TryParse(respostaInput, out int resposta))
            {
                Console.WriteLine("Por favor, digite um número válido!");
                continue;
            }

            resposta = ValidarNumero(resposta, 1, 2, 3, 4, 5);

            switch (resposta)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Digite o nome da pessoa: ");
                    string nameInput = Console.ReadLine().Trim();
                    string name = NomeValido(nameInput);

                    Console.Write("Digite o telefone da pessoa: ");
                    string number = Console.ReadLine().Trim();
                    number = IsTelefoneValido(number);

                    string mail;
                    while (true)
                    {
                        Console.Write("Digite o email da pessoa: ");
                        mail = Console.ReadLine().Trim();

                        if (EmailValido(mail))
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Email inválido!");
                        }
                    }

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

                    Console.Write("1 - Remover pelo nome \n");
                    Console.Write("2 - Remover pelo telefone\n");
                    Console.Write("-->");
                    string perguntaInput = Console.ReadLine().Trim();
                    if (!int.TryParse(perguntaInput, out int pergunta))
                    {
                        Console.WriteLine("Entrada inválida. Digite novamente.");
                        break;
                    }

                    pergunta = ValidarNumero(pergunta, 1, 2);

                    switch (pergunta)
                    {
                        case 1:
                            Console.Write("Digite o nome do contato que deseja remover: ");
                            string nomeRemover = NomeValido(Console.ReadLine().Trim()).ToLower();

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
                            numeroRemover = IsTelefoneValido(numeroRemover);

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
                    string pesquisaInput = Console.ReadLine().Trim();
                    if (!int.TryParse(pesquisaInput, out int p))
                    {
                        Console.WriteLine("Entrada inválida. Digite novamente.");
                        break;
                    }

                    p = ValidarNumero(p, 1, 2);

                    switch (p)
                    {
                        case 1:
                            Console.Write("Digite o nome: ");
                            string nomePesquisa = Console.ReadLine();
                            var resultadoNome = ListaContatos.Where(contato => contato.Nome.ToLower().Contains(nomePesquisa.ToLower()));

                            if (resultadoNome.Any())
                            {
                                int cont = 1;
                                foreach (var contato in resultadoNome)
                                {
                                    Console.WriteLine($"{cont}° Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
                                    cont++;
                                }
                            }
                            else
                            {
                                Console.Write("Nenhum resultado encontrado!! ");
                            }

                            break;

                        case 2:
                            Console.Write("Digite o Numero: ");
                            string NumeroPesquisa = Console.ReadLine();
                            NumeroPesquisa = IsTelefoneValido(NumeroPesquisa);

                            var resultadoNumero = ListaContatos.Where(contato => contato.Telefone == NumeroPesquisa);

                            if (resultadoNumero.Any())
                            {
                                int c = 1;
                                foreach (var contato in resultadoNumero)
                                {
                                    Console.WriteLine($"{c}° Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
                                    c++;
                                }
                            }
                            else
                            {
                                Console.Write("Nenhum resultado encontrado!! ");
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
