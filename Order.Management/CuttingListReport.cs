using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class CuttingListReport : Order
    {
        public int tableWidth = 20; // this is publically accessible field, if 0 or negative 
        // value is set, methods relying on it for string manipulation will crash
        public CuttingListReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes)
        {
            base.CustomerName = customerName;
            base.Address = customerAddress;
            base.DueDate = dueDate;
            base.OrderedBlocks = shapes;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(base.ToString());
            generateTable();
        }
        /*
        hard coded names of the shape
         we can access the names from the list of OrderedBlocks.
        also Array is accessed on index, which makes this class not flexible if we
         want to use  it for less or more variety of shapes.
        if circle is created first or order is changed, it will generate wrong table
            we could use 
            foreach (var item in OrderedBlocks)
            {
                PrintRow(item.Name, item.TotalQuantityOfShape().ToString());
            }
        lack of coding style consistency, sometimes 'base.' is used sometimes not.
         */

        public void generateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   "); // padright or left should be used for blank spaces
            PrintLine();
            PrintRow("Square",base.OrderedBlocks[0].TotalQuantityOfShape().ToString());
            PrintRow("Triangle", base.OrderedBlocks[1].TotalQuantityOfShape().ToString());
            PrintRow("Circle", base.OrderedBlocks[2].TotalQuantityOfShape().ToString());
            PrintLine();
        }
        public void PrintLine()
        {
            // use of new string constructor is unnecessary
            // we can eaisly say
            // Console.WriteLine($"-{tableWidth}");
            Console.WriteLine(new string('-', tableWidth));
        }

        /*
         always check for nullofEmpty for 
         */
        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        // use modern string concatanation like 
        // $"{text.Substring(0, width - 3)}..."
        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }


    }
}
