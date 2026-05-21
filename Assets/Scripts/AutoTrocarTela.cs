using UnityEngine;

public class AutoTrocarTela : MonoBehaviour
{
    public GameObject proximaTela;
    public float tempo = 2f;

    void OnEnable()
    {
        Invoke("Trocar", tempo);
    }

    void Trocar()
    {
        gameObject.SetActive(false);
        proximaTela.SetActive(true);
    }
}