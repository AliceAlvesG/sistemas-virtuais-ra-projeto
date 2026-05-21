using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ===== Singleton =====
    public static GameManager instance;

    // ===== Lista jogadores =====
    public List<JogadorData> jogadores =
        new List<JogadorData>();

    // ===== Índice atual =====
    public int jogadorAtualIndex = 0;

    // ===== Modo =====
    public bool modoAmigos = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ===== Adicionar jogador =====
    public void AdicionarJogador(string nome)
    {
        if (!string.IsNullOrEmpty(nome))
        {
            jogadores.Add(new JogadorData(nome));
        }
    }

    // ===== Jogador atual =====
    public JogadorData GetJogadorAtual()
    {
        if (jogadores.Count == 0)
        {
            Debug.LogWarning("Sem jogadores!");

            return null;
        }

        return jogadores[jogadorAtualIndex];
    }

    // ===== Próximo jogador =====
    public bool TemProximoJogador()
    {
        return jogadorAtualIndex < jogadores.Count - 1;
    }

    // ===== Avançar =====
    public void IrParaProximoJogador()
    {
        if (TemProximoJogador())
        {
            jogadorAtualIndex++;
        }
    }

    // ===== Adicionar insígnia =====
    public void AdicionarInsignia()
    {
        JogadorData jogador = GetJogadorAtual();

        if (jogador != null)
        {
            jogador.insignias++;
        }
    }

    // ===== Reset =====
    public void ResetarJogo()
    {
        jogadores.Clear();

        jogadorAtualIndex = 0;

        modoAmigos = false;
    }

    // ===== Ranking =====
    public List<JogadorData> GetRanking()
    {
        List<JogadorData> ranking =
            new List<JogadorData>(jogadores);

        ranking.Sort((a, b) =>
        {
            // Mais insígnias primeiro
            if (b.insignias != a.insignias)
            {
                return b.insignias.CompareTo(a.insignias);
            }

            // Desempate por tempo
            return a.tempo.CompareTo(b.tempo);
        });

        return ranking;
    }
}