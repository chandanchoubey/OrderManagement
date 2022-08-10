using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Triangle : Shape
    {
        public int TrianglePrice = 2;
        /*
         hard coded value, it is public field so it can be set from outside but makes no difference 
         to the program after constructor has run and it is actually setting base class
         price which too can be set from outside.

         all base class  properties are public means can be set after object instantiation
         they should be made protected, if you want only inherting class to access it.

         passing values in the constructor and then allowing setters to set value again
         kind of defeats the purpose of contructor overloading.

         we can utilise dependency injection and allow it to be set only in constructor.
         and make them readonly

         all inheriting classes of Shape have pretty much the same code, they only differ by valus 
         of name and Price which can be set too.

         this can be further abstracted to just one class.
        */
        public Triangle(int numberOfRedTriangles, int numberOfBlueTriangles, int numberOfYellowTriangles)
        {
            Name = "Triangle"; // hard coded value inside class
            base.Price = TrianglePrice;
            AdditionalCharge = 1;
            base.NumberOfRedShape = numberOfRedTriangles;
            base.NumberOfBlueShape = numberOfBlueTriangles;
            base.NumberOfYellowShape = numberOfYellowTriangles;
        }

        public override int Total()
        {
            return RedTrianglesTotal() + BlueTrianglesTotal() + YellowTrianglesTotal();
        }
        // following methods can be abstracted to base class because they 
        // are using base class properties only
        public int RedTrianglesTotal()
        {
            return (base.NumberOfRedShape * Price);
        }
        public int BlueTrianglesTotal()
        {
            return (base.NumberOfBlueShape * Price);
        }
        public int YellowTrianglesTotal()
        {
            return (base.NumberOfYellowShape * Price);
        }
    
}
}
