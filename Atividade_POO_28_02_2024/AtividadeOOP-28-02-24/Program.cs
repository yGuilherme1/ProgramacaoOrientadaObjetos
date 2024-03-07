using static System.Console;
using static System.Convert;

List<Aluno> listaAluno = new List<Aluno>();

int op;
bool sair = false;

WriteLine("Algoritmo para cadastrar alunos em uma lista.");

while (sair)
{
    WriteLine(@"
    Deseja cadastrar um novo aluno
    [1] Sim
    [2] Não");
    op = ToInt32(ReadLine());

    switch (op)
    {
        case 1:
            Aluno aluno = new Aluno();
            Clear();
            WriteLine("\nQual o nome do aluno?");
            aluno.nome = ReadLine();
            WriteLine("\nQual o CPF  do aluno?");
            aluno.cpf = ReadLine();
            WriteLine("\nQual o email do aluno?");
            aluno.email = ReadLine();

            listaAluno.Add(aluno);

            break;

        case 2:
            sair = true;

            break;

        default:

            break;
    }

    foreach (Aluno aluno in listaAluno)
    {
        WriteLine("--------------------");
        WriteLine($"    {aluno.nome}");
        WriteLine($"    {aluno.cpf}");
        WriteLine($"    {aluno.email}");
    }
}