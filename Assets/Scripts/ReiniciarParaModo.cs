using UnityEngine;

public class ReiniciarParaModo : MonoBehaviour
{
    [Header("Tela Inicial")]
    public GameObject telaModo;

    [Header("Todas as telas")]
    public GameObject[] telas;

    [Header("Todos os objetos 3D")]
    public GameObject[] objetos3D;

    [Header("HUD")]
    public GameObject hud;

    [Header("Timer")]
    public GameTimer timer;

    public void Reiniciar()
    {
        // ===== Resetar GameManager =====
        GameManager.instance.ResetarJogo();

        // ===== Desligar telas =====
        foreach (GameObject tela in telas)
        {
            tela.SetActive(false);
        }

        // ===== Desligar objetos 3D =====
        foreach (GameObject obj in objetos3D)
        {
            obj.SetActive(false);
        }

        // ===== HUD =====
        hud.SetActive(false);

        // ===== Timer =====
        timer.ResetarTimer();

        timer.Pausar();

        // ===== Tela inicial =====
        telaModo.SetActive(true);
    }
}