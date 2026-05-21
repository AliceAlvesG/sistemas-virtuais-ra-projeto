using UnityEngine;

public class FluxoJogo : MonoBehaviour
{
    [Header("Grupo gameplay")]
    public GameObject telasGameplay;

    [Header("Finais")]
    public GameObject telaPreparacao;

    public GameObject telaRanking;

    public GameObject telaRelatorio;

    public void Continuar()
{
    // ===== Salva tempo =====
    GameTimer timer = FindFirstObjectByType<GameTimer>();
    if (timer != null)
    {
        GameManager.instance.GetJogadorAtual().tempo = timer.tempo;
    }

    // Fecha gameplay
    foreach (Transform tela in telasGameplay.transform)
    {
        tela.gameObject.SetActive(false);
    }

    // ===== SOLO =====
    if (!GameManager.instance.modoAmigos)
    {
        telaRelatorio.SetActive(true);
        return;
    }

    // ===== MULTIPLAYER =====
    if (GameManager.instance.TemProximoJogador())
    {
        GameManager.instance.IrParaProximoJogador();

        telaPreparacao.SetActive(true);
    }
    else
    {
        telaRanking.SetActive(true);
    }
}
}