using TMPro;
using UnityEngine;

public class UIInsignias : MonoBehaviour
{
    public TMP_Text textoInsignias;

    void Update()
    {
        // Verifica GameManager
        if (GameManager.instance == null)
            return;

        // Verifica jogadores
        if (GameManager.instance.jogadores.Count == 0)
            return;

        // Verifica jogador atual
        if (GameManager.instance.GetJogadorAtual() == null)
            return;

        // Atualiza texto
        textoInsignias.text =
            GameManager.instance
            .GetJogadorAtual()
            .insignias
            .ToString();
    }
}