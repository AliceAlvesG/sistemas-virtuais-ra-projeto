using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class RankingController : MonoBehaviour
{
    public TMP_Text nome1;
    public TMP_Text nome2;
    public TMP_Text nome3;

    public GameObject[] insignias1;
    public GameObject[] insignias2;
    public GameObject[] insignias3;

    void OnEnable()
    {
        AtualizarRanking();
    }

    void AtualizarRanking()
    {
        List<JogadorData> lista = GameManager.instance.jogadores;

        lista.Sort((a, b) =>
        {
            if (b.insignias != a.insignias)
                return b.insignias.CompareTo(a.insignias);

            return a.tempo.CompareTo(b.tempo);
        });

        if (lista.Count > 0)
        {
            nome1.text = lista[0].nome;
            AtualizarInsignias(insignias1, lista[0].insignias);
        }

        if (lista.Count > 1)
        {
            nome2.text = lista[1].nome;
            AtualizarInsignias(insignias2, lista[1].insignias);
        }

        if (lista.Count > 2)
        {
            nome3.text = lista[2].nome;
            AtualizarInsignias(insignias3, lista[2].insignias);
        }
    }

    void AtualizarInsignias(GameObject[] insignias, int quantidade)
    {
        for (int i = 0; i < insignias.Length; i++)
        {
            insignias[i].SetActive(i < quantidade);
        }
    }
}