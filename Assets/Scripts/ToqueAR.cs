using UnityEngine;

public class ToqueAR : MonoBehaviour
{
    public Camera cameraAR;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            VerificarClique(Input.mousePosition);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            VerificarClique(Input.GetTouch(0).position);
    }

    void VerificarClique(Vector2 posicaoTela)
    {
        if (cameraAR == null)
        {
            Debug.LogError("Camera AR não conectada no ToqueAR!");
            return;
        }

        Ray ray = cameraAR.ScreenPointToRay(posicaoTela);

        if (Physics.Raycast(ray, out RaycastHit hit, 100f))
        {
            Debug.Log("Acertou: " + hit.collider.name);

            ObjetoClicavel clicavel = hit.collider.GetComponentInParent<ObjetoClicavel>();

            if (clicavel != null)
            {
                clicavel.Clicou();
            }
            else
            {
                Debug.LogError("Não encontrei ObjetoClicavel no objeto clicado nem nos pais.");
            }
        }
    }
}