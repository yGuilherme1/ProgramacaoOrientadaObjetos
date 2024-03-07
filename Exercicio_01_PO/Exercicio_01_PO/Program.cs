using static System.Console;
using static System.Convert;

Conta C = new();
Conta C2 = new();
Random R = new();

C.id = R.Next(1000, 10000);
WriteLine("Digite o seu nome: ");
C.proprietario = ReadLine();
WriteLine("\nDigite a agencia: ");
C.agencia = ReadLine();
WriteLine("\nDigite o numero da conta: ");
C.conta = ToInt32(ReadLine());
C.saldo = 1000.00;

WriteLine(@"
Escolha a opção 
[1] Deposito 
[2] Saque 
[3] Transferir 
[4] Cancelar");
int op = ToInt32(ReadLine());

switch (op)
{
    case 1:
        {
            Clear();
            WriteLine("Qual valor você deseja depositar? ");
            double valor = ToDouble(ReadLine());
            C.Depositar(valor);
            break;
        }
    case 2:
        {
            Clear();
            WriteLine("Qual valor você deseja sacar? ");
            double valor = ToDouble(ReadLine());
            C.Saque(valor);
            break;
        }
    case 3:
        {
            Clear();
            C2.id = R.Next(1000, 10000);
            WriteLine("Digite o nome do dono da conta.");
            C2.proprietario = ReadLine();
            WriteLine("Digite a agencia.");
            C2.agencia = ReadLine();
            WriteLine("Digite o número da conta.");
            C2.conta = ToInt32(ReadLine());
            C2.saldo = 2000.00;

            WriteLine("Qual valor você deseja transferir?");
            double valor = ToDouble(ReadLine());
            C.Transferir(C2, valor);
            break;
        }
    case 4:
        {
            return;
        }
    default:
        {
            WriteLine("Opção invalida.");
            break;
        }
}