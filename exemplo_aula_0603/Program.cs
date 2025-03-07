class Program{
    public static void Main(string[] args){
        List<int> numeros = new List<int>();

        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);

        foreach(int numero in numeros){
            Console.Write(numero);
        }
    }
}