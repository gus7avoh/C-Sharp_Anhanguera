using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    public static void Main() {
        Stack<char> inversor = new Stack<char>();
        bool palindromo = true;

        Console.Write("Digite a palavra: ");
        string palavra = Console.ReadLine().ToLower().Replace(" ", "");

        foreach (char letra in palavra) {
            inversor.Push(letra);
        }

        foreach (char letra in palavra) {
            if (letra != inversor.Pop()) {
                palindromo = false;
                break;
            }
        }

        Console.WriteLine($"A palavra \"{palavra}\" é um palíndromo: {palindromo}");
    }
}
