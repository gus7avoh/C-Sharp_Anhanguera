using System;

class Program
{
    static void Main()
    {
        double valor = 0;
        double soma = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite a quantidade de itens: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor do item: "); // Ajustei o texto da mensagem
            valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            double valorProduto = quantidade* valor;
            soma += valorProduto;

            Console.Write("Tem outro produto? "); // Ajustei o texto da mensagem
            string pergunta = Console.ReadLine();

            if (pergunta != "sim"){
                break;
            }
        }
        Console.WriteLine("A soma eh: " + soma);
    }
}