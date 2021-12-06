using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc
    {
        public CD(int storageCapacity, string name, double discSpeed, List<string> data) : base(storageCapacity, name, discSpeed, data);
        {
    }
        public static void Spindisc()
        {
            Console.WriteLine("A CD spin at the rate of 200-500rpm");
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
