using System;

class ProcessNode
{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public ProcessNode Next;

    public ProcessNode(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head;
    private ProcessNode tail;
    private int timeQuantum;

    public RoundRobinScheduler(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
    }

    public void AddProcess(int processID, int burstTime, int priority)
    {
        ProcessNode newNode = new ProcessNode(processID, burstTime, priority);
        if (head == null)
        {
            head = tail = newNode;
            tail.Next = head;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;
        }
    }

    public void RemoveProcess(int processID)
    {
        if (head == null) return;

        ProcessNode temp = head, prev = null;
        do
        {
            if (temp.ProcessID == processID)
            {
                if (prev == null) // Head removal
                {
                    tail.Next = head.Next;
                    head = head.Next;
                }
                else
                {
                    prev.Next = temp.Next;
                    if (temp == tail)
                        tail = prev;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void ExecuteProcesses()
    {
        if (head == null) return;

        Console.WriteLine("Executing Processes with Round Robin Scheduling:");
        ProcessNode temp = head;
        while (head != null)
        {
            Console.WriteLine($"Executing Process {temp.ProcessID}, Remaining Burst Time: {temp.BurstTime}");
            if (temp.BurstTime > timeQuantum)
            {
                temp.BurstTime -= timeQuantum;
                temp = temp.Next;
            }
            else
            {
                Console.WriteLine($"Process {temp.ProcessID} Completed.");
                RemoveProcess(temp.ProcessID);
            }
            if (temp == head) break;
        }
    }

    public void DisplayProcesses()
    {
        if (head == null) return;
        ProcessNode temp = head;
        Console.WriteLine("Processes in Queue:");
        do
        {
            Console.WriteLine($"Process ID: {temp.ProcessID}, Burst Time: {temp.BurstTime}, Priority: {temp.Priority}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(4);
        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 3);

        scheduler.DisplayProcesses();
        scheduler.ExecuteProcesses();
    }
}