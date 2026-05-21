using UnityEngine;

public class ControleMusica : MonoBehaviour
{
    public AudioSource musica;

    public void LigarMusica()
    {
        musica.mute = false;
    }

    public void DesligarMusica()
    {
        musica.mute = true;
    }
}