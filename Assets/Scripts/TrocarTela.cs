using UnityEngine;

public class TrocarTela : MonoBehaviour
{
    public GameObject Atual;

    public GameObject Proxima;

    public void Trocar()
    {
        // Segurança
        if (Atual != null)
        {
            Atual.SetActive(false);
        }

        if (Proxima != null)
        {
            Proxima.SetActive(true);
        }
    }
}