public class Conta
{
    public int nConta;
    public string Agencia;
    public string Titular;
    protected double Saldo;

    public Conta(int nConta, string agencia, string titular, double saldo)
    {
        this.nConta = nConta;
        Agencia = agencia;
        Titular = titular;
        Saldo = saldo;
    }

    protected void SetSaldo(double valor) {Saldo = valor; }

    public virtual void Sacar(double valor)
    {
        if(valor < Saldo)
        {
            double saque = Saldo - valor;
            SetSaldo(saque);
            Console.WriteLine($"Saque realizado com sucesso! Valor Restante: R${Saldo}");
        }
        else 
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}

public class ContaEstudante : Conta
{
    public double LimiteChequeEspecial;
    public string Cpf;
    public string NomeInstituicao;

    public ContaEstudante(double limiteChequeEspecial, string cpf, string nomeInstituicao, int nConta, string agencia, string titular, double saldo) : base(nConta, agencia, titular, saldo)
    {
        LimiteChequeEspecial = limiteChequeEspecial;
        Cpf = cpf;
        NomeInstituicao = nomeInstituicao;
    }

    public override void Sacar(double valor)
    {
        if(valor < Saldo + LimiteChequeEspecial)
        {
            double saque = Saldo - valor;
            SetSaldo(saque);
            Console.WriteLine($"Saque realizado com sucesso! Valor Restante: R${Saldo}");
        }
        else
        {
            Console.WriteLine("O valor de saque excede o valor da conta e o cheque especial!");
        }
    }
}

public class ContaEmpresarial : Conta
{
    public double Anuidade;
    public double LimiteEmprestimo;
    public double TotalEmprestimo;

    public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo, int nConta, string agencia, string titular, double saldo) : base(nConta, agencia, titular, saldo)
    {
        Anuidade = anuidade;
        LimiteEmprestimo = limiteEmprestimo;
        TotalEmprestimo = totalEmprestimo;
    }

    public void FazerEmprestimo(double valor)
    {

    }

    public override void Sacar(double valor)
    {
        double taxaSaque = 5;
        if (valor <= Saldo + taxaSaque)
        {
            Saldo -= valor - taxaSaque;
        }
        else if (valor < Saldo)
        {
            double saque = Saldo - valor;
            SetSaldo(saque);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }
}