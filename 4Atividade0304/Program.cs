using System;

public class Program{
	public static void Main(){
		List<int> numeros  = new List<int>();
		List<int> pares  = new List<int>();

		for(int i = 1; i < 11; i ++){
			numeros.Add(i);
		}

		foreach(int num in numeros){
			if(num%2 == 0){
				pares.Add(num);
			}
		}
		foreach(int num in pares){
			Console.WriteLine($"{num} ");
		}
	}
}