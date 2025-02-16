using System;
using System.Collections.Generic;

class UserNode
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public UserNode Next;

    public UserNode(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head;

    public void AddUser(int userID, string name, int age)
    {
        UserNode newUser = new UserNode(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            UserNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newUser;
        }
    }

    public void AddFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);
        if (user1 != null && user2 != null)
        {
            if (!user1.FriendIDs.Contains(userID2))
                user1.FriendIDs.Add(userID2);
            if (!user2.FriendIDs.Contains(userID1))
                user2.FriendIDs.Add(userID1);
        }
    }

    public void RemoveFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);
        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
        }
    }

    public void DisplayFriends(int userID)
    {
        UserNode user = FindUser(userID);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.Name}:");
            foreach (var friendID in user.FriendIDs)
                Console.WriteLine(friendID);
        }
    }

    public void FindMutualFriends(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);
        if (user1 != null && user2 != null)
        {
            List<int> mutualFriends = new List<int>(user1.FriendIDs);
            mutualFriends = mutualFriends.FindAll(id => user2.FriendIDs.Contains(id));
            Console.WriteLine("Mutual Friends:");
            foreach (var id in mutualFriends)
                Console.WriteLine(id);
        }
    }

    public void SearchUser(string name)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"User Found: ID {temp.UserID}, Name: {temp.Name}, Age: {temp.Age}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found.");
    }

    public void SearchUser(int userID)
    {
        UserNode user = FindUser(userID);
        if (user != null)
            Console.WriteLine($"User Found: ID {user.UserID}, Name: {user.Name}, Age: {user.Age}");
        else
            Console.WriteLine("User not found.");
    }

    private UserNode FindUser(int userID)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();
        sm.AddUser(1, "Alice", 25);
        sm.AddUser(2, "Bob", 27);
        sm.AddUser(3, "Charlie", 22);

        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);
        sm.DisplayFriends(1);
        sm.FindMutualFriends(2, 3);
        sm.SearchUser("Alice");
    }
}
