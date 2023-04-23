using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public interface ISortStrategy
{
    List<Player> Sort(List<Player> players);
}

public class DefaultSort : ISortStrategy
{
    public List<Player> Sort(List<Player> players)
    {
        Debug.Log("Leave sort order as-is...");
        return players;
    }
}

public class TopRankSort : ISortStrategy
{
    public List<Player> Sort(List<Player> players)
    {
        Debug.Log("Sorted by rank!");
        return players.OrderBy(x => x.Rank).ToList();
    }
}

public class AlphabeticalSort : ISortStrategy
{
    public List<Player> Sort(List<Player> players)
    {
        Debug.Log("Sorted by first letter!");
        players.Sort((first, second) => string.Compare(first.name, second.name));
        return players.ToList();
    }
}

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