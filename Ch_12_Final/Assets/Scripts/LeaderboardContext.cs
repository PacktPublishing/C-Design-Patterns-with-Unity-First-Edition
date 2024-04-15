using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardContext
{
    private ISortStrategy _strategy;

    public LeaderboardContext(ISortStrategy strategy = null)
    {
        if (strategy == null)
            _strategy = new DefaultSort();
        else
            _strategy = strategy;
    }

    public void SetStrategy(ISortStrategy newStrategy)
    {
        _strategy = newStrategy;
    }

    public List<Player> SortPlayers(List<Player> players)
    {
        return _strategy.Sort(players);
    }
}