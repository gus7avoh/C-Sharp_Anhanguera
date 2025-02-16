// Desenvolva um programa em C# que leia a largura e a altura de um retângulo e
// calcule o perímetro. A fórmula é Perímetro = 2 * (largura + altura). O programa deve
// exibir o valor do perímetro.

class Program{
    public static void Main(){
        float[] lados = new float[2];
        Console.Write("Digite a largura do retangulo: ");
        lados[0] =  Convert.ToSingle(Console.ReadLine());

        Console.Write("Digite a altura do retangulo: ");
        lados[1] =  Convert.ToSingle(Console.ReadLine());

        for (int i = 0; i < lados.Length; i++){
            lados[i] = lados[i] * 2;
        }

        Console.Write($"\nO perimetro eh: {lados[0] + lados[1]}");

    }
}