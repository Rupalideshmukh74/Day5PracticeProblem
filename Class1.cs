using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionProblem
{
    class Class1
    {
        public static void Demo()
        {
            int dividend = 60, divisor = 6;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend : Divisor" + dividend + ":" + divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
