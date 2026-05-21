using UnityEngine;

public class ModoJogo : MonoBehaviour
{
    [Header("Telas")]
    public GameObject telaModo;

    public GameObject telaNomes;

    public GameObject telaAlerta;

    // ===== JOGAR SOZINHO =====
    public void JogarSozinho()
    {
        // Reseta jogo
        GameManager.instance.ResetarJogo();

        // Define modo solo
        GameManager.instance.modoAmigos = false;

        // Adiciona jogador
        GameManager.instance.AdicionarJogador("Você");

        // Fecha tela modo
        telaModo.SetActive(false);

        // Abre alerta
        telaAlerta.SetActive(true);
    }

    // ===== JOGAR COM AMIGOS =====
    public void JogarComAmigos()
    {
        // Reseta jogo
        GameManager.instance.ResetarJogo();

        // Define modo grupo
        GameManager.instance.modoAmigos = true;

        // Fecha tela modo
        telaModo.SetActive(false);

        // Abre tela nomes
        telaNomes.SetActive(true);
    }
}