using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
	public class Enhancement : Tickets
	{
		//software, cost, reason, estimate
		public string Software { get; set; }
		public string Cost { get; set; }
		public string Reason { get; set; }
		public string Estimate { get; set; }
        public Enhancement (int ticketNumber, string summary, string status, string priority, string submittedBy,
            string assignedTo, string watching, string Software, string Cost, string Reason, string Estimate)
            : base (ticketNumber,summary,status,priority,submittedBy,assignedTo,watching){
        }
    }
}