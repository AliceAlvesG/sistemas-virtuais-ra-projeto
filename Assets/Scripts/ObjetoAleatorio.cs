using UnityEngine;

public class ObjetoAleatorio : MonoBehaviour
{
    void OnEnable()
    {
        if (Camera.main == null)
        {
            Debug.LogError("Camera principal não encontrada!");
            return;
        }

        Vector3 pos = Camera.main.transform.position +
                      Random.onUnitSphere * 2f;

        pos.y = Mathf.Abs(pos.y);

        transform.position = pos;
    }
}