using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    static bool EmailValido(string email){
            try{
                var endereco = new MailAddress(email);
                return true;
            }
            catch{
                return false;
            }
    }

    static string IsTelefoneValido(string telefone){
        string number = telefone;
        
        while (true)
                {
                    number.Replace(".", "");
                    number.Replace("(", "");
                    number.Replace(")", "");
                    number.Replace("-", "");

                    if (string.IsNullOrWhiteSpace(number) || !number.All(char.IsDigit))
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

    static int ValidarNumero(int numeroEntrada, int opcao1, int? opcao2 = null, int? opcao3 = null, int? opcao4 = null){
        int numero = numeroEntrada;

        while (true)
        {
            bool valido = numero == opcao1 ||
                        (opcao2.HasValue && numero == opcao2.Value) ||
                        (opcao3.HasValue && numero == opcao3.Value) ||
                        (opcao4.HasValue && numero == opcao4.Value);
            if (valido)
            {
                break;
            }

            Console.Write("Opção inválida! Digite novamente --> ");

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, digite um número válido!");
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
                string name = Console.ReadLine().Trim();

                string number;
                Console.Write("Digite o telefone da pessoa: ");
                number = Console.ReadLine().Trim();

                number = IsTelefoneValido(number);

                string mail;
                while(true){
                    Console.Write("Digite o email da pessoa: ");
                    mail = Console.ReadLine().Trim();

                    if (EmailValido(mail)){
                        break;
                    }
                    else{
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

                    int pergunta;
                    while(true){
                        Console.Write("1 - Remover o nome \n");
                        Console.Write("2 - Remover o telefone\n");
                        Console.Write("-->");
                        pergunta = Convert.ToInt32(Console.ReadLine().Trim());

                        if (pergunta != 1 || pergunta != 2){
                            Console.Clear();
                            Console.Write("Opção invalida!!\n");
                        }else{
                            break;
                        }
                    }
                    
                    switch (pergunta){
                        case 1:
                            Console.Write("Digite o nome do contato que deseja remover: ");
                            string nomeRemover = Console.ReadLine().ToLower().Trim();

                            int removidos = ListaContatos.RemoveAll(contato => contato.Nome.ToLower() == nomeRemover);

                            if (removidos > 0){
                                Console.WriteLine($"Contato {nomeRemover} removido com sucesso!");
                            }else{
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
                    int p = Convert.ToInt32(Console.ReadLine()); //////////// criar um metodo que recebe como parametro quais numeros vai ser validados usando a estrutura que eu ja criei

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
                            NumeroPesquisa = IsTelefoneValido(NumeroPesquisa);

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
