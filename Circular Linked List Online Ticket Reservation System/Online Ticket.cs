using System;
using System.Collections.Generic;

class TicketNode
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public TicketNode Next;

    public TicketNode(int ticketID, string customerName, string movieName, string seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

class TicketReservationSystem
{
    private TicketNode head;

    public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber)
    {
        TicketNode newTicket = new TicketNode(ticketID, customerName, movieName, seatNumber);
        if (head == null)
        {
            head = newTicket;
            head.Next = head;
        }
        else
        {
            TicketNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;
            temp.Next = newTicket;
            newTicket.Next = head;
        }
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null)
            return;

        TicketNode temp = head, prev = null;
        do
        {
            if (temp.TicketID == ticketID)
            {
                if (prev == null) 
                {
                    TicketNode last = head;
                    while (last.Next != head)
                        last = last.Next;
                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    prev.Next = temp.Next;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }
        TicketNode temp = head;
        do
        {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchTicket(string query)
    {
        if (head == null)
            return;
        TicketNode temp = head;
        do
        {
            if (temp.CustomerName.Contains(query) || temp.MovieName.Contains(query))
                Console.WriteLine($"Found Ticket - ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    public int CountTickets()
    {
        if (head == null)
            return 0;
        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);
        return count;
    }
}

class Program
{
    static void Main()
    {
        TicketReservationSystem trs = new TicketReservationSystem();
        trs.AddTicket(1, "Alice", "Movie A", "A1");
        trs.AddTicket(2, "Bob", "Movie B", "B2");
        trs.AddTicket(3, "Charlie", "Movie A", "A3");

        trs.DisplayTickets();
        trs.RemoveTicket(2);
        trs.DisplayTickets();
        trs.SearchTicket("Alice");
        Console.WriteLine("Total Tickets: " + trs.CountTickets());
    }
}