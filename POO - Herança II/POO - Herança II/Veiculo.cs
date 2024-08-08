using static System.Console;
using static System.Convert;

public abstract class Veiculo
{
    public string placa {  get; set; }

    public int qtdEixos {  get; set; }

    public int tipo { get; set; }

    public double precoPedagio { get; set; }

    public double precoFinal { get; set; }

    public Veiculo(string placa, int qtdEixos, int tipo)
    {
        this.placa = placa;
        this.qtdEixos = qtdEixos;
        this.tipo = tipo;
    }

    public abstract void CalcularPedagio();

    public void CalcularDesconto()
    {

    }
}

public class Passeio : Veiculo
{
    public Passeio(string placa, int qtdEixos, int tipo) : base(placa, qtdEixos, tipo) 
    { 
        
    }

    public override void CalcularPedagio()
    {
        precoPedagio = qtdEixos * 3;
    }
}

public class Utilitario : Veiculo
{
    public Utilitario(string placa, int qtdEixos, int tipo) : base(placa, qtdEixos, tipo)
    {

    }

    public override void CalcularPedagio()
    {
        precoPedagio = qtdEixos * 3.5;
        precoPedagio += precoPedagio * 0.02;
    }
}

public class Onibus : Veiculo
{
    public Onibus(string placa, int qtdEixos, int tipo) : base(placa, qtdEixos, tipo)
    {

    }

    public override void CalcularPedagio()
    {
        precoPedagio = qtdEixos * 5;
        precoPedagio += precoPedagio * 0.05;
    }
}

public class Caminhao : Veiculo
{
    public Caminhao(string placa, int qtdEixos, int tipo) : base(placa, qtdEixos, tipo)
    {

    }

    public override void CalcularPedagio()
    {
        precoPedagio = qtdEixos * 7;
        precoPedagio += precoPedagio * 0.10;
    }
}