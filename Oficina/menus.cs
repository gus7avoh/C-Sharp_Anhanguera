public class Menus{
     static int Mostrar_menu(){
        Console.Write("1 - Acessar o painel de demandas");
        Console.Write("2 - Cadastrar Tarefa");
        Console.Write("3 - Cadastrar professor");
        Console.Write("4 - Sair");
        Console.Write("-->");
        int resposta = Convert.ToInt32(Console.ReadLine());
        
        return resposta;
    }

    static int Mostrar_Demandas(){
        Console.Write("1 - Visualisar as demandas do dia");
        Console.Write("2 - Adicionar demanda");
        Console.Write("3 - Remover demanda");
        Console.Write("4 - Modificar demanda");// permite buscar pela demanda na lista de demandas diarias e modificar a demanda necessaria.
        Console.Write("5 - Sair");
        Console.Write("-->");
        int resposta = Convert.ToInt32(Console.ReadLine());

        return resposta;
    }

}