using System;

public class Program{
	public static void Main(){
		List<int> lista1 =  new List<int>{1,2,3,4};
		List<int> lista2 =  new List<int>{1,2,3,4};

        bool iguais = Comparador(lista1,lista2);
		
        Console.WriteLine($"As listas são iguais? {iguais}");
	}

    public static bool Comparador(List<int> lista1, List<int> lista2)
    {
        if (lista1.Count == lista2.Count)
        {
            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[i] != lista2[i])
                {
                    Console.WriteLine("As listas não têm os mesmos elementos!!");
                    return false;
                }
            }
            Console.WriteLine("As listas têm os mesmos elementos!!");
            return true;
        }
        else
        {
            Console.WriteLine("As listas não têm os mesmos elementos!!");
            return false;
        }
    }
}