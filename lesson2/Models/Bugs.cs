using System;
using lesson2;
namespace lesson2
{
    public class Bugs: Tickets
    {
        private string Severity{get;set;}

        public Bugs(int ticketNumber, string summary, string status, string priority, string submittedBy,
            string assignedTo, string watching, string severity)
            : base (ticketNumber,summary,status,priority,submittedBy,assignedTo,watching)
        {
        Severity = severity;
        }

      
    }


}
