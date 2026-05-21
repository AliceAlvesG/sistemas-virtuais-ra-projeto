using UnityEngine;

public class MusicaPersistente : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}