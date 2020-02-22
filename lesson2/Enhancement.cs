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
		public string software { get; set; }
		public string cost { get; set; }
		public string reason { get; set; }
		public string estimate { get; set; }
	}
}