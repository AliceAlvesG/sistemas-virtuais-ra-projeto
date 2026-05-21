using TMPro;
using UnityEngine;

public class CadastroJogadores : MonoBehaviour
{
    [Header("Inputs")]
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_InputField input3;

    [Header("Telas")]
    public GameObject telaCadastro;
    public GameObject telaPreparacaoJogador;

    public void Iniciar()
    {
        // Limpa jogadores antigos
        GameManager.instance.jogadores.Clear();

        // Reseta índice
        GameManager.instance.jogadorAtualIndex = 0;

        // Adiciona jogadores
        if (!string.IsNullOrEmpty(input1.text))
        {
            GameManager.instance.AdicionarJogador(input1.text);
        }

        if (!string.IsNullOrEmpty(input2.text))
        {
            GameManager.instance.AdicionarJogador(input2.text);
        }

        if (!string.IsNullOrEmpty(input3.text))
        {
            GameManager.instance.AdicionarJogador(input3.text);
        }

        Debug.Log("TOTAL JOGADORES: " +
                  GameManager.instance.jogadores.Count);

        // Fecha tela nomes
        telaCadastro.SetActive(false);

        // Abre preparação
        telaPreparacaoJogador.SetActive(true);
    }
}