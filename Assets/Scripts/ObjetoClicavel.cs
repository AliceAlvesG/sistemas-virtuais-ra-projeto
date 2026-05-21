using UnityEngine;

public class ObjetoClicavel : MonoBehaviour
{
    public GameObject telaQuiz;

    public void Clicou()
    {
        if (telaQuiz == null)
        {
            Debug.LogError("Tela_Quiz não foi conectada!");
            return;
        }

        gameObject.SetActive(false);
        telaQuiz.SetActive(true);
    }
}