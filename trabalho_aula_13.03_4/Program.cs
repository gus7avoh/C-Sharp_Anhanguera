using System.Collections.Generic;

class Program{

    static void Main(string[] args){

        List<int> numeros = new List<int>();
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        Console.Clear();
        for(int i=0; i < 10; i++){
            Console.Write($"Digite o {i+1} Nuemro: ");
            int n = Convert.ToInt32(Console.ReadLine());
            numeros.Add(n);
        }

        foreach(int num in numeros){
            if(num % 2 == 0){
                pares.Add(num);
            }else{
                impares.Add(num);
            }
        }

        Console.WriteLine("\n\nNumeros iseridos: ");
        foreach(int n in numeros){
            Console.Write($"{n} ");
        }

        Console.WriteLine("\n\nNumeros impares: ");
        foreach(int n in impares){
            Console.Write($"{n} ");
        }

        Console.WriteLine("\n\nNumeros pares: ");
        foreach(int n in pares){
            Console.Write($"{n} ");
        }
    }
}