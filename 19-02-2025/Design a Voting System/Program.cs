using System;
using System.Collections.Generic;
using System.Linq;

class VotingSystem
{
    private Dictionary<string, int> voteCount = new Dictionary<string, int>(); // Stores votes
    private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(); // Sorted results
    private LinkedList<string> voteOrder = new LinkedList<string>(); // Maintains order of voting

    public void CastVote(string candidate)
    {
        // Store vote count in Dictionary
        if (voteCount.ContainsKey(candidate))
            voteCount[candidate]++;
        else
            voteCount[candidate] = 1;

        // Maintain LinkedList for order
        voteOrder.AddLast(candidate);
    }

    public void DisplayVoteCount()
    {
        Console.WriteLine("\nVote Count:");
        foreach (var pair in voteCount)
            Console.WriteLine($"{pair.Key}: {pair.Value}");
    }

    public void DisplaySortedResults()
    {
        Console.WriteLine("\nSorted Results:");
        foreach (var pair in voteCount.OrderBy(x => x.Key))
            Console.WriteLine($"{pair.Key}: {pair.Value}");
    }

    public void DisplayVoteOrder()
    {
        Console.WriteLine("\nVote Order:");
        foreach (var vote in voteOrder)
            Console.Write($"{vote} -> ");
        Console.WriteLine("End");
    }

    public static void Main()
    {
        VotingSystem system = new VotingSystem();

        system.CastVote("Alice");
        system.CastVote("Bob");
        system.CastVote("Alice");
        system.CastVote("Charlie");
        system.CastVote("Bob");

        system.DisplayVoteCount();   // Unordered count
        system.DisplaySortedResults(); // Sorted by candidate name
        system.DisplayVoteOrder();   // Order in which votes were cast
    }
}
