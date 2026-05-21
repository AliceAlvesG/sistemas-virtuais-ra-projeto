[System.Serializable]
public class JogadorData
{
    public string nome;

    public int insignias;

    public float tempo;

    public JogadorData(string nomeJogador)
    {
        nome = nomeJogador;

        insignias = 0;

        tempo = 0;
    }
}