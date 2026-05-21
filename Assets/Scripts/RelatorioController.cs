using UnityEngine;
using TMPro;

public class RelatorioController : MonoBehaviour
{
    public GameObject insignia1;
    public GameObject insignia2;
    public GameObject insignia3;

    public TMP_Text textoTempo;

    void OnEnable()
    {
        MostrarDados();
    }

    void MostrarDados()
    {
        var jogador = GameManager.instance.GetJogadorAtual();

        // ===== INSÍGNIAS =====
        insignia1.SetActive(jogador.insignias >= 1);
        insignia2.SetActive(jogador.insignias >= 2);
        insignia3.SetActive(jogador.insignias >= 3);

        // ===== TEMPO GASTO =====
        float tempoGasto = 300f - jogador.tempo;

        int minutos =
            Mathf.FloorToInt(tempoGasto / 60);

        int segundos =
            Mathf.FloorToInt(tempoGasto % 60);

        textoTempo.text =
            minutos.ToString("00") + ":" +
            segundos.ToString("00");
    }
}