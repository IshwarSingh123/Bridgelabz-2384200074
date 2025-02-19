using System;
using System.Collections.Generic;

class Policy : IComparable<Policy>
{
    public string PolicyNumber { get; }
    public string HolderName { get; }
    public DateTime ExpiryDate { get; }

    public Policy(string policyNumber, string holderName, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        HolderName = holderName;
        ExpiryDate = expiryDate;
    }

    // Ensures uniqueness in HashSet
    public override bool Equals(object obj)
    {
        return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    // Sorting by Expiry Date for SortedSet
    public int CompareTo(Policy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override string ToString()
    {
        return $"PolicyNumber: {PolicyNumber}, Holder: {HolderName}, Expiry: {ExpiryDate:yyyy-MM-dd}";
    }
}

class PolicyManagementSystem
{
    private HashSet<Policy> policySet = new HashSet<Policy>(); // Fast lookup
    private LinkedList<Policy> orderedPolicies = new LinkedList<Policy>(); // Maintains insertion order
    private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(); // Sorted by Expiry Date

    public void AddPolicy(Policy policy)
    {
        if (policySet.Add(policy)) // Ensures uniqueness
        {
            orderedPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }
    }

    public void DisplayPolicies()
    {
        Console.WriteLine("\nPolicies in Insertion Order:");
        foreach (var policy in orderedPolicies)
            Console.WriteLine(policy);

        Console.WriteLine("\nPolicies Sorted by Expiry Date:");
        foreach (var policy in sortedPolicies)
            Console.WriteLine(policy);
    }

    public static void Main()
    {
        PolicyManagementSystem system = new PolicyManagementSystem();

        system.AddPolicy(new Policy("P001", "Ajay", new DateTime(2025, 12, 01)));
        system.AddPolicy(new Policy("P002", "Boby", new DateTime(2024, 06, 15)));
        system.AddPolicy(new Policy("P003", "Chandan", new DateTime(2026, 03, 10)));
        system.AddPolicy(new Policy("P001", "Anil", new DateTime(2025, 12, 01))); // Duplicate, won't be added

        system.DisplayPolicies();
    }
}
