using UnityEngine;

public class IniciarAR : MonoBehaviour
{
    public GameObject telaInstrucao;
    public GameObject telaAR;
    public GameObject objeto;
    public GameTimer timer;

    public void Comecar()
    {
        if (telaInstrucao == null)
        {
            Debug.LogError("Tela Instrucao não foi conectada!");
            return;
        }

        if (telaAR == null)
        {
            Debug.LogError("Tela AR não foi conectada!");
            return;
        }

        if (objeto == null)
        {
            Debug.LogError("Objeto/Cadeado não foi conectado!");
            return;
        }

        if (timer == null)
        {
            Debug.LogError("Timer não foi conectado!");
            return;
        }

        telaInstrucao.SetActive(false);
        telaAR.SetActive(true);
        objeto.SetActive(true);
        timer.Iniciar();
    }
}