using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    abstract class Order
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string DueDate { get; set; }
        public int OrderNumber { get; set; }
        public List<Shape> OrderedBlocks { get; set; }

        public abstract void GenerateReport();
        
        //ToString is a method from System.Object
        // here it feels like used as a normal method.
        // override or use  new keyword if Object.ToString() was intended to be overridden
        public string ToString()
        {
            return "\nName: " + CustomerName + " Address: " + Address + " Due Date: " + DueDate + " Order #: " + OrderNumber;
        }
    }
}
