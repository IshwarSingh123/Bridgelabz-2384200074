using System;
using System.Collections.Generic;

class TextNode
{
    public string Content;
    public TextNode Prev;
    public TextNode Next;

    public TextNode(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextNode current;
    private int maxHistory;
    private int historyCount;

    public TextEditor(int maxHistory = 10)
    {
        this.maxHistory = maxHistory;
        this.historyCount = 0;
        current = null;
    }

    public void AddTextState(string content)
    {
        TextNode newNode = new TextNode(content);
        if (current != null)
        {
            newNode.Prev = current;
            current.Next = newNode;
        }
        current = newNode;
        historyCount++;
        TrimHistory();
    }

    public void Undo()
    {
        if (current?.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No more undo actions available.");
        }
    }

    public void Redo()
    {
        if (current?.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No more redo actions available.");
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
            Console.WriteLine("Current State: " + current.Content);
        else
            Console.WriteLine("No text available.");
    }

    private void TrimHistory()
    {
        if (historyCount > maxHistory)
        {
            TextNode temp = current;
            while (temp.Prev != null)
                temp = temp.Prev;
            temp.Next.Prev = null;
            temp.Next = null;
            historyCount--;
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.AddTextState("Hello");
        editor.AddTextState("Hello, World");
        editor.AddTextState("Hello, World!");
        
        editor.DisplayCurrentState();
        editor.Undo();
        editor.DisplayCurrentState();
        editor.Redo();
        editor.DisplayCurrentState();
    }
}
