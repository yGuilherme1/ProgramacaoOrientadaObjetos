public class Cliente
{
    int Id;
    string Email;
    string Telefone;
    public Endereco endereco;
}

public class ClientePJ : Cliente
{
    public string CNPJ;
    public string RazaoSocial;
    public string NomeFantasia;
}

public class ClientePF : Cliente
{
    public string Nome;
    public string Cpf;
    public string Formacao;
}