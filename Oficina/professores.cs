 public class Professor{
    public string nome { get; set;}
    public string telefone { get;set; }
    public string turma { get; set; }

    public static void CadastrarProfessor(List<Professor> professores){
        Console.Write("Cadastrando Professor\n\n");
        Console.Write("\nDigite o nome completo do professor: ");
        string nome = Console.ReadLine().Trim();
        nome = Validar.NomeValido(nome);

        Console.Write("\nDigite o telefone: ");
        string telefone = Console.ReadLine().Trim();
        
        telefone = Validar.IsTelefoneValido(telefone);

        Console.Write("\nDigite a turma do professor: ");
        string turma = Console.ReadLine().Trim();

        professores.Add(new Professor{
            nome = nome,
            telefone = telefone,
            turma = turma
        });
    }

}
