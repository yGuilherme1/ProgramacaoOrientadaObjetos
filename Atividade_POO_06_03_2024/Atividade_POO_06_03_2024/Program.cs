using static System.Console;
using static System.Convert;

Voo v = new Voo(1, DateTime.Now, 100);

v.Ocupa(10);

WriteLine(v.Verifica(9));

/* TESTES
v.poltronas[0] = true;
WriteLine(v.ProximoLivre());


for(int i = 0; i < v.qtdVagas; i++)
{
    WriteLine(v.poltronas[i]);
}
*/
