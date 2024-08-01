using System.Security.Cryptography.X509Certificates;

internal class Endereco
{
    public int ID;
    public string Rua;
    public string Numero;
    public string Bairro;

    public Endereco(int iD, string rua, string numero, string bairro)
    {
        ID = iD;
        Rua = rua;
        Numero = numero;
        Bairro = bairro;
    }

    public override string ToString()
    {
        return
            $"\n    Logradouro: {Rua}, #{Numero};" +
            $"\n    Bairro: {Bairro}.";
    }
}

