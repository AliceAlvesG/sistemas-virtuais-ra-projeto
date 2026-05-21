using TMPro;
using UnityEngine;

public class TelaPreparacaoJogador : MonoBehaviour
{
    public TMP_Text textoJogador;

    void OnEnable()
    {
        if (GameManager.instance == null)
            return;

        if (GameManager.instance.jogadores.Count == 0)
            return;

        textoJogador.text =
            "Jogador " +
            GameManager.instance
            .GetJogadorAtual()
            .nome +
            ", se prepare!";
    }
}