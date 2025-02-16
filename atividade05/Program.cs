using System;
class Program{
    static void Main(){
        Console.Write("Digiete o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digiete o operador: ");
        string operador = Console.ReadLine();

        Console.Write("Digiete o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (numero1 > 0 && operador == "/" && numero2 == 0){
            Console.Write("Não é possivel fazer divisão por 0");
        }

        else if (operador == "+"){
            Console.Write($"{numero1} {operador} {numero2} = {numero1 + numero2}");
        }
        else if(operador == "-"){
            Console.Write($"{numero1} {operador} {numero2} = {numero1 - numero2}");
        }
        else if(operador == "*"){
            Console.Write($"{numero1} {operador} {numero2} = {numero1 * numero2}");
        }
        else if(operador == "/"){
            Console.Write($"{numero1} {operador} {numero2} = {numero1 / numero2}");
        }
        else{
            Console.Write("Operador Invalido");
        }
    }
    
}