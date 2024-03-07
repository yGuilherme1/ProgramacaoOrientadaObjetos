public class Conta
{
    public int id;
    public string? agencia;
    public int conta;
    public string? proprietario;
    public double saldo;

    public void Depositar(double valor)
    {
        saldo += valor;
        if (valor >= 0) 
        {
            Console.WriteLine("\nDeposito realizado com sucesso");
            Console.WriteLine("\nO saldo atual é " + saldo);
        }
        else
        {
            Console.WriteLine("Não é permitido valores negativos");
        }
    }

    public void Saque(double valor)
    {
        saldo -= valor;
        if (valor > saldo) 
        {
            Console.WriteLine("\nSaldo insuficiente");
        }
        else if (valor < 0)
        {
            Console.WriteLine("\nNão é permitido valores negativos");
        }
        else
        {
            Console.WriteLine("\nSaque realizado com sucesso");
            Console.WriteLine("\nO saldo atual é " + saldo);
        }
    }

    public void Transferir(Conta destino, double valor)
    {
        destino.saldo += valor;
        saldo -= valor;
        Console.WriteLine("\nTransferência realizado com sucesso");
        Console.WriteLine("\nO saldo atual é " + saldo);
    }
}