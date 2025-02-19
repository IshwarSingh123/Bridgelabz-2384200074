using System;
using System.Collections.Generic;
using System.Linq;

class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>(); // Store balances
    private SortedDictionary<double, List<int>> sortedAccounts = new SortedDictionary<double, List<int>>(); // Sort by balance
    private Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>(); // Withdrawal requests

    public void AddAccount(int accountNumber, double balance)
    {
        accountBalances[accountNumber] = balance; // Store balance

        // Maintain sorted balance
        if (!sortedAccounts.ContainsKey(balance))
            sortedAccounts[balance] = new List<int>();
        sortedAccounts[balance].Add(accountNumber);
    }

    public void RequestWithdrawal(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
            withdrawalQueue.Enqueue(new Tuple<int, double>(accountNumber, amount));
        else
            Console.WriteLine($"Account {accountNumber} not found.");
    }

    public void ProcessWithdrawals()
    {
        Console.WriteLine("\nProcessing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            var request = withdrawalQueue.Dequeue();
            int accNum = request.Item1;
            double amount = request.Item2;

            if (accountBalances.ContainsKey(accNum) && accountBalances[accNum] >= amount)
            {
                Console.WriteLine($"Withdrawal of ${amount:F2} from Account {accNum} approved.");
                accountBalances[accNum] -= amount;
            }
            else
            {
                Console.WriteLine($"Withdrawal of ${amount:F2} from Account {accNum} denied (Insufficient funds).");
            }
        }
    }

    public void DisplaySortedAccounts()
    {
        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var pair in sortedAccounts)
            foreach (var acc in pair.Value)
                Console.WriteLine($"Account {acc}: ${pair.Key:F2}");
    }

    public static void Main()
    {
        BankingSystem bank = new BankingSystem();

        bank.AddAccount(101, 5000.00);
        bank.AddAccount(102, 1200.50);
        bank.AddAccount(103, 7000.75);
        bank.AddAccount(104, 3500.25);

        bank.RequestWithdrawal(102, 200.00);
        bank.RequestWithdrawal(101, 6000.00); // Should be denied
        bank.RequestWithdrawal(103, 500.00);

        bank.DisplaySortedAccounts(); // Show accounts sorted by balance
        bank.ProcessWithdrawals();    // Process withdrawal requests
    }
}
