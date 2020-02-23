using System;

namespace lesson2
{
    public abstract class Tickets
    {
        public int ticketNumber { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string submittedBy { get; set; }
        public string assignedTo { get; set; }
        public string watching { get; set; }
        
        public Tickets()
        {
        
        }
    }
}

