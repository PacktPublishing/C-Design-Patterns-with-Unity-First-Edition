using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Client : MonoBehaviour
{
    public TMP_Text Leaderboard;
    public List<Player> Players;

    void Start()
    {
        
    }

    public void RankSort()
    {

    }

    public void AlphabeticalSort()
    {

    }

    private void UpdateLeaderboard(List<Player> players)
    {
        Leaderboard.text = "";

        for (int i = 0; i < players.Count; i++)
        {
            Leaderboard.text += $"#{i + 1}: {players[i].name}\n\n";
        }
    }
}