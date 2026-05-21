using UnityEngine;

public class QuizController : MonoBehaviour
{
    [Header("Telas")]
    public GameObject telaQuiz;
    public GameObject telaSucesso;
    public GameObject telaErro;
    public GameObject telaInsigna;

    [Header("Timer")]
    public GameTimer timer;

    [Header("Resposta correta")]
    public string respostaCorreta;

    [Header("Próxima etapa")]
    public GameObject proximaTela;

    public void Responder(string alternativa)
    {
        if (alternativa == respostaCorreta)
        {
            Correta();
        }
        else
        {
            Errada();
        }
    }

    void Correta()
    {
        telaQuiz.SetActive(false);

        telaSucesso.SetActive(true);

        GameManager.instance.GetJogadorAtual().insignias++;

        timer.Pausar();
    }

    void Errada()
    {
        telaQuiz.SetActive(false);

        telaErro.SetActive(true);

        timer.Pausar();
    }

    public void MostrarInsigna()
    {
        telaSucesso.SetActive(false);

        telaInsigna.SetActive(true);
    }

public GameObject telaRanking;
public GameObject telaRelatorio;


public bool ultimaPergunta = false;

public void Continuar()
{
    telaInsigna.SetActive(false);
    telaErro.SetActive(false);

    // 👉 SE NÃO É O FINAL
    if (!ultimaPergunta)
    {
        if (proximaTela != null)
        {
            proximaTela.SetActive(true);
        }

        timer.Continuar();

        return;
    }

    // 👉 FINAL DO JOGO
    if (GameManager.instance.modoAmigos)
    {
        telaRanking.SetActive(true);
    }
    else
    {
        telaRelatorio.SetActive(true);
    }
}
}