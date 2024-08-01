internal class Aluno
{
    public string Nome;
    public int Matricula;
    public string CPF;
    public string Email;
    public DateOnly DataNasci;
    public int Idade;
    public Endereco Endereco;

    public Aluno(string nome, int matrícula, string cPF, string email, DateOnly dataNasci)
    {
        Nome = nome;
        Matricula = matrícula;
        CPF = cPF;
        Email = email;
        DataNasci = dataNasci;
        Idade = VerIdade(dataNasci);
    }

    public override string ToString()
    {
        return
            $"\n    Aluno: {Nome};" +
            $"\n    Matrícula: {Matricula};" +
            $"\n    CPF: {CPF};" +
            $"\n    Email: {Email};" +
            $"\n    Data de Nascimento: {DataNasci};" +
            $"\n    Idade: {Idade}." +
             "\n    ---------------------------------\n";
    }

    public int VerIdade(DateOnly nasci)
    {
        DateTime hoje = DateTime.Now;
        int idade = hoje.Year - nasci.Year;
        if (hoje.Month < nasci.Month || (hoje.Month == nasci.Month && hoje.Day < nasci.Day))
        {
            idade--;
        }
        return idade;
    }
}
