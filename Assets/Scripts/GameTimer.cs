using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float tempo = 300f;

    public TMP_Text textoTempo;

    bool rodando = false;

    void Update()
    {
        if (!rodando)
            return;

        tempo -= Time.deltaTime;

        if (tempo < 0)
            tempo = 0;

        AtualizarUI();
    }

    void AtualizarUI()
    {
        int minutos = Mathf.FloorToInt(tempo / 60);
        int segundos = Mathf.FloorToInt(tempo % 60);

        textoTempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");
    }

    public void Iniciar()
    {
        rodando = true;
    }

    public void Pausar()
    {
        rodando = false;
    }

    public void Continuar()
    {
        rodando = true;
    }

    public void ResetarTimer()
    {
        tempo = 300f;
        AtualizarUI();
    }
}