public class Menus{
     public static int Mostrar_menu(){
        Console.WriteLine("1 - Acessar o painel de demandas");
        Console.WriteLine("2 - Cadastrar Tarefa");
        Console.WriteLine("3 - Cadastrar professor");
        Console.WriteLine("4 - Sair");
        Console.Write("-->");
        int indice;
        string resposta = Console.ReadLine();
        while(true){
            if (!Validar.validarIndice(resposta, 4)){
            Console.WriteLine("Indice incorreto!! ");
            Console.Write("-->");
            resposta = Console.ReadLine();
        }else{
            indice = Convert.ToInt32(resposta);
            break;
        }}
        return indice;
    }

    public static int Mostrar_Demandas(){
        Console.WriteLine("1 - Visualisar as demandas do dia");
        Console.WriteLine("2 - Adicionar demanda");
        Console.WriteLine("3 - Remover demanda");
        Console.WriteLine("4 - Modificar demanda");// permite buscar pela demanda na lista de demandas diarias e modificar a demanda necessaria.
        Console.WriteLine("5 - Sair");
        Console.Write("-->");
        int indice;
        string resposta = Console.ReadLine();
        while(true){
            if (!Validar.validarIndice(resposta, 5)){
            Console.WriteLine("Indice incorreto!! ");
            Console.Write("-->");
            resposta = Console.ReadLine();
        }else{
            indice = Convert.ToInt32(resposta);
            break;
        }}
        return indice; 
    }
}