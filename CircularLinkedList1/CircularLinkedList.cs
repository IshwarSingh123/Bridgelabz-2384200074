using System;

class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public TaskNode Next;

    public TaskNode(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head;
    private TaskNode current;

    public void AddTaskAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
            current = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            newNode.Next = head;
            temp.Next = newNode;
            head = newNode;
        }
    }

    public void AddTaskAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
            current = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }
    }

    public void AddTaskAtPosition(int taskID, string taskName, int priority, DateTime dueDate, int position)
    {
        if (position <= 0)
        {
            AddTaskAtBeginning(taskID, taskName, priority, dueDate);
            return;
        }

        TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
        TaskNode temp = head;
        for (int i = 0; temp.Next != head && i < position - 1; i++)
        {
            temp = temp.Next;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void RemoveTaskByID(int taskID)
    {
        if (head == null)
            return;

        TaskNode temp = head, prev = null;
        do
        {
            if (temp.TaskID == taskID)
            {
                if (prev != null)
                    prev.Next = temp.Next;
                else
                {
                    TaskNode last = head;
                    while (last.Next != head)
                        last = last.Next;
                    head = temp.Next;
                    last.Next = head;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void ViewCurrentTaskAndMoveNext()
    {
        if (current == null)
            return;
        Console.WriteLine($"Task ID: {current.TaskID}, Name: {current.TaskName}, Priority: {current.Priority}, Due: {current.DueDate}");
        current = current.Next;
    }

    public void DisplayAllTasks()
    {
        if (head == null)
            return;

        TaskNode temp = head;
        do
        {
            Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
            return;

        TaskNode temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No matching tasks found.");
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTaskAtEnd(1, "Task A", 2, DateTime.Now.AddDays(1));
        scheduler.AddTaskAtBeginning(2, "Task B", 1, DateTime.Now.AddDays(2));
        scheduler.AddTaskAtEnd(3, "Task C", 3, DateTime.Now.AddDays(3));

        Console.WriteLine("Task List:");
        scheduler.DisplayAllTasks();

        Console.WriteLine("\nViewing and moving to next task:");
        scheduler.ViewCurrentTaskAndMoveNext();
        scheduler.ViewCurrentTaskAndMoveNext();
    }
}
