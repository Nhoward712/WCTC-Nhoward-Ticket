using System;
namespace lesson2
{
    public abstract class Tickets
    {
        public Tickets(int ticketNumber, string summary, string status, string priority,
            string submittedBy, string assingedTo, string watching)
    {
            this.ticketNumber=ticketNumber;
            this.summary = summary;
            this.status = status;
            this.priority = priority;
            this.submittedBy = submittedBy;
            this.assignedTo = assignedTo;
            this.watching = watching;
    }
        
        public int ticketNumber { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string submittedBy { get; set; }
        public string assignedTo { get; set; }
        public string watching { get; set; }

    }
       

}

