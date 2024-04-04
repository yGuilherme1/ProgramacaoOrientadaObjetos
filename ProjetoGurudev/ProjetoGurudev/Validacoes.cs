
public static class Validacoes
{
    public static bool ValidaCPF(string cpf)
    {
        int soma = 0;
        int resto;
        int digito;

        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            return false;
        }

        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }

        resto = soma % 11;
        digito = resto < 2 ? 0 : 11 - resto;

        if (digito != int.Parse(cpf[9].ToString()))
        {
            return false;
        }

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }

        resto = soma % 11;
        digito = resto < 2 ? 0 : 11 - resto;

        return digito == int.Parse(cpf[10].ToString());
    }
}