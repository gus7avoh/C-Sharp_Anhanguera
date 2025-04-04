using System;
using System.Collections.Generic;

public class Program{
    public static void Main(){
        List<int> numeros = new List<int>{1,7,3,4,5,2};

        List<int> numerosordenados = Ordenador(numeros);
        
        foreach(int element in numerosordenados){
            Console.WriteLine(element);
        }
    }
    public static List<int> Ordenador(List<int> numeros){
        numeros.Sort(); 
        return numeros;
    }
}
