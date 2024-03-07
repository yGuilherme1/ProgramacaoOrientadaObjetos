public class Voo
{
    public string numeroVoo;
    public DateTime data;
    public int ocupacaoMax;
    public int ocupacaoAtual;

    public Voo(string numeroVoo, DateTime data, int ocupacaoMax)
    {
        this.numeroVoo = numeroVoo;
        this.data = data;
        this.ocupacaoMax = ocupacaoMax;
    }

    public int ProximoLivre() 
    {

    }
}