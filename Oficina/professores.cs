 public class Professor{
    public string nome { get; set;}
    public string telefone { get;set; }
    public string turma { get; set; }

    static void CadastrarProfessor(List<Professor> professores){
        Console.Write("Cadastrando Professor\n\n");
        Console.Write("Digite o Nome do professor: ");
        string nome = Console.ReadLine().Trim();
        nome = Validar.NomeValido(nome);

        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine().Trim();
        
        telefone = Validar.IsTelefoneValido(telefone);

        Console.Write("Digite o Nome do professor: ");
        string turma = Console.ReadLine().Trim();

        professores.Add(new Professor{
            nome = nome,
            telefone = telefone,
            turma = turma
        });
    }

}
