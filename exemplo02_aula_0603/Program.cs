class Program{
    public static void Main(string[] args){
        List<int> numeros = new List<int>();

       Console.WriteLine("Digite os numeros que deseja adicionar a lista. Digite 'sair' para finalizar.");
       while(true){
            string entrada = Console.ReadLine();

            if(entrada.ToLower()== "sair"){
                break;
            }
            if (int.TryParse(entrada, out int numero)){
                numeros.Add(numero);
                Console.WriteLine($"Numero {numero} adicionado");
            }else{
                Console.WriteLine("Por favor, digite um numero valido ou 'sair' para finalizar");
            }
       }
    }
}