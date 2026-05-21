using UnityEngine;
using System.Collections;

public class VibrarCelular : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(VibrarVariasVezes());
    }

    IEnumerator VibrarVariasVezes()
    {
        for (int i = 0; i < 3; i++)
        {
            Vibrar();
            yield return new WaitForSeconds(0.3f);
        }
    }

    void Vibrar()
    {
#if UNITY_ANDROID || UNITY_IOS
        Handheld.Vibrate();
#endif
    }
}