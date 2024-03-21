using static System.Console;

public class Produto
{
    public string id;
    public string descricao;
    public string unidade;
    public int quantidade;
    public double preco;

    public Produto(string id, string descricao, string unidade, double preco, int quantidade)
    {
        this.id = id;
        this.descricao = descricao;
        this.unidade = unidade;
        this.preco = preco;
        this.quantidade = quantidade;
    }

    public void SetPreco(double preco)
    {
        if (preco > 0)
        {
            this.preco = preco;
        }
        else
        {
            WriteLine("Valor Invalido");
        }
    }

    public double GetPreco()
    {
        return preco;
    }

    public void SetUnidade(string unidade)
    {
        unidade = unidade.ToUpper();
        if (unidade == "LT" 
            || unidade == "CX" 
            || unidade == "KG" 
            || unidade == "UN"
            || unidade == "MT") 
        { 
            this.unidade = unidade;
        }
        else
        {
            WriteLine("Unidade não permitida");
        }
    }

    public string GetUnidade()
    {
        return unidade;
    }
}