using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    // if there are more than Red, Blue or Yellow colours this abstract class wont work
    // it by having only Red, Blue or Yellow it does not feel like abstract class
    abstract class Shape
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int AdditionalCharge { get; set; }
        public int NumberOfRedShape { get; set; }
        public int NumberOfBlueShape { get; set; }
        public int NumberOfYellowShape { get; set; }
        public int TotalQuantityOfShape()
        {
            return NumberOfRedShape + NumberOfBlueShape + NumberOfYellowShape;
        }

        public int AdditionalChargeTotal()
        {
            return NumberOfRedShape * AdditionalCharge;
        }
        public abstract int Total();

    }
}
