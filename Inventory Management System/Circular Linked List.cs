using System;

class InventoryNode
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public InventoryNode Next;

    public InventoryNode(string itemName, int itemID, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class InventoryManagement
{
    private InventoryNode head;

    public void AddItemAtBeginning(string itemName, int itemID, int quantity, double price)
    {
        InventoryNode newNode = new InventoryNode(itemName, itemID, quantity, price);
        newNode.Next = head;
        head = newNode;
    }

    public void AddItemAtEnd(string itemName, int itemID, int quantity, double price)
    {
        InventoryNode newNode = new InventoryNode(itemName, itemID, quantity, price);
        if (head == null)
        {
            head = newNode;
            return;
        }
        InventoryNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;
        temp.Next = newNode;
    }

    public void AddItemAtPosition(string itemName, int itemID, int quantity, double price, int position)
    {
        if (position <= 0)
        {
            AddItemAtBeginning(itemName, itemID, quantity, price);
            return;
        }

        InventoryNode newNode = new InventoryNode(itemName, itemID, quantity, price);
        InventoryNode temp = head;
        for (int i = 0; temp != null && i < position - 1; i++)
            temp = temp.Next;

        if (temp == null)
            return;

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void RemoveItemByID(int itemID)
    {
        if (head == null)
            return;

        if (head.ItemID == itemID)
        {
            head = head.Next;
            return;
        }

        InventoryNode temp = head;
        while (temp.Next != null && temp.Next.ItemID != itemID)
            temp = temp.Next;

        if (temp.Next == null)
            return;

        temp.Next = temp.Next.Next;
    }

    public void UpdateQuantity(int itemID, int newQuantity)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                temp.Quantity = newQuantity;
                return;
            }
            temp = temp.Next;
        }
    }

    public void SearchItem(int itemID)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                Console.WriteLine($"Item ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void SearchItem(string itemName)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Item ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void CalculateTotalValue()
    {
        double totalValue = 0;
        InventoryNode temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine($"Total Inventory Value: {totalValue}");
    }

    public void DisplayAllItems()
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Item ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagement inventory = new InventoryManagement();
        inventory.AddItemAtEnd("Item A", 101, 5, 10.5);
        inventory.AddItemAtBeginning("Item B", 102, 2, 20.0);
        inventory.AddItemAtEnd("Item C", 103, 3, 15.75);

        Console.WriteLine("Inventory List:");
        inventory.DisplayAllItems();

        Console.WriteLine("\nUpdating quantity of Item 102:");
        inventory.UpdateQuantity(102, 10);
        inventory.DisplayAllItems();

        Console.WriteLine("\nTotal Inventory Value:");
        inventory.CalculateTotalValue();
    }
}