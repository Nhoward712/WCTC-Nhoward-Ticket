using System;
using System.IO;
using System.Collections.Generic;

namespace lesson2
{
    public class FileManager
    {
        public FileManager(List<Tickets> Ticket)
        {
            this.Ticket = Ticket;

        }
        public Save(List<Tickets> Ticket)
        {
            if (!File.Exists(file))
            {
                using (StreamWriter ticketFile = File.CreateText(file))
                {
                    for (int i = 0; i < Ticket.Count; i++)
                    {
                        ticketFile.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", Ticket.ticketNumber, Ticket.summary,
                               Ticket.status, Ticket.priority, Ticket.submittedBy, Ticket.assignedTo, Ticket.watching);
                        ticketFile.Close();
                    }
                    Console.WriteLine("A Ticket has been created for you.");

                }
            }
            else
            {

                StreamWriter ticketFile = new StreamWriter(file);
                {
                    for (int i = 0; i < Ticket.Count; i++)
                    {
                        ticketFile.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", Ticket.ticketNumber, Ticket.summary,
                               Ticket.status, Ticket.priority, Ticket.submittedBy, Ticket.assignedTo, Ticket.watching);
                        Console.WriteLine("A Ticket has been created for you.");
                        ticketFile.Close();
                    }
                }
            }
        }
    }
}