public class Voo
{
    private int numVoo;
    private DateTime dataHoraVoo;
    public int qtdVagas;
    public bool[] poltronas;

    public Voo(int numVoo, DateTime dataHoraVoo, int qtdVagas)
    {
        this.numVoo = numVoo;
        this.dataHoraVoo = dataHoraVoo;
        this.qtdVagas = qtdVagas;
        poltronas = new bool[qtdVagas];
    }

    public int ProximoLivre()
    {
        for (int i = 0; i < poltronas.Length; i++)
        {
            if (poltronas[i] == false)
            {
                return i + 1;
            }
        }
        return -1;
    }

    public bool Verifica(int nPoltrona)
    {
        if (poltronas[nPoltrona - 1] == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Ocupa(int nPoltrona)
    {
        if (this.Verifica(nPoltrona) == false)
        {
            poltronas[nPoltrona - 1] = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public int Vagas()
    {
        int vagasLivres = 0;
        for(int i = 0; i < poltronas.Length; i++)
        {
            if (poltronas[i] == false)
            {
                vagasLivres += 1;
            }
        }

        return vagasLivres;
    }

    public int GetVoo()
    {
        return numVoo;
    }

    public DateTime GetData()
    {
        return dataHoraVoo;
    }
}