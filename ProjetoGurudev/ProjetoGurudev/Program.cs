using static System.Console;

string cpf; bool validacao;

Write("Por favor, insira o seu CPF: ");
cpf = ReadLine();

validacao = Validacoes.ValidaCPF(cpf);

if (validacao)
{
    WriteLine("O CPF inserido é válido.");
}
else
{
    WriteLine("O CPF inserido é inválido.");
}