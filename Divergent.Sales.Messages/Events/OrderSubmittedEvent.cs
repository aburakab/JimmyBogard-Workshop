using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divergent.Sales.Messages.Events
{
    public class OrderSubmittedEvent
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public List<int> Products { get; set; }
    }
}
