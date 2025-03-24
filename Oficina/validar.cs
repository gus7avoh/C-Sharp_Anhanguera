
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Validar{
    public static string IsTelefoneValido(string telefone){
            string number = telefone;
            while (true){
                number = number.Replace(".", "") 
                               .Replace("(", "") 
                               .Replace(")", "")
                               .Replace("-", "")
                               .Replace(" ", ""); 

                if (!number.Any() || !number.All(char.IsDigit) || number.Length != 11 ){
                    Console.Clear();
                    Console.WriteLine("Número inválido, digite novamente!\n");
                    Console.Write("Digite o telefone da pessoa: ");
                    number = Console.ReadLine().Trim();
                }
                else{
                    break;
                }
            }
            return number;
        }

    public static string NomeValido(string nome)
    {
        string nomeDigitado = nome;

        while (string.IsNullOrWhiteSpace(nomeDigitado)){
            Console.Clear();
            Console.WriteLine("Nome inválido! O nome não pode ser vazio ou conter apenas espaços.");
            Console.Write("Digite o nome da pessoa: ");
            nomeDigitado = Console.ReadLine().Trim();
        }

        return nomeDigitado;
    }


    public static bool validarIndice(string indice, int IndiceFinal){
        bool Enumero = int.TryParse(indice, out int resposta);
        if(!Enumero){
            return false;
        }
        for (int i = 1; i <= IndiceFinal; i++ ){
            if(resposta == i){
                return true;
            }
        }
        return false;
    }
}


